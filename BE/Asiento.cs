using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Asiento
    {
        #region Propiedades
        public DateTime Fecha;               
        public string Descripción = "";
        public decimal Debe = 0;
        public decimal Haber = 0;
        public string Cuenta = "";
        #endregion

        #region Constructores
        public Asiento()
        {
            Fecha = DateTime.Now;
        }
        #endregion
    }
}
