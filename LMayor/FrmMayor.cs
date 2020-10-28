using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMayor
{
    public partial class FrmMayor : Form
    {      
      
        #region Constructores
        public FrmMayor()
        {
            InitializeComponent();
            //todo: leer xml desde el objLibro
            DGVM.DataSource = objLibro.tabla;
        }
        #endregion

        #region Propiedades
       LibroMayor objLibro = new LibroMayor();
       Asiento objFila = new Asiento();

        #endregion

        #region Metodos
        private void NuevaMayorización()
        {
            txtFecha.Text = objFila.Fecha.ToString("dd/MM/yyyy");
            txtCuenta.Focus();         
        }


        private void LimpiarControles()
        {
            txtFecha.Text = "";
            txtDescripción.Text = "";
            txtDebe.Text = "";
            txtHaber.Text = "";
            //inhabilita los paneles
            paCarga.Enabled = true;
            paCuerpo.Enabled = false;            
        }
        private void LimpiaBlancosEncab()
        {
            txtDescripción.Text = txtDescripción.Text.Trim();
            txtDebe.Text = txtDebe.Text.Trim();
            txtHaber.Text = txtHaber.Text.Trim();
        }

        //Validaciones de Contenidos
        private void controlDatosL(object box, string validar)
        {

            if (validar.Trim() != string.Empty)
            {
                errorProvider1.SetError((Control)box, "");
                BtnSiguiente.Enabled = true;              
            }

            else
            {
                errorProvider1.SetError((Control)box, "Completar Campo");
                BtnSiguiente.Enabled = false;
            }
        }

        private void controlDatos(object box, string validar)
        {

            if (validar.Trim() != string.Empty)
            {
                errorProvider1.SetError((Control)box, "");
                if (txtFecha.Text.Trim() != string.Empty && txtDescripción.Text.Trim() != string.Empty && txtDebe.Text.Trim() != string.Empty && txtHaber.Text.Trim() != string.Empty)
                {
                    BtnCargar.Enabled = true;
                }                               
            }

            else
            {
                errorProvider1.SetError((Control)box, "Completar Campo");
                BtnCargar.Enabled = false;
            }
            
        }

        //Carga los validados
        private void CargaMayor()
        {
            try
            {
                objFila.Cuenta = txtCuenta.Text;
                objFila.Fecha = System.Convert.ToDateTime(txtFecha.Text);
                objFila.Descripción = txtDescripción.Text;
                objFila.Debe = System.Convert.ToDecimal(txtDebe.Text);
                objFila.Haber = System.Convert.ToDecimal(txtHaber.Text);
                objLibro.CargarTabla(objFila);
            }
            catch (Exception ee)
            {                
                MessageBox.Show("Error:\r\n" + ee.Message);
            }
        }

        #endregion

        #region Eventos
        private void FrmMayor_Load(object sender, EventArgs e)
        {
            txtCuenta.Enabled = false;   
            BtnSiguiente.Enabled = false;            
        }

        //Eventos de Botones
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            txtCuenta.Enabled = true;
            txtCuenta.Text = "";
            LimpiarControles();
            NuevaMayorización();
            paCarga.Enabled = false;
        }
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            txtCuenta.Text = txtCuenta.Text.Trim();
            txtCuenta.Enabled = false;
            BtnSiguiente.Enabled = false;
            paCarga.Enabled = true;
            
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            
            LimpiaBlancosEncab();
            paCuerpo.Enabled = true;
            paPie.Enabled = true;
            txtCalcular.Text = "";
            CargaMayor();            
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            objLibro.CalculaSaldo();
            txtCalcular.Text = objLibro.saldoMayor.ToString("#,##0.00");
        }
        //todo: configurar botones importar y exportar
        private void BtnImportar_Click(object sender, EventArgs e)
        {
           // tabla.ReadXml(@"C:\Users\Sergio-Algorry\Desktop\lista.xml");
         
        }
        private void BtnExportar_Click(object sender, EventArgs e)
        {
            //tabla.WriteXml(@"C:\Users\Sergio-Algorry\Desktop\lista.xml");
        }

        //Validaciones de contenido en TextBox

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {
            object box = txtCuenta;
            string validar = txtCuenta.Text;
            controlDatosL(box, validar);
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            object box = txtFecha;
            string validar = txtFecha.Text;
            controlDatos(box, validar);
        }

        private void txtDescripción_TextChanged(object sender, EventArgs e)
        {
            object box = txtDescripción;
            string validar = txtDescripción.Text;
            controlDatos(box, validar);
        }

        private void txtDebe_TextChanged(object sender, EventArgs e)
        {
            object box = txtDebe;
            string validar = txtDebe.Text;
            controlDatos(box, validar);
        }

        private void txtHaber_TextChanged(object sender, EventArgs e)
        {
            object box = txtHaber;
            string validar = txtHaber.Text;
            controlDatos(box, validar);
        }

        #endregion  
    }
}
