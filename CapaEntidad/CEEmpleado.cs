using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEEmpleado
    {
        public int idempleado { get; set; }
        public string em_rut { get; set; }
        public string em_dv { get; set; }
        public string em_nombre { get; set; }
        public string em_apaterno { get; set; }
        public string emp_amaterno { get; set; }
        public string em_mail { get; set; }
        public string em_contrasena { get; set; }
        public int idEmpresa { get; set; }
        public int idTipoEmleado { get; set; }
        public int idEstado { get; set; }
        public int idDireccion { get; set; }

        public CEEmpleado()
        {

        }

    }

    
}
