
namespace CapaPresentacion.Servicios
{
    partial class DeleteService
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdServicio = new System.Windows.Forms.TextBox();
            this.btnEliminarResServicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar un servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID del servicio";
            // 
            // txtIdServicio
            // 
            this.txtIdServicio.Location = new System.Drawing.Point(279, 149);
            this.txtIdServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdServicio.Name = "txtIdServicio";
            this.txtIdServicio.Size = new System.Drawing.Size(132, 22);
            this.txtIdServicio.TabIndex = 3;
            // 
            // btnEliminarResServicio
            // 
            this.btnEliminarResServicio.Location = new System.Drawing.Point(164, 235);
            this.btnEliminarResServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarResServicio.Name = "btnEliminarResServicio";
            this.btnEliminarResServicio.Size = new System.Drawing.Size(130, 28);
            this.btnEliminarResServicio.TabIndex = 5;
            this.btnEliminarResServicio.Text = "Eliminar Servicio";
            this.btnEliminarResServicio.UseVisualStyleBackColor = true;
            this.btnEliminarResServicio.Visible = false;
            this.btnEliminarResServicio.Click += new System.EventHandler(this.btnEliminarResServicio_Click);
            // 
            // DeleteService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 554);
            this.Controls.Add(this.btnEliminarResServicio);
            this.Controls.Add(this.txtIdServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteService";
            this.Text = "DeleteService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdServicio;
        private System.Windows.Forms.Button btnEliminarResServicio;
    }
}