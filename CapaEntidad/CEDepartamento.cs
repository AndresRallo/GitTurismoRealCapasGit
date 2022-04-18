using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEDepartamento
    {
        public int idDepto { get; set; }
        public string descripcionDepto { get; set; }
        public int precioDepto { get; set; }
        public int idTipoDepto { get; set; }
        public int idEstadoDepto { get; set; }
        public CEDepartamento() { }
    }
}
