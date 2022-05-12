using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CECaracteristicas_Departamento
    {
        public int IdCaracteristica { get; set; }
        public int Ca_CantHabitaciones { get; set; }
        public int Ca_CantCamas { get; set; }
        public int Ca_CantBaño { get; set; }
        public int Ca_CapPersonas { get; set; }
        public string Ca_CheckIn { get; set; }
        public string Ca_CheckOut { get; set; }
        public int IdDepartamento { get; set; }
        public int IdDirecion { get; set; }
        

        public CECaracteristicas_Departamento()
        {

        }
    }
}
