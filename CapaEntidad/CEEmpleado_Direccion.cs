using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEEmpleado_Direccion
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
        public int idDireccion { get; set; }
        public string de_direccion { get; set; }
        public string de_numero { get; set; }
        public int id_comuna { get; set; }
        public string c_descripcion { get; set; }
        public int IDREGION { get; set; }
        public string RE_DESCRIPCION { get; set; }
        public string TP_DESCRIPCION { get; set; }
        public string ES_DESCRIPCION { get; set; }
        public string VE_MARCA { get; set; }
        public string VE_ANIO { get; set; }
        public string VE_PATENTE { get; set; }

    }
}
