using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;
using System.Windows.Forms;



namespace CapaNegocio
{
    public class CNLogin
    {

        public DataTable N_user(CEEmpleado obje)
        {
            DataTable dt = new DataTable();
            CDLogin objd = new CDLogin();





            return objd.D_user(obje);


        }
        //para validar la existencia del correo electrónico en la BD
        public DataTable N_user_mail(CEEmpleado em)
        {
            DataTable dt = new DataTable();
            CDLogin cDL = new CDLogin();

            return cDL.D_mail(em);
        }


        public DataTable N_pass(CEEmpleado em)
        {
            DataTable dtp = new DataTable();
            CDLogin cDL = new CDLogin();

           return cDL.D_pass(em);
           
        }

    }
}
