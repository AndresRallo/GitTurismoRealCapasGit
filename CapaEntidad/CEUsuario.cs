using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEUsuario
    {
        public int idUsuario { get; set; }
        public string us_rut { get; set; }
        public string us_dv { get; set; }
        public string us_nombre { get; set; }
        public string us_apaterno { get; set; }
        public string us_amaterno { get; set; }
        public string us_telefono { get; set; }
        public string us_email { get; set; }
        public string us_contraseña { get; set; }
        public int idEstado { get; set; }
        public CEUsuario() { }
    }
}
