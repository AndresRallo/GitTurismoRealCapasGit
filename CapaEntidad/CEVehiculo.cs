using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEVehiculo
    {
        public int id_ve { get; set; }
        public int anio_ve { get; set; }
        public string marca_ve { get; set; }
        public string patente_ve { get; set; }
        public CEVehiculo() { }
    }
}
