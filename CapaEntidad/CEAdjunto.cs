using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEAdjunto
    {
        public int IDADJUNTOHABITACION { get; set; }
        public string AD_NOMBRE { get; set; }
        public DateTime AD_FECHACREACION { get; set; }
        public string AD_TIPOARCHIVO { get; set; }
        public int IDDEPARTAMENTO { get; set; }
        public int IDESTADO { get; set; }

        public CEAdjunto()
        {

        }
        
    }
}
