using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class CEReserva
    {
        public DateTime RS_FECHAINGRESO { get; set; }
        public int IDRESERVA { get; set; }
        public int IDSERVICIO { get; set; }
        public int IDEMPLEADO { get; set; }
        public string RS_HORA { get; set; }
        public int IDESTADORESERVASERVICIO { get; set; }

    }
}
