
namespace CapaPresentacion
{
    partial class MenuPrincipal
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
            this.btnCerrarAplicacion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMantenedorEmpleados = new System.Windows.Forms.Button();
            this.btnMantenedorDepartamento = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarAplicacion
            // 
            this.btnCerrarAplicacion.Location = new System.Drawing.Point(601, 325);
            this.btnCerrarAplicacion.Name = "btnCerrarAplicacion";
            this.btnCerrarAplicacion.Size = new System.Drawing.Size(102, 23);
            this.btnCerrarAplicacion.TabIndex = 0;
            this.btnCerrarAplicacion.Text = "Cerrar Aplicación";
            this.btnCerrarAplicacion.UseVisualStyleBackColor = true;
            this.btnCerrarAplicacion.Click += new System.EventHandler(this.btnCerrarAplicacion_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Controlador\r\nPropiedades";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMantenedorEmpleados
            // 
            this.btnMantenedorEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenedorEmpleados.Location = new System.Drawing.Point(595, 232);
            this.btnMantenedorEmpleados.Name = "btnMantenedorEmpleados";
            this.btnMantenedorEmpleados.Size = new System.Drawing.Size(107, 52);
            this.btnMantenedorEmpleados.TabIndex = 2;
            this.btnMantenedorEmpleados.Text = "Mantenedor Empleados";
            this.btnMantenedorEmpleados.UseVisualStyleBackColor = true;
            this.btnMantenedorEmpleados.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMantenedorDepartamento
            // 
            this.btnMantenedorDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenedorDepartamento.Location = new System.Drawing.Point(402, 232);
            this.btnMantenedorDepartamento.Name = "btnMantenedorDepartamento";
            this.btnMantenedorDepartamento.Size = new System.Drawing.Size(107, 52);
            this.btnMantenedorDepartamento.TabIndex = 3;
            this.btnMantenedorDepartamento.Text = "Mantenedor Departamento";
            this.btnMantenedorDepartamento.UseVisualStyleBackColor = true;
            this.btnMantenedorDepartamento.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(209, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "Controlador\r\nInventario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCerrarAplicacion);
            this.groupBox1.Controls.Add(this.btnMantenedorEmpleados);
            this.groupBox1.Controls.Add(this.btnMantenedorDepartamento);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(44, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 364);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Elija un mantenedor";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarAplicacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMantenedorEmpleados;
        private System.Windows.Forms.Button btnMantenedorDepartamento;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}