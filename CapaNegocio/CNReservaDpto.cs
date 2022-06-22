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
        public List<CE_ESTADO> ObtenerEstado()
        {
            List<CE_ESTADO> LISTA_ESTADO = new List<CE_ESTADO>();
            LISTA_ESTADO = cDReserva.ESTADO();
            return LISTA_ESTADO;
        }


        #region CreateReserva
        public bool CreateReserva(CEReservaDpto reserva)
        {
            return cDReserva.AddReserva(reserva);
        }
        #endregion

        #region DeleteReserva
        public bool DeleteReserva(int reserva)
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
