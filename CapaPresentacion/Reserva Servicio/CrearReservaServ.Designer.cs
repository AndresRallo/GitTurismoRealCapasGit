
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTipoServ
            // 
            this.comboBoxTipoServ.FormattingEnabled = true;
            this.comboBoxTipoServ.Location = new System.Drawing.Point(181, 141);
            this.comboBoxTipoServ.Name = "comboBoxTipoServ";
            this.comboBoxTipoServ.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoServ.TabIndex = 47;
            // 
            // dateTimeFechaServ
            // 
            this.dateTimeFechaServ.Location = new System.Drawing.Point(181, 177);
            this.dateTimeFechaServ.Name = "dateTimeFechaServ";
            this.dateTimeFechaServ.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaServ.TabIndex = 45;
            this.dateTimeFechaServ.ValueChanged += new System.EventHandler(this.dateTimeEntrada_ValueChanged);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(181, 252);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleado.TabIndex = 44;
            // 
            // txtIdReservaDpto
            // 
            this.txtIdReservaDpto.Location = new System.Drawing.Point(181, 106);
            this.txtIdReservaDpto.Name = "txtIdReservaDpto";
            this.txtIdReservaDpto.Size = new System.Drawing.Size(100, 20);
            this.txtIdReservaDpto.TabIndex = 41;
            // 
            // btnReservarServ
            // 
            this.btnReservarServ.Location = new System.Drawing.Point(68, 312);
            this.btnReservarServ.Name = "btnReservarServ";
            this.btnReservarServ.Size = new System.Drawing.Size(103, 23);
            this.btnReservarServ.TabIndex = 40;
            this.btnReservarServ.Text = "Reservar Servicio";
            this.btnReservarServ.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tipo de Servicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "ID de Reserva Depto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Crear Reserva de Servicio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 49;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Hora";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CrearReservaServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}