using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EFTEC;

namespace CapaNegocio.Library
{
    public class Rut
    {
        public bool RutValidar(string rut1, string digito)
        {
            string r = RutChile.LimpiaRut(rut1 + "-" + digito);
            bool valido = RutChile.ValidarRut(r);
            return valido;
        }
    }
}
// www.nuget.org/packages/RutChile/
