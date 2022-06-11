using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNReserva
    {
        CDReserva cDReserva = new CDReserva();

        #region CreateReserva
        public bool CreateReserva(CEReserva reserva)
        {
            return cDReserva.AddReserva(reserva);
        }
        #endregion

        #region DeleteReserva
        public bool DeleteReserva(CEReserva reserva)
        {
            return cDReserva.DeleteReserva(reserva);
        }

        #endregion

        #region UpdateReserva
        public bool UpdateReserva(CEReserva reserva)
        {
            return cDReserva.UpdateReserva(reserva);
        }
        #endregion

        #region ListReserva
        public List<CEReserva> ListALLReserva()
        {
            return cDReserva.ListALLReserva();
        }
        #endregion
    }
}
