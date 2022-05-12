using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEAdjunto
    {
        public int IdAdjuntoHabitacion { get; set; }
        public string Ad_Nombre { get; set; }
        public DateTime Ad_FechaCreacion { get; set; }
        public string Ad_TipoArchivo { get; set; }
        public int IdDepartamento { get; set; }
        public int IdEstado { get; set; }

        public CEAdjunto()
        {

        }
    }
}
