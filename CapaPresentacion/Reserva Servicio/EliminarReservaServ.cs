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

namespace CapaPresentacion.Reserva_Servicio
{
    public partial class EliminarReservaServ : Form
    {
        public EliminarReservaServ()
        {
            InitializeComponent();
        }

        private void btnEliminarResServ_Click(object sender, EventArgs e)
        {
            CEReserva cEReserva = new CEReserva();
            cEReserva.IDRESERVA = int.Parse(txtIdReservaDpto.Text);
            CNReserva reserva = new CNReserva();
            if (reserva.DeleteReserva(cEReserva))
                MessageBox.Show("Reserva eliminada");
            else
                MessageBox.Show("Reserva no eliminada");
        }
    }
}
