
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
            this.lblNameService = new System.Windows.Forms.Label();
            this.txtIdServicio = new System.Windows.Forms.TextBox();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.btnEliminarResServicio = new System.Windows.Forms.Button();
            this.GetById = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar un servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID del servicio";
            // 
            // lblNameService
            // 
            this.lblNameService.AutoSize = true;
            this.lblNameService.Location = new System.Drawing.Point(184, 257);
            this.lblNameService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameService.Name = "lblNameService";
            this.lblNameService.Size = new System.Drawing.Size(158, 20);
            this.lblNameService.TabIndex = 2;
            this.lblNameService.Text = "Nombre del servicio";
            this.lblNameService.Visible = false;
            // 
            // txtIdServicio
            // 
            this.txtIdServicio.Location = new System.Drawing.Point(393, 183);
            this.txtIdServicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdServicio.Name = "txtIdServicio";
            this.txtIdServicio.Size = new System.Drawing.Size(148, 26);
            this.txtIdServicio.TabIndex = 3;
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(393, 246);
            this.txtNombreServicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(148, 26);
            this.txtNombreServicio.TabIndex = 4;
            this.txtNombreServicio.Visible = false;
            // 
            // btnEliminarResServicio
            // 
            this.btnEliminarResServicio.Location = new System.Drawing.Point(379, 338);
            this.btnEliminarResServicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarResServicio.Name = "btnEliminarResServicio";
            this.btnEliminarResServicio.Size = new System.Drawing.Size(146, 35);
            this.btnEliminarResServicio.TabIndex = 5;
            this.btnEliminarResServicio.Text = "Eliminar Servicio";
            this.btnEliminarResServicio.UseVisualStyleBackColor = true;
            this.btnEliminarResServicio.Visible = false;
            this.btnEliminarResServicio.Click += new System.EventHandler(this.btnEliminarResServicio_Click);
            // 
            // GetById
            // 
            this.GetById.Location = new System.Drawing.Point(188, 338);
            this.GetById.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetById.Name = "GetById";
            this.GetById.Size = new System.Drawing.Size(146, 35);
            this.GetById.TabIndex = 7;
            this.GetById.Text = "Consultar";
            this.GetById.UseVisualStyleBackColor = true;
            this.GetById.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.GetById);
            this.Controls.Add(this.btnEliminarResServicio);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(this.txtIdServicio);
            this.Controls.Add(this.lblNameService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeleteService";
            this.Text = "DeleteService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameService;
        private System.Windows.Forms.TextBox txtIdServicio;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Button btnEliminarResServicio;
        private System.Windows.Forms.Button GetById;
    }
}