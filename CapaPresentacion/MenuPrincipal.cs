using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Reserva;
using CapaPresentacion.Reserva_Servicio;
using CapaPresentacion.Servicios;
using CryptSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealExceptions;

namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(string name)
        {
           
            InitializeComponent();
            NameUser(name);
        }

        private void NameUser(string name)
        {
            lblNameUser.Text = (name != "") ? name : "Invitado";
            lblNameUser.ForeColor = Color.Black;
            CEEmpleado user = CNEmpleado.getUserByEmail(name);
            txtNombre.Text = user.EM_NOMBRE;
            txtApellido.Text = user.EM_APATERNO + " " + user.EM_APATERNO;
            txtCorreo.Text = name;
            txtRut.Text = user.EM_RUT + "-" + user.EM_DV;
            txtRol.Text = Sys_TipoRolEntity.GetStrRolById(user.IDTIPOEMPLEADO);
        }
        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MantenedorUsuario mantenedorUsuario = new MantenedorUsuario();
            mantenedorUsuario.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantenedorEmpleados mantenedorEmpleados = new MantenedorEmpleados();
            mantenedorEmpleados.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Departamentos.MantDepartamentos mantDepartamentos = new Departamentos.MantDepartamentos();
            mantDepartamentos.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenedorReservas mantenedorReservas = new MantenedorReservas();
            mantenedorReservas.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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
        private void agregarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            agregarEmpleado.Show();
            this.Close();
        }
        #endregion

        #region Edit  employee 
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarEmpleado editarEmpleado = new EditarEmpleado();
            editarEmpleado.Show();
            this.Close();
        }
        #endregion

        #region ChangeStatus  employee 
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
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

        #region ChangeStatus User
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
            CambiarEstadoUsuario eliminarUsuario = new CambiarEstadoUsuario();
            eliminarUsuario.Show();
            this.Close();
            
        }
        #endregion

        #region list department
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Departamentos.ListarDepartamentos LISTA_DEPARTAMENTOS = new Departamentos.ListarDepartamentos();
            LISTA_DEPARTAMENTOS.Show();
            this.Close();
        }
        #endregion

        #region add department
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Departamentos.AgregarDepartamento AGREGAR_DEPARTAMENTO = new Departamentos.AgregarDepartamento();
            AGREGAR_DEPARTAMENTO.Show();
            this.Close();
        }
        #endregion

        #region edit department
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Departamentos.EditarDepartamento EDITAR_DEPARTAMENTO = new Departamentos.EditarDepartamento();
            EDITAR_DEPARTAMENTO.Show();
            this.Close();
        }
        #endregion

        #region delete department
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Departamentos.CambiarEstadoDepartamento CHANGE_STATUS_DEPARTAMENTO = new Departamentos.CambiarEstadoDepartamento();
            CHANGE_STATUS_DEPARTAMENTO.Show();
            this.Close();
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
            ListService listService = new ListService();
            listService.Show();
            this.Close();
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
            DeleteService deleteService = new DeleteService();
            deleteService.Show();
            this.Close();
        }

        #endregion

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        #region list reserva
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            ListarReservaServ listarReservaServ = new ListarReservaServ();
            listarReservaServ.Show();
            this.Close();
        }
        #endregion
        #region add reserva
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            CrearReservaServ crearReservaServ = new CrearReservaServ();
            crearReservaServ.Show();
            this.Show();
        }
        #endregion
        private void contextMenuStrip5_Opening(object sender, CancelEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Reserva_Opening(object sender, CancelEventArgs e)
        {

        }
        #region edit reserva
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            UpdateReservaServ updateReservaServ = new UpdateReservaServ();
            updateReservaServ.Show();
            this.Close();
        }
        #endregion
        #region delete reserva
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            EliminarReservaServ eliminarReservaServ = new EliminarReservaServ();
            eliminarReservaServ.Show();
            this.Close();
        }
        #endregion

        #region list reservadepto
        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            VerReservadepto verReserva = new VerReservadepto();
            verReserva.Show();
            this.Close();
        }
        #endregion
        #region add reservadepto
        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            CrearReservadepto crearReserva = new CrearReservadepto();
            crearReserva.Show();
            this.Close();
        }
        #endregion
        #region edit reservadepto
        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            UpdateReservadepto updateReserva = new UpdateReservadepto();
            updateReserva.Show();
            this.Close();
        }
        #endregion
        #region delete reservadepto
        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            EliminarReservadepto eliminarReserva = new EliminarReservadepto();
            eliminarReserva.Show();
            this.Close();
        }
        #endregion

        private void btnCambioPass_Click(object sender, EventArgs e)
        {
            try
            {
                bool valid = true;
                if (String.IsNullOrEmpty(txtPassAntigua.Text))
                {
                    MessageBox.Show("El campo contraseña antigua no puede esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CEEmpleado user = CNEmpleado.getUserByEmail(txtCorreo.Text);
                if (!Crypter.CheckPassword(txtPassAntigua.Text, user.EM_CONTRASEÑA))
                {
                    MessageBox.Show("El campo contraseña antigua no coincide con la contraseña actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (String.IsNullOrEmpty(txtPassNueva.Text))
                {
                    MessageBox.Show("El campo contraseña antigua no puede esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrEmpty(txtPassNuevaConfirmar.Text))
                {
                    MessageBox.Show("El campo contraseña antigua no puede esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPassNuevaConfirmar.Text != txtPassNueva.Text)
                {
                    MessageBox.Show("El campo contraseña antigua no puede esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (valid)
                {
                    CNEmpleado.SetChangePasword(txtCorreo.Text, txtPassNueva.Text);
                    MessageBox.Show("La contraseña fue actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassNuevaConfirmar.Text = string.Empty;
                    txtPassNueva.Text = string.Empty;
                    txtPassAntigua.Text = string.Empty;
                }
            }
            catch (BusinessException bex)
            {
                MessageBox.Show(bex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
