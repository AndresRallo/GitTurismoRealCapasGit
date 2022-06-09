using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEDeptoListaJoin
    {
        public int idDepto { get; set; }

        public int idDireccion { get; set; }
        public int idCaracteristicas { get; set; }

        public string de_nombre { get; set; }
        public string descripcionDepto { get; set; }
        public int precioDepto { get; set; }
        public int de_start { get; set; }
        public int idTipoDepto { get; set; }
        public int idEstadoDepto { get; set; }
        public string tipoDepto { get; set; }
        public string estadoDepto { get; set; }

        // direccion
        public string de_direccion { get; set; }
        public string de_numero { get; set; }

        public int idRegion { get; set; }
        public int id_comuna { get; set; }

        public string region { get; set; }
        public string comuna { get; set; }

        public int IdCaracteristica { get; set; }
        public string Ca_NumDepto { get; set; }
        public int Ca_CantHabitaciones { get; set; }
        public int Ca_CantCamas { get; set; }
        public int Ca_CantBaño { get; set; }
        public int Ca_CapPersonas { get; set; }
        public string Ca_CheckIn { get; set; }
        public string Ca_CheckOut { get; set; }
        public int IdDepartamento { get; set; }
        public int IdDirecion { get; set; }
    }
}
