
namespace CapaPresentacion.Departamentos
{
    partial class MantDepartamentos
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMantenedorEmpleado = new System.Windows.Forms.Label();
            this.btnConexion = new System.Windows.Forms.Button();
            this.btnAdjuntos = new System.Windows.Forms.Button();
            this.btnAdjuntosLisEli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(436, 405);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(544, 229);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Cambiar Estado";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(403, 229);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(135, 23);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(262, 229);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(121, 229);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblMantenedorEmpleado
            // 
            this.lblMantenedorEmpleado.AutoSize = true;
            this.lblMantenedorEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lblMantenedorEmpleado.Location = new System.Drawing.Point(89, 33);
            this.lblMantenedorEmpleado.Name = "lblMantenedorEmpleado";
            this.lblMantenedorEmpleado.Size = new System.Drawing.Size(625, 55);
            this.lblMantenedorEmpleado.TabIndex = 7;
            this.lblMantenedorEmpleado.Text = "Mantenedor Departamentos";
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(577, 405);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(110, 23);
            this.btnConexion.TabIndex = 13;
            this.btnConexion.Text = "Cerrar Aplicación";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // btnAdjuntos
            // 
            this.btnAdjuntos.Location = new System.Drawing.Point(132, 293);
            this.btnAdjuntos.Name = "btnAdjuntos";
            this.btnAdjuntos.Size = new System.Drawing.Size(135, 23);
            this.btnAdjuntos.TabIndex = 14;
            this.btnAdjuntos.Text = "Adjuntos Agregar";
            this.btnAdjuntos.UseVisualStyleBackColor = true;
            this.btnAdjuntos.Click += new System.EventHandler(this.btnAdjuntos_Click);
            // 
            // btnAdjuntosLisEli
            // 
            this.btnAdjuntosLisEli.Location = new System.Drawing.Point(304, 293);
            this.btnAdjuntosLisEli.Name = "btnAdjuntosLisEli";
            this.btnAdjuntosLisEli.Size = new System.Drawing.Size(135, 23);
            this.btnAdjuntosLisEli.TabIndex = 15;
            this.btnAdjuntosLisEli.Text = "Adjuntos Listar Eliminar";
            this.btnAdjuntosLisEli.UseVisualStyleBackColor = true;
            this.btnAdjuntosLisEli.Click += new System.EventHandler(this.btnAdjuntosLisEli_Click);
            // 
            // MantDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdjuntosLisEli);
            this.Controls.Add(this.btnAdjuntos);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMantenedorEmpleado);
            this.Name = "MantDepartamentos";
            this.Text = "MantenedorDepartamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMantenedorEmpleado;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Button btnAdjuntos;
        private System.Windows.Forms.Button btnAdjuntosLisEli;
    }
}