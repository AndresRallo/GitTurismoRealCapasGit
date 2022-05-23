using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEComentarios
    {
        public int IDCOMENTARIO { get; set; }
        public DateTime COM_FECHA { get; set; }
        public string COM_NOMBREUSUARIO { get; set; }
        public string COM_DESCRIPCION { get; set; }
        public int IDCOMENTARIODEPTO { get; set; }
        public int IDTIPOCOMENTARIO { get; set; }
        public int IDESTADO { get; set; }
        public CEComentarios()
        {

        }
    }
}
