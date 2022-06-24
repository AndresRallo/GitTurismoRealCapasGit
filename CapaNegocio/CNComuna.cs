using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNComuna
    {
        CDComuna cDComuna = new CDComuna();


        #region ListService
        public List<CEComuna> ListALLcomuna()
        {
            return cDComuna.ListALLComuna();
        }
        #endregion
    }
}
