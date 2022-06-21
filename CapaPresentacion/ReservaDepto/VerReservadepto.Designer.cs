
namespace CapaPresentacion.Reserva
{
    partial class VerReservadepto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgReservaDepto = new System.Windows.Forms.DataGridView();
            this.cEReservaDptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IDRESERVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHASA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTADULTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTNINIOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUSUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADORESERVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTEMPORADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReservaDepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEReservaDptoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listar Reserva";
            // 
            // dvgReservaDepto
            // 
            this.dvgReservaDepto.AutoGenerateColumns = false;
            this.dvgReservaDepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgReservaDepto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRESERVA,
            this.FECHAEN,
            this.FECHASA,
            this.ABONO,
            this.TOTAL,
            this.CANTADULTOS,
            this.CANTNINIOS,
            this.IDUSUARIO,
            this.IDDEPTO,
            this.ESTADORESERVA,
            this.IDTEMPORADA});
            this.dvgReservaDepto.DataSource = this.cEReservaDptoBindingSource;
            this.dvgReservaDepto.Location = new System.Drawing.Point(63, 110);
            this.dvgReservaDepto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvgReservaDepto.Name = "dvgReservaDepto";
            this.dvgReservaDepto.RowHeadersWidth = 51;
            this.dvgReservaDepto.Size = new System.Drawing.Size(964, 388);
            this.dvgReservaDepto.TabIndex = 2;
            this.dvgReservaDepto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cEReservaDptoBindingSource
            // 
            this.cEReservaDptoBindingSource.DataSource = typeof(CapaEntidad.CEReservaDpto);
            // 
            // IDRESERVA
            // 
            this.IDRESERVA.DataPropertyName = "IDRESERVA";
            this.IDRESERVA.HeaderText = "IDRESERVA";
            this.IDRESERVA.MinimumWidth = 6;
            this.IDRESERVA.Name = "IDRESERVA";
            this.IDRESERVA.Width = 125;
            // 
            // FECHAEN
            // 
            this.FECHAEN.DataPropertyName = "FECHAEN";
            this.FECHAEN.HeaderText = "FECHAEN";
            this.FECHAEN.MinimumWidth = 6;
            this.FECHAEN.Name = "FECHAEN";
            this.FECHAEN.Width = 125;
            // 
            // FECHASA
            // 
            this.FECHASA.DataPropertyName = "FECHASA";
            this.FECHASA.HeaderText = "FECHASA";
            this.FECHASA.MinimumWidth = 6;
            this.FECHASA.Name = "FECHASA";
            this.FECHASA.Width = 125;
            // 
            // ABONO
            // 
            this.ABONO.DataPropertyName = "ABONO";
            this.ABONO.HeaderText = "ABONO";
            this.ABONO.MinimumWidth = 6;
            this.ABONO.Name = "ABONO";
            this.ABONO.Width = 125;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 6;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Width = 125;
            // 
            // CANTADULTOS
            // 
            this.CANTADULTOS.DataPropertyName = "CANTADULTOS";
            this.CANTADULTOS.HeaderText = "CANTADULTOS";
            this.CANTADULTOS.MinimumWidth = 6;
            this.CANTADULTOS.Name = "CANTADULTOS";
            this.CANTADULTOS.Width = 125;
            // 
            // CANTNINIOS
            // 
            this.CANTNINIOS.DataPropertyName = "CANTNINIOS";
            this.CANTNINIOS.HeaderText = "CANTNINIOS";
            this.CANTNINIOS.MinimumWidth = 6;
            this.CANTNINIOS.Name = "CANTNINIOS";
            this.CANTNINIOS.Width = 125;
            // 
            // IDUSUARIO
            // 
            this.IDUSUARIO.DataPropertyName = "IDUSUARIO";
            this.IDUSUARIO.HeaderText = "IDUSUARIO";
            this.IDUSUARIO.MinimumWidth = 6;
            this.IDUSUARIO.Name = "IDUSUARIO";
            this.IDUSUARIO.Width = 125;
            // 
            // IDDEPTO
            // 
            this.IDDEPTO.DataPropertyName = "IDDEPTO";
            this.IDDEPTO.HeaderText = "IDDEPTO";
            this.IDDEPTO.MinimumWidth = 6;
            this.IDDEPTO.Name = "IDDEPTO";
            this.IDDEPTO.Width = 125;
            // 
            // ESTADORESERVA
            // 
            this.ESTADORESERVA.DataPropertyName = "ESTADORESERVA";
            this.ESTADORESERVA.HeaderText = "ESTADORESERVA";
            this.ESTADORESERVA.MinimumWidth = 6;
            this.ESTADORESERVA.Name = "ESTADORESERVA";
            this.ESTADORESERVA.Width = 125;
            // 
            // IDTEMPORADA
            // 
            this.IDTEMPORADA.DataPropertyName = "IDTEMPORADA";
            this.IDTEMPORADA.HeaderText = "IDTEMPORADA";
            this.IDTEMPORADA.MinimumWidth = 6;
            this.IDTEMPORADA.Name = "IDTEMPORADA";
            this.IDTEMPORADA.Width = 125;
            // 
            // VerReservadepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dvgReservaDepto);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VerReservadepto";
            this.Text = "VerReserva";
            this.Load += new System.EventHandler(this.VerReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgReservaDepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEReservaDptoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgReservaDepto;
        private System.Windows.Forms.BindingSource cEReservaDptoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRESERVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHASA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTADULTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTNINIOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUSUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDEPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADORESERVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTEMPORADA;
    }
}