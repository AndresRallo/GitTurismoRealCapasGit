using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEAdjuntos
    {
        //depto
        public int IDDEPARTAMENTO { get; set; }
        public string nombreDepto  { get; set; }

        //adjunto
        public int IDADJUNTOHABITACION { get; set; }
        public string AD_NOMBRE { get; set; }
        public DateTime AD_FECHACREACION { get; set; }
        public string AD_TIPOARCHIVO { get; set; }

        //sys_estado
        public int IDESTADO { get; set; }
        public string estado { get; set; }

        public CEAdjuntos()
        {

        }
    }
}
