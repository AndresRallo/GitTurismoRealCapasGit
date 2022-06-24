using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaNegocio.Library;

namespace CapaPresentacion.Departamentos
{
    public partial class Adjunto : Form
    {
        Librarys librarys = new Librarys();
        CNDepartamento cNDepartamento = new CNDepartamento();

        Image img;

        public Adjunto()
        {
            InitializeComponent();
            LoadComboEstado();
            ListarDepartamentos();
            ListarAdjuntos();
        }

        private void LoadComboEstado()
        {
            try
            {
                cbxEstado.DataSource = cNDepartamento.ObtenerEstado();
                cbxEstado.ValueMember = "IDESTADO";
                cbxEstado.DisplayMember = "ES_DESCRIPCION";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo estado depto" + ex);
            }
        }
        public void ListarDepartamentos()
        {
            CNDepartamento listaDepto = new CNDepartamento();
            dgvDeptos.DataSource = listaDepto.ObtenerDatosJoinCaracteristicas();
        }

        public void ListarAdjuntos()
        {
            CNDepartamento listarAdjuntos = new CNDepartamento();
            dgvAdjuntos.DataSource = listarAdjuntos.ListarAdjuntosJoin();
        }
        public void GetDepartamento()
        {
            txtIdDepto.Text = Convert.ToString(dgvDeptos.CurrentRow.Cells["id_Depto"].Value);
            txtNombreDepto.Text = Convert.ToString(dgvDeptos.CurrentRow.Cells["denombreDepto"].Value);
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


        private void dgvAdjuntos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvAdjuntos_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        

        private void Limpiar()
        {
            txtIdDepto.Text = String.Empty;
            txtNombreDepto.Text = String.Empty;
            txtRutaImagen.Text = String.Empty;
            pictureBoxImage.Image = CapaPresentacion.Properties.Resources.deptoDibujo1;
            txtNombreImg.Text = String.Empty;
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            CargarImagen();

        }

        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            CargarImagen();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtRutaImagen.Text == String.Empty)
            {
                lblRutaImg.Text = "Falta Img";
                lblRutaImg.ForeColor = Color.Red;
            }
            if (txtIdDepto.Text == String.Empty || txtNombreDepto.Text == String.Empty)
            {
                lblIdDepto.ForeColor = Color.Red;
                lblNombreDepto.ForeColor = Color.Red;
                lblNombreDepto.Text = "Elija Depto:";
            }

            GuardarAdjunto();
        }

        private void GuardarAdjunto()
        {
            try
            {
                CEAdjunto adjunto = new CEAdjunto();

                adjunto.IDDEPARTAMENTO = Convert.ToInt32(txtIdDepto.Text);
                adjunto.AD_NOMBRE = txtNombreImg.Text;
                adjunto.IDESTADO = Convert.ToInt32(cbxEstado.SelectedValue);
                adjunto.AD_FECHACREACION = dtpFechaImg.Value;
                CrearDirectorio(txtIdDepto.Text);



                img.Save(rutaFinal + "\\"+txtNombreImg.Text);
                

                if (cNDepartamento.CrearAdjunto(adjunto))
                {
                    Limpiar();
                    ListarAdjuntos();
                    MessageBox.Show("Adjunto Agregado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Adjunto no Ingresado :(" + ex);
            }
        }
        string rutaFinal;
        private void CrearDirectorio(string ruta)
        {
            
            string directorioImg = ConfigurationManager.AppSettings["directorio_img"];
            string carpetaAdjunto =  directorioImg + ruta;
            rutaFinal = carpetaAdjunto;
            if (!Directory.Exists(carpetaAdjunto))
            {
                Directory.CreateDirectory(carpetaAdjunto);
                
            }
        }

        private void CargarImagen()
        {
            string directorioImg = ConfigurationManager.AppSettings["directorio_img"];
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = directorioImg;
            getImage.Filter = "Archivos de Imagen|*.jpg;*.gif;*.png;*.bmp";

            

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImage.ImageLocation = getImage.FileName;
                txtRutaImagen.Text = getImage.FileName;

                txtNombreImg.Text = Path.GetFileName(getImage.FileName);
                //pictureBoxImage.Name = getImage.FileName;
                img = Image.FromFile(getImage.FileName);
            }
            else
            {
                MessageBox.Show("no se seleccionó imagen", " sin selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
        }

        private void btnArtas_Click(object sender, EventArgs e)
        {
            Departamentos.MantDepartamentos mantenedorDepartamento = new MantDepartamentos();
            mantenedorDepartamento.Show();
            this.Close();
        }
    }
}
