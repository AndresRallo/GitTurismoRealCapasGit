using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class CEReserva
    {
        public DateTime FECHAS { get; set; }
        public int IDRESERVA { get; set; }
        public int IDSERVICIO { get; set; }
        public string Hora { get; set; }
        public int idempleado { get; set; }
}
}
