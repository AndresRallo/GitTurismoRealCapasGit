﻿using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class CreateServiceBooking : Form
    {
        public CreateServiceBooking()
        {
            InitializeComponent();
        }

        private void MantenedorServicioReserva_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog2_Apply(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
        #region List  employee 
        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarEmpleados listarEmpleados = new ListarEmpleados();
            listarEmpleados.Show();
            this.Close();
        }
        #endregion

        #region Add new employee 
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            agregarEmpleado.Show();
            this.Close();
        }
        #endregion

        #region Edit  employee 
        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditarEmpleado editarEmpleado = new EditarEmpleado();
            editarEmpleado.Show();
            this.Close();
        }
        #endregion

        #region Delete  employee 
        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CambiarEstadoEmpleado eliminarEmpleado = new CambiarEstadoEmpleado();
            eliminarEmpleado.Show();
            this.Close();
        }
        #endregion

        #region list User
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ListarUsuario listarUsuario = new ListarUsuario();
            listarUsuario.Show();
            this.Close();

        }
        #endregion

        #region create User
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.Show();
            this.Close();

        }
        #endregion

        #region edit User
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            EditarUsuario editarUsuario = new EditarUsuario();
            editarUsuario.Show();
            this.Close();

        }
        #endregion

        #region delete User
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            CambiarEstadoUsuario eliminarUsuario = new CambiarEstadoUsuario();
            eliminarUsuario.Show();
            this.Close();

        }
        #endregion

        ///
        #region list department
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region add department
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region edit department
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region delete department
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region create Service booking
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            CreateServiceBooking mantenedor = new CreateServiceBooking();
            mantenedor.Show();
            this.Close();
        }
        #endregion

        #region list Service booking
        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region edit Service booking
        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region delete Service booking
        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region add service
        private void button1_Click(object sender, EventArgs e)
        {
            CEService service = new CEService();
            service.NameService = (txtNombreServicio.Text != "") ? txtNombreServicio.Text : null;
            service.Precio = (txtPrecio.Text != "") ? int.Parse(txtPrecio.Text) : 0;
            service.Iva = (txtIVA.Text != "") ? int.Parse(txtIVA.Text) : 0;
            service.ValorTotal = (txtTotal.Text != "") ? int.Parse(txtTotal.Text) : 0;
            service.DireccionSucursal = (comboBoxSucursal.Text != "") ? comboBoxSucursal.Text : null;
            service.Estado = (txtEstado.Text != "") ? int.Parse(txtEstado.Text) : 0;
            service.TipoServicio = (comboBoxTipoServicio.Text != "") ? int.Parse(comboBoxTipoServicio.Text) : 0;
            service.Descripcion = (txtDescripcion.Text != "") ? txtDescripcion.Text : null;
            //falta agregar estos campos al front
            service.NumeroDireccion = 0;
            service.IdComuna = 0;
            //
            CNService cNService = new CNService();
            if (cNService.CreateService(service))

                MessageBox.Show("Servicio agregado");
            else
                MessageBox.Show("Servicio no agregado");

        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}