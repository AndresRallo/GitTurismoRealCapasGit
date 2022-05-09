using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoRealExceptions
{
    public class TechnicalException : ApplicationException
    {
        public TechnicalException(string mensaje, Exception original)
            : base(mensaje, original)
        {
            CreateLogFiles Err = new CreateLogFiles();
            Err.ErrorLog("ErrorLog", mensaje + " : " + original);
        }

        public TechnicalException(string mensaje)
            : base(mensaje)
        {
            CreateLogFiles Err = new CreateLogFiles();
            Err.ErrorLog("ErrorLog", mensaje);
        }
    }
}
