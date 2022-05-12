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
    public class CDDepartamento
    {
        string conexion = ConfigurationManager.AppSettings["conn"];
        

        public void PruebaConexion()
        {
            OracleConnection conn = new OracleConnection(conexion);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No conecta a la BD" + ex.Message);
                return;
            }
            conn.Close();
            MessageBox.Show("Conectado :)");
        }

        public void EliminarDepartamento(CEDepartamento departamento)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    DialogResult result;
                    result = MessageBox.Show("¿Está seguro elimianr Depto?", "Eliminar Departamento", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        OracleCommand command = new OracleCommand("DP_eliminarDepartamento", conn);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add("ID_DEPARTAMENTO", OracleType.Number).Value = Convert.ToInt32(departamento.idDepto);
                        command.ExecuteNonQuery();
                        
                    }
                    conn.Close();
                }
                MessageBox.Show("Departamento eliminado :)");

            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }

        

        public List<CETipoDepartamento> TipoDepto()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CETipoDepartamento> ListaTipoDepto = new List<CETipoDepartamento>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_TIPO_DEPARTAMENTOS", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        ListaTipoDepto.Add(new CETipoDepartamento
                        {
                            IDTIPODEPARTAMENTO = Convert.ToInt32(mostrarTabla["IDTIPODEPARTAMENTO"]),
                            TD_DESCRIPCION = Convert.ToString(mostrarTabla["TD_DESCRIPCION"].ToString())

                        });
                    }
                    conn.Close();
                }
                return ListaTipoDepto;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }


        public List<CESysEstadoDepto> SysEstDepto()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CESysEstadoDepto> listarEstadoDepto = new List<CESysEstadoDepto>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_TIPO_ESTADO_DEPARTAMENTO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();

                    while (mostrarTabla.Read())
                    {
                        listarEstadoDepto.Add(new CESysEstadoDepto
                        {
                            IDEstDepto = Convert.ToInt32(mostrarTabla["IDESTADODEPARTAMENTO"]),
                            EdDescripcion = Convert.ToString(mostrarTabla["ED_DESCRIPCION"].ToString())
                        });
                    }
                    conn.Close();
                }
                return listarEstadoDepto;

            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }


        }

        public void CrearDepartamento(CEDepartamento depto)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("DP_agregarDepartamento", conn);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("VA_DE_DESCRIPCION", OracleType.NVarChar).Value = depto.descripcionDepto;
                    command.Parameters.Add("VA_DE_PRECIO", OracleType.Number).Value = depto.precioDepto;
                    command.Parameters.Add("VA_IDTIPODEPARTAMENTO", OracleType.Number).Value = depto.idTipoDepto;
                    command.Parameters.Add("VA_IDESTADODEPARTAMENTO", OracleType.Number).Value = depto.idEstadoDepto;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Departamento Agregado");
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("No se creó el departamento" + oex.Message);
            }
        }

        public DataTable Listar()
        {
            //OracleConnection conn = new OracleConnection(conexion);
            OracleDataReader mostrarTabla;
            DataTable tablaDepartamento = new DataTable();

            try
            {
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("DP_seleccionarDepartamentos", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    mostrarTabla.Read();
                    OracleDataAdapter adaptador = new OracleDataAdapter();
                    adaptador.SelectCommand = command;
                    adaptador.Fill(tablaDepartamento);
                    conn.Close();
                }
                return tablaDepartamento;

            }
            catch (OracleException oex)
            {

                throw new TechnicalException("No se pudo terminar la acción" + oex.Message);
            }




            #region procedimiento almacenado listar departamentos
            /* --------------
            create or replace procedure DP_seleccionarDepartamentos(registros out SYS_REFCURSOR)
            as
            Begin
                open registros for select* from DEPARTAMENTO;
            End;
            --------------*/
            #endregion
        }


    }
}
