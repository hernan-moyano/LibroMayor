using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class LibroMayor
    {
        #region propiedades
        
        public decimal saldoMayor = 0;

        
        public DataTable tabla = new DataTable();
        #endregion

        #region Constructores
        public LibroMayor()
        {
            //todo: revisar contructor
           tabla.TableName = "Lista";
           tabla.Columns.Add("Fecha", typeof(DateTime));
           tabla.Columns.Add("Descripción", typeof(string));
           tabla.Columns.Add("Debe", typeof(decimal));
           tabla.Columns.Add("Haber", typeof(decimal));

        }
        #endregion

        #region Metodos
        //todo: revisar carga de tabla
        public void CargarTabla(Asiento objFila)
        {           
            tabla.Rows.Add();
            tabla.Rows[tabla.Rows.Count - 1][0] = objFila.Fecha;
            tabla.Rows[tabla.Rows.Count - 1][1] = objFila.Descripción;
            tabla.Rows[tabla.Rows.Count - 1][2] = objFila.Debe;
            tabla.Rows[tabla.Rows.Count - 1][3] = objFila.Haber;
            //todo: grabar en xml
        }
        //todo: agregar metodo leer xml


        // public CalculaSaldo()
        // {
        //     foreach (decimal saldo in tabla)
        //     {
        //
        //     }
        //     return;
        // }
        #endregion


    }
}
