using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using System.Configuration;

namespace CapaDatos
{
    public class CDLogin
    {
        OracleConnection cn = new OracleConnection(ConfigurationManager.AppSettings["conn"]);


        public DataTable D_user(CEEmpleado obje)
        {

            OracleCommand cmd = new OracleCommand("LOGIN_EMPLEADOS", cn);

            //cmd.Parameters.AddWithValue(":rut", txtUser.Text);
            //cmd.Parameters.AddWithValue(":contra", txtPass.Password);

            cmd.CommandType = CommandType.StoredProcedure; // para proceso almacenado
            cmd.Parameters.Add("va_mail", OracleType.NVarChar).Value = obje.EM_EMAIL;
            cmd.Parameters.Add("va_contra", OracleType.NVarChar).Value = obje.EM_CONTRASEÑA;
            //cmd.Parameters.Add(":contra", OracleType.Number).Value = Convert.ToInt32(obje.em_contrasena);
            //cmd.Parameters.AddWithValue("EM_NOM", obje.nombre);
            //cmd.Parameters.AddWithValue("EM_EM_APATERNO", obje.nombre);
            //cmd.Parameters.AddWithValue("ID_TIPOEMPLEADO", obje.em_cargo);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //OracleDataReader lector = cmd.ExecuteReader(); 
            return dt;
        }

        public DataTable D_mail(CEEmpleado em)
        {

            OracleCommand cmd = new OracleCommand("SELECT * FROM EMPLEADO WHERE EM_EMAIL = :mail", cn);

            cmd.Parameters.Add(":mail", OracleType.NVarChar).Value = em.EM_EMAIL;

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable D_pass(CEEmpleado obje)
        {

            OracleCommand cmd = new OracleCommand("SELECT * FROM EMPLEADO WHERE EM_EMAIL = :mail AND EM_CONTRASEÑA = :contra", cn);

            cmd.Parameters.Add(":mail", OracleType.NVarChar).Value = obje.EM_EMAIL;
            cmd.Parameters.Add(":contra", OracleType.NVarChar).Value = obje.EM_CONTRASEÑA;

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //OracleDataReader lector = cmd.ExecuteReader(); 
            return dt;
        }
    }
}
