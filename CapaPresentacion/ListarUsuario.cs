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
    public partial class ListarUsuario : Form
    {
        CNUsuario cNUsuario = new CNUsuario();
        public ListarUsuario()
        {
            InitializeComponent();

            CNUsuario lista = new CNUsuario();
            dgvUSER.DataSource = lista.ObtenerDatos();
            dgvUSER.Columns["IDTIPOUSUARIO"].Visible = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           /* try
            {
                CNUsuario lista = new CNUsuario();
                dataGridViewEmpleados.DataSource = lista.ObtenerDatos();


            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            } */
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            cNUsuario.PruebaOracle();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MantenedorUsuario mantenedorUsuario = new MantenedorUsuario();
            mantenedorUsuario.Show();
            this.Close();
        }
    }
}
