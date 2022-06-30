
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
            this.cEReservaDptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDRESERVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHASADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aBONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTADULTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTNINIOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDEPTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADORESERVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEMPLEADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTEMPORADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
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
            this.IDTEMPORADA,
            this.iDRESERVADataGridViewTextBoxColumn,
            this.fECHAENDataGridViewTextBoxColumn,
            this.fECHASADataGridViewTextBoxColumn,
            this.aBONODataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn,
            this.cANTADULTOSDataGridViewTextBoxColumn,
            this.cANTNINIOSDataGridViewTextBoxColumn,
            this.iDUSUARIODataGridViewTextBoxColumn,
            this.iDDEPTODataGridViewTextBoxColumn,
            this.eSTADORESERVADataGridViewTextBoxColumn,
            this.iDEMPLEADODataGridViewTextBoxColumn,
            this.iDTEMPORADADataGridViewTextBoxColumn});
            this.dvgReservaDepto.DataSource = this.cEReservaDptoBindingSource;
            this.dvgReservaDepto.Location = new System.Drawing.Point(63, 110);
            this.dvgReservaDepto.Margin = new System.Windows.Forms.Padding(4);
            this.dvgReservaDepto.Name = "dvgReservaDepto";
            this.dvgReservaDepto.RowHeadersWidth = 51;
            this.dvgReservaDepto.Size = new System.Drawing.Size(964, 388);
            this.dvgReservaDepto.TabIndex = 2;
            this.dvgReservaDepto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // cEReservaDptoBindingSource
            // 
            this.cEReservaDptoBindingSource.DataSource = typeof(CapaEntidad.CEReservaDpto);
            // 
            // iDRESERVADataGridViewTextBoxColumn
            // 
            this.iDRESERVADataGridViewTextBoxColumn.DataPropertyName = "IDRESERVA";
            this.iDRESERVADataGridViewTextBoxColumn.HeaderText = "IDRESERVA";
            this.iDRESERVADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRESERVADataGridViewTextBoxColumn.Name = "iDRESERVADataGridViewTextBoxColumn";
            this.iDRESERVADataGridViewTextBoxColumn.Width = 125;
            // 
            // fECHAENDataGridViewTextBoxColumn
            // 
            this.fECHAENDataGridViewTextBoxColumn.DataPropertyName = "FECHAEN";
            this.fECHAENDataGridViewTextBoxColumn.HeaderText = "FECHAEN";
            this.fECHAENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHAENDataGridViewTextBoxColumn.Name = "fECHAENDataGridViewTextBoxColumn";
            this.fECHAENDataGridViewTextBoxColumn.Width = 125;
            // 
            // fECHASADataGridViewTextBoxColumn
            // 
            this.fECHASADataGridViewTextBoxColumn.DataPropertyName = "FECHASA";
            this.fECHASADataGridViewTextBoxColumn.HeaderText = "FECHASA";
            this.fECHASADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHASADataGridViewTextBoxColumn.Name = "fECHASADataGridViewTextBoxColumn";
            this.fECHASADataGridViewTextBoxColumn.Width = 125;
            // 
            // aBONODataGridViewTextBoxColumn
            // 
            this.aBONODataGridViewTextBoxColumn.DataPropertyName = "ABONO";
            this.aBONODataGridViewTextBoxColumn.HeaderText = "ABONO";
            this.aBONODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aBONODataGridViewTextBoxColumn.Name = "aBONODataGridViewTextBoxColumn";
            this.aBONODataGridViewTextBoxColumn.Width = 125;
            // 
            // tOTALDataGridViewTextBoxColumn
            // 
            this.tOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tOTALDataGridViewTextBoxColumn.Name = "tOTALDataGridViewTextBoxColumn";
            this.tOTALDataGridViewTextBoxColumn.Width = 125;
            // 
            // cANTADULTOSDataGridViewTextBoxColumn
            // 
            this.cANTADULTOSDataGridViewTextBoxColumn.DataPropertyName = "CANTADULTOS";
            this.cANTADULTOSDataGridViewTextBoxColumn.HeaderText = "CANTADULTOS";
            this.cANTADULTOSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cANTADULTOSDataGridViewTextBoxColumn.Name = "cANTADULTOSDataGridViewTextBoxColumn";
            this.cANTADULTOSDataGridViewTextBoxColumn.Width = 125;
            // 
            // cANTNINIOSDataGridViewTextBoxColumn
            // 
            this.cANTNINIOSDataGridViewTextBoxColumn.DataPropertyName = "CANTNINIOS";
            this.cANTNINIOSDataGridViewTextBoxColumn.HeaderText = "CANTNINIOS";
            this.cANTNINIOSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cANTNINIOSDataGridViewTextBoxColumn.Name = "cANTNINIOSDataGridViewTextBoxColumn";
            this.cANTNINIOSDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDUSUARIODataGridViewTextBoxColumn
            // 
            this.iDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "IDUSUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.HeaderText = "IDUSUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDUSUARIODataGridViewTextBoxColumn.Name = "iDUSUARIODataGridViewTextBoxColumn";
            this.iDUSUARIODataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDEPTODataGridViewTextBoxColumn
            // 
            this.iDDEPTODataGridViewTextBoxColumn.DataPropertyName = "IDDEPTO";
            this.iDDEPTODataGridViewTextBoxColumn.HeaderText = "IDDEPTO";
            this.iDDEPTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDEPTODataGridViewTextBoxColumn.Name = "iDDEPTODataGridViewTextBoxColumn";
            this.iDDEPTODataGridViewTextBoxColumn.Width = 125;
            // 
            // eSTADORESERVADataGridViewTextBoxColumn
            // 
            this.eSTADORESERVADataGridViewTextBoxColumn.DataPropertyName = "ESTADORESERVA";
            this.eSTADORESERVADataGridViewTextBoxColumn.HeaderText = "ESTADORESERVA";
            this.eSTADORESERVADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eSTADORESERVADataGridViewTextBoxColumn.Name = "eSTADORESERVADataGridViewTextBoxColumn";
            this.eSTADORESERVADataGridViewTextBoxColumn.Width = 125;
            // 
            // iDEMPLEADODataGridViewTextBoxColumn
            // 
            this.iDEMPLEADODataGridViewTextBoxColumn.DataPropertyName = "IDEMPLEADO";
            this.iDEMPLEADODataGridViewTextBoxColumn.HeaderText = "IDEMPLEADO";
            this.iDEMPLEADODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDEMPLEADODataGridViewTextBoxColumn.Name = "iDEMPLEADODataGridViewTextBoxColumn";
            this.iDEMPLEADODataGridViewTextBoxColumn.Width = 125;
            // 
            // iDTEMPORADADataGridViewTextBoxColumn
            // 
            this.iDTEMPORADADataGridViewTextBoxColumn.DataPropertyName = "IDTEMPORADA";
            this.iDTEMPORADADataGridViewTextBoxColumn.HeaderText = "IDTEMPORADA";
            this.iDTEMPORADADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDTEMPORADADataGridViewTextBoxColumn.Name = "iDTEMPORADADataGridViewTextBoxColumn";
            this.iDTEMPORADADataGridViewTextBoxColumn.Width = 125;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(63, 531);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 28);
            this.btnVolver.TabIndex = 55;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // VerReservadepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 571);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dvgReservaDepto);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRESERVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHASADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aBONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTADULTOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTNINIOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDEPTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADORESERVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEMPLEADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTEMPORADADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnVolver;
    }
}