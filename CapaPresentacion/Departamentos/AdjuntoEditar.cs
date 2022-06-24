using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaNegocio.Library;

namespace CapaPresentacion.Departamentos
{
    public partial class AdjuntoEditar : Form
    {
        Librarys librarys = new Librarys();
        CNDepartamento cNDepartamento = new CNDepartamento();
        
        public AdjuntoEditar()
        {
            InitializeComponent();
            ListarDepartamentos();
        }


        

        public void ListarDepartamentos()
        {
            CNDepartamento listaDepto = new CNDepartamento();
            dgvDeptos.DataSource = listaDepto.ObtenerDatosJoinCaracteristicas();
        }



        private void btnArtas_Click(object sender, EventArgs e)
        {
            Departamentos.MantDepartamentos mantenedorDepartamento = new MantDepartamentos();
            mantenedorDepartamento.Show();
            this.Close();
        }

        private void dgvDeptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDeptos.Rows.Count != 0)
            {
                GetDepartamento();
            }
        }

        private void dgvDeptos_KeyUp(object sender, KeyEventArgs e)
        {
            GetDepartamento();
        }

        private void btnCargarAdjuntos_Click(object sender, EventArgs e)
        {
            ListarAdjuntoIdDepto(txtIdDepto.Text);
        }

        private void btnEliminarAdjunto_Click(object sender, EventArgs e)
        {
            try
            {
                CEAdjunto adjunto = new CEAdjunto();
                adjunto.IDADJUNTOHABITACION = Convert.ToInt32(txtIdAdjunto.Text);

                if (cNDepartamento.EliminarAdjunto(adjunto))
                {
                    MessageBox.Show("Adjunto Eliminado");
                    ListarAdjuntoIdDepto(txtIdDepto.Text);
                    txtIdAdjunto.Text = String.Empty;
                }
                else
                { 
                    MessageBox.Show("Adjunto no Eliminado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Adjunto no eliminado" + ex);
            }

        }

        
        public void ListarAdjuntoIdDepto(string idDepto)
        {
            CNDepartamento listarAdjPorIdDepto = new CNDepartamento();
            dgvAdjuntos.DataSource = listarAdjPorIdDepto.ListarAdjuntosPorIdDepto(idDepto);
        }

        public void GetAdjuntos()
        {
            txtIdAdjunto.Text = Convert.ToString(dgvAdjuntos.CurrentRow.Cells[2].Value);
        }
        public void GetDepartamento()
        {
            txtIdDepto.Text = Convert.ToString(dgvDeptos.CurrentRow.Cells["id_Depto"].Value);
            txtNombreDepto.Text = Convert.ToString(dgvDeptos.CurrentRow.Cells["denombreDepto"].Value);
            txtIdAdjunto.Text = String.Empty;
            ListarAdjuntoIdDepto(txtIdDepto.Text);

        }

        private void dgvAdjuntos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDeptos.Rows.Count != 0)
            {
                GetAdjuntos();
            }
        }
        private void dgvAdjuntos_KeyUp(object sender, KeyEventArgs e)
        {
            GetAdjuntos();
        }
    }
}
