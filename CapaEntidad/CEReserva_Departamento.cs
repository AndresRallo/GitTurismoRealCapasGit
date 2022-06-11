using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEReserva_Departamento
    {
        public int IDRESERVA { get; set; }
        public DateTime RD_FECHAENTRADA { get; set; }
        public DateTime RD_FECHASALIDA { get; set; }
        public int RD_ABONO { get; set; }
        public int RD_PAGOTOTAL { get; set; }
        public int RD_CANTADULTOS { get; set; }
        public int RD_CANTNINIOS { get; set; }
        public int IDUSUARIO { get; set; }
        public int IDDEPARTAMENTO { get; set; }
        public int IDESTADORESERVA { get; set; }
        public int IDEMPLEADO { get; set; }
        public int IDTEMPORADA { get; set; }

        public CEReserva_Departamento()
        {

        }
    }
}
