using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNDepartamento
    {
        CDDepartamento departamento = new CDDepartamento();

        public void PruebaOracle()
        {
            departamento.PruebaConexion();
        }
    }
}
