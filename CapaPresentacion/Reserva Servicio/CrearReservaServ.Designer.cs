
namespace CapaPresentacion.Reserva_Servicio
{
    partial class CrearReservaServ
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
            this.comboBoxTipoServ = new System.Windows.Forms.ComboBox();
            this.dateTimeFechaServ = new System.Windows.Forms.DateTimePicker();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtIdReservaDpto = new System.Windows.Forms.TextBox();
            this.btnReservarServ = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTipoServ
            // 
            this.comboBoxTipoServ.FormattingEnabled = true;
            this.comboBoxTipoServ.Location = new System.Drawing.Point(241, 174);
            this.comboBoxTipoServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTipoServ.Name = "comboBoxTipoServ";
            this.comboBoxTipoServ.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTipoServ.TabIndex = 47;
            // 
            // dateTimeFechaServ
            // 
            this.dateTimeFechaServ.Location = new System.Drawing.Point(241, 218);
            this.dateTimeFechaServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeFechaServ.Name = "dateTimeFechaServ";
            this.dateTimeFechaServ.Size = new System.Drawing.Size(265, 26);
            this.dateTimeFechaServ.TabIndex = 45;
            this.dateTimeFechaServ.ValueChanged += new System.EventHandler(this.dateTimeEntrada_ValueChanged);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(241, 310);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(132, 26);
            this.txtEmpleado.TabIndex = 44;
            // 
            // txtIdReservaDpto
            // 
            this.txtIdReservaDpto.Location = new System.Drawing.Point(241, 130);
            this.txtIdReservaDpto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdReservaDpto.Name = "txtIdReservaDpto";
            this.txtIdReservaDpto.Size = new System.Drawing.Size(132, 26);
            this.txtIdReservaDpto.TabIndex = 41;
            // 
            // btnReservarServ
            // 
            this.btnReservarServ.Location = new System.Drawing.Point(91, 384);
            this.btnReservarServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservarServ.Name = "btnReservarServ";
            this.btnReservarServ.Size = new System.Drawing.Size(137, 28);
            this.btnReservarServ.TabIndex = 40;
            this.btnReservarServ.Text = "Reservar Servicio";
            this.btnReservarServ.UseVisualStyleBackColor = true;
            this.btnReservarServ.Click += new System.EventHandler(this.btnReservarServ_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tipo de Servicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "ID de Reserva Depto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 319);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Crear Reserva de Servicio";
            // 
            // textHora
            // 
            this.textHora.Location = new System.Drawing.Point(241, 258);
            this.textHora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textHora.Name = "textHora";
            this.textHora.Size = new System.Drawing.Size(132, 26);
            this.textHora.TabIndex = 49;
            this.textHora.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Hora";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CrearReservaServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTipoServ);
            this.Controls.Add(this.dateTimeFechaServ);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtIdReservaDpto);
            this.Controls.Add(this.btnReservarServ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrearReservaServ";
            this.Text = "CrearReservaServ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxTipoServ;
        private System.Windows.Forms.DateTimePicker dateTimeFechaServ;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtIdReservaDpto;
        private System.Windows.Forms.Button btnReservarServ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textHora;
        private System.Windows.Forms.Label label3;
    }
}