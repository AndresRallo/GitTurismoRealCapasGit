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
    public partial class Adjunto : Form
    {
        Librarys librarys = new Librarys();
        CNDepartamento cNDepartamento = new CNDepartamento();

        public Adjunto()
        {
            InitializeComponent();
            LoadComboEstado();
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
    }
}
