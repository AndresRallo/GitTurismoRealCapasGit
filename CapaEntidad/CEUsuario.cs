using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEUsuario
    {
        public int IDUSUARIO { get; set; }
        public string US_RUT { get; set; }
        public string US_DV { get; set; }
        public string US_NOMBRE { get; set; }
        public string US_APATERNO { get; set; }
        public string US_AMATERNO { get; set; }
        public string US_TELEFONO { get; set; }
        public string US_EMAIL { get; set; }
        public string US_CONTRASEÑA { get; set; }
        public int IDESTADO { get; set; }
        public SYS_TIPOUSUARIO IDTIPOUSUARIO { get; set; }
        public CEUsuario() { }
    }
}
