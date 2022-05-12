using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEMantencion
    {
        public int IdMantencion { get; set; }
        public string Ma_Observaciones { get; set; }
        public DateTime Ma_FechaInicio { get; set; }
        public DateTime Ma_FechaTermino { get; set; }
        public int IdDepartamento { get; set; }
        public int IdTipoMantencion { get; set; }
        
        public CEMantencion()
        {

        }
    }
}
