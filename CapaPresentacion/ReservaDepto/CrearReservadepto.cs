using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion.Reserva
{
    public partial class CrearReservadepto : Form
    {
        public CrearReservadepto()
        {
            InitializeComponent();
            LoadCombo();
            LoadComboN();

        }
       
        private void LoadComboN()
        {
            try
            {
                List<CENumeros> cENumeros = new List<CENumeros>();

                for (int i = 1; i < 11; i++)
                {
                    CENumeros cENumero = new CENumeros();
                    cENumero.Id = i;
                    cENumero.value = i;
                    cENumeros.Add(cENumero);
                }

                comboBoxNinos.DataSource = cENumeros;
                comboBoxNinos.ValueMember = "ID";
                comboBoxNinos.DisplayMember = "value";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo estado empleado" + ex);
            }
        }
        private void LoadCombo()
        {
            try
            {
                List<CENumeros> cENumeros = new List<CENumeros>();

                for (int i = 1; i < 11; i++)
                {
                    CENumeros cENumero = new CENumeros();
                    cENumero.Id = i;
                    cENumero.value = i;
                    cENumeros.Add(cENumero);
                }

                comboBoxAdultos.DataSource = cENumeros;
                comboBoxAdultos.ValueMember = "ID";
                comboBoxAdultos.DisplayMember = "value";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo estado empleado" + ex);
            }
        }

        private void btnReservarDepto_Click(object sender, EventArgs e)
        {
            CEReservaDpto cEReserva = new CEReservaDpto();
            cEReserva.FECHASA = (dateTimeSalida.Text != "") ? DateTime.Parse(dateTimeSalida.Text) : DateTime.Now;
            cEReserva.FECHAEN = (dateTimeEntrada.Text != "") ? DateTime.Parse(dateTimeEntrada.Text) : DateTime.Now;
            cEReserva.ABONO = (txtAbono.Text != "") ? int.Parse(txtAbono.Text) : 0;
            cEReserva.TOTAL = (txtValor.Text != "") ? int.Parse(txtValor.Text) : 0;
            cEReserva.CANTADULTOS = (comboBoxAdultos.Text != "") ? int.Parse(comboBoxAdultos.Text) : 0;
            cEReserva.CANTNINIOS = (comboBoxNinos.Text != "") ? int.Parse(comboBoxNinos.Text) : 0;
            cEReserva.IDDEPTO = (comboBoxDepto.Text != "") ? int.Parse(comboBoxDepto.Text) : 0;
            cEReserva.IDTEMPORADA = (comboBoxTemporada.Text != "") ? int.Parse(comboBoxTemporada.Text) : 0;
            cEReserva.IDUSUARIO = (txtCliente.Text != "")? int.Parse(txtCliente.Text) :0;
            cEReserva.IDEMPLEADO = (txtEmpleado.Text !="")? int.Parse(txtEmpleado.Text): 0;

            CNReservaDpto cNReserva = new CNReservaDpto();
            if (cNReserva.CreateReserva(cEReserva))

                MessageBox.Show("Reserva agregado");
            else
                MessageBox.Show("Reserva no agregada");
        }
    }
}
