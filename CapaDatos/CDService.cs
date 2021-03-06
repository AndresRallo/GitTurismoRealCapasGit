using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealExceptions;

namespace CapaDatos
{
    public class CDService
    {
        string conexion = ConfigurationManager.AppSettings["conn"];

        #region Add service
        public bool AddService(CEService service)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_SET_ADD_SERVICIOS", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("NOM", OracleType.NVarChar).Value = service.NameService;
                    command.Parameters.Add("DESCRIPCIONS", OracleType.NVarChar).Value = service.Descripcion;
                    command.Parameters.Add("PRECIOS", OracleType.Number).Value = service.Precio;
                    command.Parameters.Add("IVAS", OracleType.Number).Value = service.Iva;
                    command.Parameters.Add("DIRECCION", OracleType.NVarChar).Value = service.DireccionSucursal;
                    command.Parameters.Add("NUMDIREC", OracleType.NVarChar).Value = service.NumeroDireccion.ToString();
                    command.Parameters.Add("IDCOMUNADIREC", OracleType.Number).Value = service.IdComuna;
                    command.Parameters.Add("IDESTADOS", OracleType.Number).Value = service.Estado;
                    command.Parameters.Add("IDTIPO", OracleType.Number).Value = service.TipoServicio;
                    OracleParameter par = new OracleParameter("V_DETALLE", OracleType.NVarChar);
                    par.Direction = ParameterDirection.Output;
                    par.Size = 250;
                    command.Parameters.Add(par);
                    command.ExecuteNonQuery();
                    salida = command.Parameters["V_DETALLE"].Value.ToString();
                    conn.Close();
                }
                //response varification
                if (string.IsNullOrEmpty(salida))
                    return true;
                else
                    return false;
            }
            catch (OracleException E)
            {
                return false;
            }
            catch (Exception E)
            {
                return false;
            }
        }
        #endregion

        #region DeleteService
        public bool DeleteService(CEService cE)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    DialogResult result;
                    result = MessageBox.Show("¿Esta seguro de eliminar el servicio?", "Eliminar Servicio", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        //-->cambiar name de sp y parametros 
                        OracleCommand command = new OracleCommand("SP_SET_STATUS_CHANGE_SERVICE", conn);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add("IDSERVICIO", OracleType.Number).Value = cE.IdService;
                        command.Parameters.Add("IDESTADO", OracleType.Number).Value = ((int)Estados.Inactivo);

                        OracleParameter par = new OracleParameter("V_DETALLE", OracleType.VarChar);
                        par.Direction = ParameterDirection.Output;
                        par.Size = 250;
                        command.Parameters.Add(par);
                        command.ExecuteNonQuery();
                        salida = command.Parameters["V_DETALLE"].Value.ToString();
                        conn.Close();
                    }
                }
                if (string.IsNullOrEmpty(salida))
                    return true;
                else
                    return false;
            }
            catch (OracleException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region UpdateService
        public bool UpdateService(CEService service)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    conn.Open();
                    //--->cambiar name de sp y verificar los nombres de las variables
                    OracleCommand command = new OracleCommand("SP_UPDATE_SERVICIO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("IDSER", OracleType.Int32).Value = service.IdService;
                    command.Parameters.Add("NOM", OracleType.VarChar).Value = service.NameService;
                    command.Parameters.Add("DESCRIPCION", OracleType.VarChar).Value = service.Descripcion;
                    command.Parameters.Add("PRECIOS", OracleType.Int32).Value = service.Precio;
                    command.Parameters.Add("IVAS", OracleType.Int32).Value = service.Iva;
                    command.Parameters.Add("IDDIREC", OracleType.Int32).Value = service.DireccionSucursal;
                    //Posible error aqui?
                    command.Parameters.Add("DIRECCION", OracleType.VarChar).Value = service.DireccionSucursal;
                    command.Parameters.Add("NUMDIREC", OracleType.VarChar).Value = service.NumeroDireccion;
                    command.Parameters.Add("IDCOMUNADIREC", OracleType.Int32).Value = service.IdComuna;
                    command.Parameters.Add("IDESTADOS", OracleType.Int32).Value = service.Estado;
                    command.Parameters.Add("IDTIPO", OracleType.Int32).Value = service.TipoServicio;
                    OracleParameter par = new OracleParameter("V_DETALLE", OracleType.VarChar);
                    par.Direction = ParameterDirection.Output;
                    par.Size = 250;
                    command.Parameters.Add(par);
                    command.ExecuteNonQuery();
                    salida = command.Parameters["V_DETALLE"].Value.ToString();
                    conn.Close();
                }
                //response varification
                if (string.IsNullOrEmpty(salida))
                    return true;
                else
                    return false;
            }
            catch (OracleException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region ListService
        public List<CEService> ListALLService()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CEService> Services = new List<CEService>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_ALL_SERVICIOS", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        Services.Add(new CEService
                        {
                            IdService = Convert.ToInt32(mostrarTabla["IDSERVICIO"]),
                            NameService = mostrarTabla["SE_NOMBRE"].ToString(),
                            Precio = Convert.ToInt32(mostrarTabla["SE_PRECIO"]),
                            Iva = Convert.ToInt32(mostrarTabla["SE_IVA"]),
                            ValorTotal = Convert.ToInt32(mostrarTabla["SE_PRECIO"]) + Convert.ToInt32(mostrarTabla["SE_IVA"]),
                            //DireccionSucursal = mostrarTabla["DIRECCION_NAME"].ToString(),
                           // NumeroDireccion = Convert.ToInt32(mostrarTabla["IDREGION"]),
                            //IdComuna = Convert.ToInt32(mostrarTabla["IDREGION"]),
                            //Estado = Convert.ToInt32(mostrarTabla["IDESTADO"]),
                            //TipoServicio = Convert.ToInt32(mostrarTabla["IDTIPOS"]),
                            //Descripcion = mostrarTabla["SE_DESCRIPCION"].ToString(),
                        });
                    }
                    conn.Close();
                }
                return Services;

            }
            catch (OracleException ex)
            {
                throw new TechnicalException("LISTA NO ENCONTRADA, CONTACTAR CON AREA DE SOPORTE");
            }
        }
        #endregion

        #region ListService
        public List<CETipoServicio> ListALLSys_TIPOSERVICIO()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CETipoServicio> Services = new List<CETipoServicio>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_ALL_SYS_TIPOSERVICIO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        Services.Add(new CETipoServicio
                        {
                            idtiposervicio = Convert.ToInt32(mostrarTabla["idtiposervicio"]),
                            ts_descripcion = mostrarTabla["ts_descripcion"].ToString(),
                        });
                    }
                    conn.Close();
                }
                return Services;

            }
            catch (OracleException ex)
            {
                throw new TechnicalException("LISTA NO ENCONTRADA, CONTACTAR CON AREA DE SOPORTE");
            }
        }
        #endregion
    }
}
