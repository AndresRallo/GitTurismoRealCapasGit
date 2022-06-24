
namespace CapaPresentacion.Reserva
{
    partial class EliminarReservadepto
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
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.lblIdResDept = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(253, 222);
            this.txtIdReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(132, 22);
            this.txtIdReserva.TabIndex = 75;
            // 
            // lblIdResDept
            // 
            this.lblIdResDept.AutoSize = true;
            this.lblIdResDept.Location = new System.Drawing.Point(96, 222);
            this.lblIdResDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdResDept.Name = "lblIdResDept";
            this.lblIdResDept.Size = new System.Drawing.Size(112, 17);
            this.lblIdResDept.TabIndex = 74;
            this.lblIdResDept.Text = "ID Reserva Dpto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 53;
            this.label1.Text = "Eliminar Reserva";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 362);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 28);
            this.button1.TabIndex = 78;
            this.button1.Text = "Eliminar Reserva Depto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EliminarReservadepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.lblIdResDept);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EliminarReservadepto";
            this.Text = "EliminarReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.Label lblIdResDept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}