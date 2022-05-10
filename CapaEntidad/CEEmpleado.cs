using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEEmpleado
    {
        public int IDEMPLEADO { get; set; }
        public string EM_RUT { get; set; }
        public string EM_DV { get; set; }
        public string EM_NOMBRE { get; set; }
        public string EM_APATERNO { get; set; }
        public string EM_AMATERNO { get; set; }
        public string EM_EMAIL { get; set; }
        public string EM_CONTRASEÑA { get; set; }
        public int IDEMPRESA { get; set; }
        public int IDTIPOEMPLEADO { get; set; }
        public int IDESTADO { get; set; }
        public int IDDIRECCION { get; set; }
        public CEDireccion direccion { get; set; }
        public CEVehiculo vehiculo { get; set; }
        public CERegion region { get; set; }
        public CEComuna comuna { get; set; }
        public CE_TIPOEMPLEADO tipoempleado { get; set; }
        public CE_ESTADO estado { get; set; }
        public CEEmpleado() { }

    }

    
}
