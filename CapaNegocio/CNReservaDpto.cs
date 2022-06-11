using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNReservaDpto
    {
        CDReservaDpto cDReserva = new CDReservaDpto();

        #region CreateReserva
        public bool CreateReserva(CEReservaDpto reserva)
        {
            return cDReserva.AddReserva(reserva);
        }
        #endregion

        #region DeleteReserva
        public bool DeleteReserva(CEReservaDpto reserva)
        {
            return cDReserva.DeleteReserva(reserva);
        }

        #endregion

        #region UpdateReserva
        public bool UpdateReserva(CEReservaDpto reserva)
        {
            return cDReserva.UpdateReserva(reserva);
        }
        #endregion

        #region ListReserva
        public List<CEReservaDpto> ListALLReserva()
        {
            return cDReserva.ListALLReserva();
        }
        #endregion
    }
}
