using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEService
    {
        public int? IdService { get; set; }
        public string NameService { get; set; }
        public int Precio { get; set; }
        public int Iva { get; set; }
        public int ValorTotal { get; set; }
        public string DireccionSucursal { get; set; }
        public int NumeroDireccion { get; set; }
        public int IdComuna { get; set; }
        public int Estado { get; set; }
        public int TipoServicio { get; set; }

        public string Descripcion { get; set; }

    }
}
