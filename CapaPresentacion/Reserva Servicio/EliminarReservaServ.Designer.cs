
namespace CapaPresentacion.Reserva_Servicio
{
    partial class EliminarReservaServ
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
            this.btnEliminarResServ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipoServ = new System.Windows.Forms.ComboBox();
            this.dateTimeFechaServ = new System.Windows.Forms.DateTimePicker();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtIdReservaDpto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminarResServ
            // 
            this.btnEliminarResServ.Location = new System.Drawing.Point(84, 393);
            this.btnEliminarResServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarResServ.Name = "btnEliminarResServ";
            this.btnEliminarResServ.Size = new System.Drawing.Size(137, 28);
            this.btnEliminarResServ.TabIndex = 63;
            this.btnEliminarResServ.Text = "Eliminar Reserva Servicio";
            this.btnEliminarResServ.UseVisualStyleBackColor = true;
            this.btnEliminarResServ.Click += new System.EventHandler(this.btnEliminarResServ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "Eliminar Reserva de Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 453);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(666, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Fecha, Tipo Servicio y Empleado debiesen estar deshabilitados y actualizarse con " +
    "el ID ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 270);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Hora";
            // 
            // comboBoxTipoServ
            // 
            this.comboBoxTipoServ.FormattingEnabled = true;
            this.comboBoxTipoServ.Location = new System.Drawing.Point(235, 185);
            this.comboBoxTipoServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTipoServ.Name = "comboBoxTipoServ";
            this.comboBoxTipoServ.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTipoServ.TabIndex = 76;
            // 
            // dateTimeFechaServ
            // 
            this.dateTimeFechaServ.Location = new System.Drawing.Point(235, 229);
            this.dateTimeFechaServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeFechaServ.Name = "dateTimeFechaServ";
            this.dateTimeFechaServ.Size = new System.Drawing.Size(265, 26);
            this.dateTimeFechaServ.TabIndex = 75;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(235, 321);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(132, 26);
            this.txtEmpleado.TabIndex = 74;
            // 
            // txtIdReservaDpto
            // 
            this.txtIdReservaDpto.Location = new System.Drawing.Point(235, 142);
            this.txtIdReservaDpto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdReservaDpto.Name = "txtIdReservaDpto";
            this.txtIdReservaDpto.Size = new System.Drawing.Size(132, 26);
            this.txtIdReservaDpto.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 196);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 72;
            this.label10.Text = "Tipo de Servicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 71;
            this.label8.Text = "ID de Reserva Depto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Fecha";
            // 
            // EliminarReservaServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTipoServ);
            this.Controls.Add(this.dateTimeFechaServ);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtIdReservaDpto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminarResServ);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EliminarReservaServ";
            this.Text = "EliminarReservaServ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarResServ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipoServ;
        private System.Windows.Forms.DateTimePicker dateTimeFechaServ;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtIdReservaDpto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}