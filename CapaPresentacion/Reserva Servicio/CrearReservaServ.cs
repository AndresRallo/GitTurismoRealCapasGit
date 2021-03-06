using CapaDatos;
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
    public partial class CrearReservaServ : Form
    {
        public CrearReservaServ()
        {
            InitializeComponent();
            LoadComboService();
        }

        private void LoadComboService()
        {
            try
            {
                CNService ListALLService = new CNService();
               List<CEService> services = ListALLService.ListALLService();

                comboBoxTipoServ.DataSource = services;
                comboBoxTipoServ.ValueMember = "IdService";
                comboBoxTipoServ.DisplayMember = "NameService";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo servicio" + ex);
            }
        }

        private void dateTimeEntrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReservarServ_Click(object sender, EventArgs e)
        {
            CEReserva cEReserva = new CEReserva();
            cEReserva.RS_FECHAINGRESO = DateTime.Parse(dateTimeFechaServ.Text);
            cEReserva.IDRESERVA = int.Parse(txtIdReservaDpto.Text);
            cEReserva.IDSERVICIO = int.Parse(comboBoxTipoServ.Text);
            cEReserva.RS_HORA = textHora.Text;
            cEReserva.IDEMPLEADO = int.Parse(txtEmpleado.Text);
            cEReserva.IDESTADORESERVASERVICIO = int.Parse(txtEmpleado.Text);
            CNReserva reserva = new CNReserva();
            if (reserva.CreateReserva(cEReserva))
                MessageBox.Show("Servicio agregado");
            else
                MessageBox.Show("Servicio no agregado");


        }
    }
}
