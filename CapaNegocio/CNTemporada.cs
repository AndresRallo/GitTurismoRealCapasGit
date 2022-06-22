using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNTemporada
    {
        CDTemporada cDTemporada = new CDTemporada();
      
        #region ListTemporada
        public List<CETemporada> ListALLTemporada()
        {
            return cDTemporada.ListALLTemporada();
        }
        #endregion
    }
}
