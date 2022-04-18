using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CDLogin
    {
        OracleConnection cn = new OracleConnection("DATA SOURCE=localhost:1521/XEPDB1 ; PASSWORD=123456; USER ID=TURISMOADMIN;");


        public DataTable D_user(CEEmpleado obje)
        {

            OracleCommand cmd = new OracleCommand("SELECT * FROM EMPLEADO WHERE EM_RUT = :rut AND EM_CONTRASEÑA = :contra", cn);

            //cmd.Parameters.AddWithValue(":rut", txtUser.Text);
            //cmd.Parameters.AddWithValue(":contra", txtPass.Password);

            //cmd.CommandType = CommandType.StoredProcedure; // para proceso almacenado
            cmd.Parameters.Add(":rut", OracleType.NVarChar).Value = obje.em_rut;
            cmd.Parameters.Add(":contra", OracleType.Number).Value = Convert.ToInt32(obje.em_contrasena);
            //cmd.Parameters.AddWithValue("EM_NOM", obje.nombre);
            //cmd.Parameters.AddWithValue("EM_EM_APATERNO", obje.nombre);
            //cmd.Parameters.AddWithValue("ID_TIPOEMPLEADO", obje.em_cargo);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //OracleDataReader lector = cmd.ExecuteReader(); 
            return dt;
        }
    }
}
