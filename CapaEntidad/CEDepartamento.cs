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

        public int idDireccion { get; set; }
        public int idCaracteristicas  { get; set; }

        public string de_nombre { get; set; }
        public string descripcionDepto { get; set; }
        public int precioDepto { get; set; }
        public int de_start { get; set; }
        public int idTipoDepto { get; set; }
        public int idEstadoDepto { get; set; }

        //-------clases dependientes

        public CEMantencion mantencion { get; set; }
        public CEAdjunto adjunto { get; set; }
        public CEDireccion direccion { get; set; }
        public CECaracteristicas_Departamento carateristicasDepartamento { get; set; }



        //-----------------------
        public CEDepartamento() { }
    }
}
