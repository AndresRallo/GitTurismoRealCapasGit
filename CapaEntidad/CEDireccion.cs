using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEDireccion
    {
        public int idDireccion { get; set; }
        public string de_direccion { get; set; }
        public string de_numero { get; set; }
        public int id_comuna { get; set; }
        public CEDireccion() { }
    }
}
