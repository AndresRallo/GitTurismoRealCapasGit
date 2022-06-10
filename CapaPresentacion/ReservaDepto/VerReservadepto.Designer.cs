
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idReservaDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adultos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ninos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crear Reserva";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReservaDepto,
            this.ingreso,
            this.salida,
            this.abono,
            this.total,
            this.adultos,
            this.ninos,
            this.departamento,
            this.temporada,
            this.cliente,
            this.empleado,
            this.estado});
            this.dataGridView1.Location = new System.Drawing.Point(63, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(964, 388);
            this.dataGridView1.TabIndex = 2;
            // 
            // idReservaDepto
            // 
            this.idReservaDepto.HeaderText = "ID";
            this.idReservaDepto.MinimumWidth = 6;
            this.idReservaDepto.Name = "idReservaDepto";
            this.idReservaDepto.Width = 125;
            // 
            // ingreso
            // 
            this.ingreso.HeaderText = "Ingreso";
            this.ingreso.MinimumWidth = 6;
            this.ingreso.Name = "ingreso";
            this.ingreso.Width = 125;
            // 
            // salida
            // 
            this.salida.HeaderText = "Salida";
            this.salida.MinimumWidth = 6;
            this.salida.Name = "salida";
            this.salida.Width = 125;
            // 
            // abono
            // 
            this.abono.HeaderText = "Abono";
            this.abono.MinimumWidth = 6;
            this.abono.Name = "abono";
            this.abono.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 125;
            // 
            // adultos
            // 
            this.adultos.HeaderText = "Cant. adultos";
            this.adultos.MinimumWidth = 6;
            this.adultos.Name = "adultos";
            this.adultos.Width = 125;
            // 
            // ninos
            // 
            this.ninos.HeaderText = "Cant. niños";
            this.ninos.MinimumWidth = 6;
            this.ninos.Name = "ninos";
            this.ninos.Width = 125;
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Departamento";
            this.departamento.MinimumWidth = 6;
            this.departamento.Name = "departamento";
            this.departamento.Width = 125;
            // 
            // temporada
            // 
            this.temporada.HeaderText = "Temporada";
            this.temporada.MinimumWidth = 6;
            this.temporada.Name = "temporada";
            this.temporada.Width = 125;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.MinimumWidth = 6;
            this.cliente.Name = "cliente";
            this.cliente.Width = 125;
            // 
            // empleado
            // 
            this.empleado.HeaderText = "Empleado";
            this.empleado.MinimumWidth = 6;
            this.empleado.Name = "empleado";
            this.empleado.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 125;
            // 
            // VerReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VerReserva";
            this.Text = "VerReserva";
            this.Load += new System.EventHandler(this.VerReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReservaDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ninos;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}