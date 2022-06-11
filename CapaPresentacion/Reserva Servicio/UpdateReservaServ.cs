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
    public partial class UpdateReservaServ : Form
    {
        public UpdateReservaServ()
        {
            InitializeComponent();
        }

        private void btnUpdateResServ_Click(object sender, EventArgs e)
        {
            CEReserva cEReserva = new CEReserva();
            cEReserva.RS_FECHAINGRESO = DateTime.Parse(dateTimeFechaServ.Text);
            cEReserva.IDRESERVA = int.Parse(txtIdReservaDpto.Text);
            cEReserva.IDSERVICIO = int.Parse(comboBoxTipoServ.Text);
            cEReserva.IDEMPLEADO = int.Parse(txtEmpleado.Text);
            cEReserva.RS_HORA = txtHora.Text;
            cEReserva.IDESTADORESERVASERVICIO = int.Parse(txtEmpleado.Text);
            CNReserva reserva = new CNReserva();
            if (reserva.UpdateReserva(cEReserva))
                MessageBox.Show("Servicio agregado");
            else
                MessageBox.Show("Servicio no agregado");
        }
    }
}
