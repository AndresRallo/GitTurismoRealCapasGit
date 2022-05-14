using CapaEntidad;
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
    public partial class CambiarEstadoUsuario : Form
    {
        CNUsuario cNUsuario = new CNUsuario();
        public CambiarEstadoUsuario()
        {
            InitializeComponent();

            LoadComboEstadoEmpleado();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MantenedorUsuario mantenedorUsuario = new MantenedorUsuario();
            mantenedorUsuario.Show();
            this.Close();
        }

        private void btnListarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                CNUsuario lista = new CNUsuario();
                dataGridViewEmpleados.DataSource = lista.ObtenerDatos();


            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            cNUsuario.PruebaOracle();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                CEUsuario usuario = new CEUsuario();
                usuario.IDUSUARIO = Convert.ToInt32(txtIDUsuario.Text);
                usuario.IDESTADO = Convert.ToInt32(cbESTADO.SelectedValue);

                if (cNUsuario.CAMBIAR_ESTADO_USUARIO(usuario))
                    MessageBox.Show("CAMBIO DE ESTADO EXITOSO");
                else
                    MessageBox.Show("CAMBIO DE ESTADO NO EXITOSO");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Empleado No Eliminado " + ex);
            }
        }

        private void LoadComboEstadoEmpleado()
        {
            try
            {
                cbESTADO.DataSource = cNUsuario.ObtenerEstado();
                cbESTADO.ValueMember = "IDESTADO";
                cbESTADO.DisplayMember = "ES_DESCRIPCION";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo estado empleado" + ex);
            }
        }
    }
}
