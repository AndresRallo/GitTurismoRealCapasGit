using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ListarEmpleados : Form
    {
        CNEmpleado cNEmpleado = new CNEmpleado();
        
        

        public ListarEmpleados()
        {
            InitializeComponent();

            CNEmpleado lista = new CNEmpleado();
            dataGridViewEmpleados.DataSource = lista.ObtenerEmpleados();
            cleanDGVEmpleados();
            dgvVEHICULO.DataSource = lista.ObtenerVehiculos();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
        private void cleanDGVEmpleados()
        {
            //dataGridViewEmpleados.Columns["direccion"].Visible = false;
            //dataGridViewEmpleados.Columns["vehiculo"].Visible = false;
            //dataGridViewEmpleados.Columns["region"].Visible = false;
            //dataGridViewEmpleados.Columns["comuna"].Visible = false;
            //dataGridViewEmpleados.Columns["tipoempleado"].Visible = false;
            //dataGridViewEmpleados.Columns["estado"].Visible = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

          /*  try
            {
                CNEmpleado lista = new CNEmpleado();
                dataGridViewEmpleados.DataSource = lista.ObtenerEmpleados();
              //dataGridViewEmpleados.EditMode = DataGridViewEditMode.EditOnEnter;


            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }

            /*
              conn.Open();
              OracleCommand command = new OracleCommand("seleccionarEmpleados", conn);
              command.CommandType = System.Data.CommandType.StoredProcedure;
              command.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

              OracleDataAdapter adaptador = new OracleDataAdapter();
              adaptador.SelectCommand = command;
              DataTable tablaEmpleado = new DataTable();
              adaptador.Fill(tablaEmpleado);
              dataGridViewEmpleados.DataSource = tablaEmpleado;

              conn.Close();
              */

            /**Procedimiento almacenado
               Create or replace procedure seleccionarEmpleados (registros out SYS_REFCURSOR)
                    as
               Begin
                    open registros for select * from empleado;
               End;
            **/

            /*
            
            */
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            cNEmpleado.PruebaOracle();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MantenedorEmpleados mantenedorEmpleados = new MantenedorEmpleados();
            mantenedorEmpleados.Show();
            this.Close();
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
