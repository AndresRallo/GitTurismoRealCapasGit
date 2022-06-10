using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEReservaDpto
    {
        public int IDRESERVA { get; set; }
        public DateTime FECHAEN { get; set; }
        public DateTime FECHASA { get; set; }
        public int ABONO { get; set; }
        public int TOTAL { get; set; }
        public int CANTADULTOS { get; set; }
        public int CANTNINIOS { get; set; }
        public int IDUSUARIO { get; set; }
        public int IDDEPTO { get; set; }
        public int ESTADORESERVA { get; set; }
        public int IDEMPLEADO { get; set; }
        public int IDTEMPORADA { get; set; }

    }
}
