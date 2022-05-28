
namespace CapaPresentacion
{
    partial class AgregarReserva
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblAgregarReserva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(20, 55);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(316, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "* Para agregar reserva ingrese sus credenciales correspondientes";
            // 
            // lblAgregarReserva
            // 
            this.lblAgregarReserva.AutoSize = true;
            this.lblAgregarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblAgregarReserva.Location = new System.Drawing.Point(12, 9);
            this.lblAgregarReserva.Name = "lblAgregarReserva";
            this.lblAgregarReserva.Size = new System.Drawing.Size(319, 46);
            this.lblAgregarReserva.TabIndex = 4;
            this.lblAgregarReserva.Text = "Agregar Reserva";
            // 
            // AgregarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblAgregarReserva);
            this.Name = "AgregarReserva";
            this.Text = "AgregarReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblAgregarReserva;
    }
}