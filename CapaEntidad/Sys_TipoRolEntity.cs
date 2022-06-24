using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Sys_TipoRolEntity
    {
        public const int ADMINISTRADOR = 1;
        public const int RECEPCIONISTA = 2;
        public const int CHOFER = 3;
        public const int GUIA = 4;

        public static string GetStrRolById(int id)
        {
            string salida = string.Empty;
            switch (id)
            {
                case ADMINISTRADOR: salida = "ADMINITRADOR"; break;
                case RECEPCIONISTA: salida = "RECEPCIONISTA"; break;
                case CHOFER: salida = "CHÓFER"; break;
                case GUIA: salida = "GUÍA TURÍSTICO"; break;
            }

            return salida;
        }

    }
}
