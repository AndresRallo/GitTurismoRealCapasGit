
namespace CapaPresentacion.Departamentos
{
    partial class EliminarDepartamento
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
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListarDepartamentos = new System.Windows.Forms.Button();
            this.dataGridViewDepartamentos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIDDepartamento = new System.Windows.Forms.TextBox();
            this.lblIngresarID = new System.Windows.Forms.Label();
            this.lblEliminarEmpleado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(545, 78);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(102, 23);
            this.btnProbarConexion.TabIndex = 15;
            this.btnProbarConexion.Text = "Probar Conexion";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(653, 79);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 23);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnListarDepartamentos
            // 
            this.btnListarDepartamentos.Location = new System.Drawing.Point(271, 80);
            this.btnListarDepartamentos.Name = "btnListarDepartamentos";
            this.btnListarDepartamentos.Size = new System.Drawing.Size(135, 23);
            this.btnListarDepartamentos.TabIndex = 13;
            this.btnListarDepartamentos.Text = "Listar/Actualizar";
            this.btnListarDepartamentos.UseVisualStyleBackColor = true;
            this.btnListarDepartamentos.Click += new System.EventHandler(this.btnListarDepartamentos_Click);
            // 
            // dataGridViewDepartamentos
            // 
            this.dataGridViewDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartamentos.Location = new System.Drawing.Point(24, 109);
            this.dataGridViewDepartamentos.Name = "dataGridViewDepartamentos";
            this.dataGridViewDepartamentos.Size = new System.Drawing.Size(764, 329);
            this.dataGridViewDepartamentos.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(130, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtIDDepartamento
            // 
            this.txtIDDepartamento.Location = new System.Drawing.Point(24, 82);
            this.txtIDDepartamento.Name = "txtIDDepartamento";
            this.txtIDDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtIDDepartamento.TabIndex = 10;
            // 
            // lblIngresarID
            // 
            this.lblIngresarID.AutoSize = true;
            this.lblIngresarID.Location = new System.Drawing.Point(21, 63);
            this.lblIngresarID.Name = "lblIngresarID";
            this.lblIngresarID.Size = new System.Drawing.Size(267, 13);
            this.lblIngresarID.TabIndex = 9;
            this.lblIngresarID.Text = "* Para eliminar empleado ingrese su ID correspondiente";
            // 
            // lblEliminarEmpleado
            // 
            this.lblEliminarEmpleado.AutoSize = true;
            this.lblEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblEliminarEmpleado.Location = new System.Drawing.Point(13, 13);
            this.lblEliminarEmpleado.Name = "lblEliminarEmpleado";
            this.lblEliminarEmpleado.Size = new System.Drawing.Size(427, 46);
            this.lblEliminarEmpleado.TabIndex = 8;
            this.lblEliminarEmpleado.Text = "Eliminar Departamento";
            // 
            // EliminarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnListarDepartamentos);
            this.Controls.Add(this.dataGridViewDepartamentos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtIDDepartamento);
            this.Controls.Add(this.lblIngresarID);
            this.Controls.Add(this.lblEliminarEmpleado);
            this.Name = "EliminarDepartamento";
            this.Text = "EliminarDepartamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnVolver;
        protected internal System.Windows.Forms.Button btnListarDepartamentos;
        private System.Windows.Forms.DataGridView dataGridViewDepartamentos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIDDepartamento;
        private System.Windows.Forms.Label lblIngresarID;
        private System.Windows.Forms.Label lblEliminarEmpleado;
    }
}