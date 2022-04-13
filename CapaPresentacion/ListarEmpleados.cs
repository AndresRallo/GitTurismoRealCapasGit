﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        OracleConnection conn = new OracleConnection("DATA SOURCE = localhost:1521 / XEPDB1 ; PASSWORD=123456; USER ID = TURISMOADMIN;");
        public ListarEmpleados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           
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

            /**Procedimiento almacenado
               Create or replace procedure seleccionarEmpleados (registros out SYS_REFCURSOR)
                    as
               Begin
                    open registros for select * from empleado;
               End;
            **/



        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Conectado");
            conn.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MantenedorEmpleados mantenedorEmpleados = new MantenedorEmpleados();
            mantenedorEmpleados.Show();
            this.Close();
        }
    }
}
