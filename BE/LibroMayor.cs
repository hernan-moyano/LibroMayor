using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class LibroMayor
    {
        #region propiedades        
        public decimal saldoMayor= 0;        
        public DataTable tabla = new DataTable();
        #endregion

        #region Constructores
        public LibroMayor()
        {
           tabla.TableName = "Lista";
           tabla.Columns.Add("Cuenta", typeof(string));
           tabla.Columns.Add("Fecha", typeof(DateTime));
           tabla.Columns.Add("Descripción", typeof(string));
           tabla.Columns.Add("Debe", typeof(decimal));
           tabla.Columns.Add("Haber", typeof(decimal));
           tabla.Columns.Add("Saldo", typeof(decimal));

        }
        #endregion

        #region Metodos
        public void CargarTabla(Asiento objFila)
        {           
            tabla.Rows.Add();
            tabla.Rows[tabla.Rows.Count - 1][0] = objFila.Cuenta;
            tabla.Rows[tabla.Rows.Count - 1][1] = objFila.Fecha;
            tabla.Rows[tabla.Rows.Count - 1][2] = objFila.Descripción;
            tabla.Rows[tabla.Rows.Count - 1][3] = objFila.Debe;
            tabla.Rows[tabla.Rows.Count - 1][4] = objFila.Haber;
            CalculaSaldo();
            tabla.Rows[tabla.Rows.Count - 1][5] = saldoMayor;
        }

        public void CalculaSaldo()         
        {
            decimal deacum = 0;
            decimal habacum = 0;

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                deacum = deacum + System.Convert.ToDecimal(tabla.Rows[i][3]) ;
                habacum = habacum + System.Convert.ToDecimal(tabla.Rows[i][4]);                
            }
            saldoMayor = deacum - habacum;
            GrabarTabla();
        }

        public void LeerTabla()
        {
            tabla.ReadXml(@"lista.xml");
        }

        public void GrabarTabla()
        {
            tabla.WriteXml(@"lista.xml");
        }

        #endregion


    }
}
