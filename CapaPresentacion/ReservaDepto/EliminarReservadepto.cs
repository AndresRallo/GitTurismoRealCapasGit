using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reserva
{
    public partial class EliminarReservadepto : Form
    {
        public EliminarReservadepto()
        {
            InitializeComponent();
        }

        private void btnEliminarDepto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idService = txtIdReserva.Text;

            if (false)
            {
                btnEliminarDepto.Visible = true;
                dateTimeEntrada.Visible = true;
                dateTimeSalida.Visible = true;
                comboBoxAdultos.Visible = true;
                comboBoxNinos.Visible = true;
                comboBoxDepto.Visible = true;
                comboBoxTemporada.Visible = true;
                txtCliente.Visible = true;
                txtAbono.Visible = true;
                txtValor.Visible = true;
            }
            else
                MessageBox.Show($"Servicio no encontrado con el ID :{idService}");
        }
    }
}
