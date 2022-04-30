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

namespace CapaPresentacion.Departamentos
{
    public partial class AgregarDepartamento : Form
    {
        CNDepartamento cNDepartamento = new CNDepartamento();

        public AgregarDepartamento()
        {
            InitializeComponent();
        }

        private void btnAgreDepto_Click(object sender, EventArgs e)
        {
            try
            {
                CEDepartamento depto = new CEDepartamento();

                depto.descripcionDepto = txtDescDepto.Text;
                depto.precioDepto = Convert.ToInt32(txtPrecio.Text);
                //depto.idTipoDepto = Convert.ToInt32(cbxTipoDepto.Text);
                //depto.idEstadoDepto = Convert.ToInt32(cbxEstadoDepa.Text);

                cNDepartamento.CrearDepartamento(depto);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Departamento no agregado :(" + ex);
            }
        }
    }
}
