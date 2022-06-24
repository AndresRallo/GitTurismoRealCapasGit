using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEComuna
    {
        public int idcomuna { get; set; }
        public string c_descripcion { get; set; }
        public CERegion IDRegion { get; set; }
    }
}
