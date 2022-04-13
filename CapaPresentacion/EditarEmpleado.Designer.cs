
namespace CapaPresentacion
{
    partial class EditarEmpleado
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
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.lblDV = new System.Windows.Forms.Label();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAPaterno = new System.Windows.Forms.Label();
            this.lblAMaterno = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblIDEmpresa = new System.Windows.Forms.Label();
            this.lblIDTipo = new System.Windows.Forms.Label();
            this.lblIDEstado = new System.Windows.Forms.Label();
            this.lblIDDireccion = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtIDEmpresa = new System.Windows.Forms.TextBox();
            this.txtIDTipo = new System.Windows.Forms.TextBox();
            this.txtIDEstado = new System.Windows.Forms.TextBox();
            this.txtIDDireccion = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "* Para editar empleado ingrese su ID correspondiente";
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(334, 92);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(454, 346);
            this.dataGridViewEmpleados.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(653, 58);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(497, 58);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(150, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar/Actualizar Empleados";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(396, 58);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(95, 23);
            this.btnProbarConexion.TabIndex = 5;
            this.btnProbarConexion.Text = "Probar Conexion";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Location = new System.Drawing.Point(21, 92);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(21, 13);
            this.lblIDEmpleado.TabIndex = 6;
            this.lblIDEmpleado.Text = "ID ";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(21, 118);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(24, 13);
            this.lblRut.TabIndex = 7;
            this.lblRut.Text = "Rut";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Location = new System.Drawing.Point(111, 89);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtIDEmpleado.TabIndex = 8;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(111, 115);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(100, 20);
            this.txtRut.TabIndex = 9;
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.Location = new System.Drawing.Point(217, 118);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(10, 13);
            this.lblDV.TabIndex = 10;
            this.lblDV.Text = "-";
            // 
            // txtDV
            // 
            this.txtDV.Location = new System.Drawing.Point(233, 115);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(24, 20);
            this.txtDV.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 144);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAPaterno
            // 
            this.lblAPaterno.AutoSize = true;
            this.lblAPaterno.Location = new System.Drawing.Point(21, 170);
            this.lblAPaterno.Name = "lblAPaterno";
            this.lblAPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblAPaterno.TabIndex = 13;
            this.lblAPaterno.Text = "Apellido Paterno";
            // 
            // lblAMaterno
            // 
            this.lblAMaterno.AutoSize = true;
            this.lblAMaterno.Location = new System.Drawing.Point(21, 196);
            this.lblAMaterno.Name = "lblAMaterno";
            this.lblAMaterno.Size = new System.Drawing.Size(86, 13);
            this.lblAMaterno.TabIndex = 14;
            this.lblAMaterno.Text = "Apellido Materno";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 222);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(21, 248);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenia.TabIndex = 16;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblIDEmpresa
            // 
            this.lblIDEmpresa.AutoSize = true;
            this.lblIDEmpresa.Location = new System.Drawing.Point(21, 273);
            this.lblIDEmpresa.Name = "lblIDEmpresa";
            this.lblIDEmpresa.Size = new System.Drawing.Size(62, 13);
            this.lblIDEmpresa.TabIndex = 17;
            this.lblIDEmpresa.Text = "ID Empresa";
            // 
            // lblIDTipo
            // 
            this.lblIDTipo.AutoSize = true;
            this.lblIDTipo.Location = new System.Drawing.Point(21, 299);
            this.lblIDTipo.Name = "lblIDTipo";
            this.lblIDTipo.Size = new System.Drawing.Size(42, 13);
            this.lblIDTipo.TabIndex = 18;
            this.lblIDTipo.Text = "ID Tipo";
            // 
            // lblIDEstado
            // 
            this.lblIDEstado.AutoSize = true;
            this.lblIDEstado.Location = new System.Drawing.Point(21, 325);
            this.lblIDEstado.Name = "lblIDEstado";
            this.lblIDEstado.Size = new System.Drawing.Size(54, 13);
            this.lblIDEstado.TabIndex = 19;
            this.lblIDEstado.Text = "ID Estado";
            // 
            // lblIDDireccion
            // 
            this.lblIDDireccion.AutoSize = true;
            this.lblIDDireccion.Location = new System.Drawing.Point(21, 351);
            this.lblIDDireccion.Name = "lblIDDireccion";
            this.lblIDDireccion.Size = new System.Drawing.Size(66, 13);
            this.lblIDDireccion.TabIndex = 20;
            this.lblIDDireccion.Text = "ID Direccion";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(111, 141);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 22;
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(111, 167);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(100, 20);
            this.txtAPaterno.TabIndex = 23;
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(111, 193);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtAMaterno.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(111, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 25;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(111, 245);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(100, 20);
            this.txtContrasenia.TabIndex = 26;
            // 
            // txtIDEmpresa
            // 
            this.txtIDEmpresa.Location = new System.Drawing.Point(111, 270);
            this.txtIDEmpresa.Name = "txtIDEmpresa";
            this.txtIDEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtIDEmpresa.TabIndex = 27;
            // 
            // txtIDTipo
            // 
            this.txtIDTipo.Location = new System.Drawing.Point(111, 296);
            this.txtIDTipo.Name = "txtIDTipo";
            this.txtIDTipo.Size = new System.Drawing.Size(100, 20);
            this.txtIDTipo.TabIndex = 28;
            // 
            // txtIDEstado
            // 
            this.txtIDEstado.Location = new System.Drawing.Point(111, 322);
            this.txtIDEstado.Name = "txtIDEstado";
            this.txtIDEstado.Size = new System.Drawing.Size(100, 20);
            this.txtIDEstado.TabIndex = 29;
            // 
            // txtIDDireccion
            // 
            this.txtIDDireccion.Location = new System.Drawing.Point(111, 348);
            this.txtIDDireccion.Name = "txtIDDireccion";
            this.txtIDDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtIDDireccion.TabIndex = 30;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(24, 415);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 23);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.Text = "Editar Empleado";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // EditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtIDDireccion);
            this.Controls.Add(this.txtIDEstado);
            this.Controls.Add(this.txtIDTipo);
            this.Controls.Add(this.txtIDEmpresa);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAMaterno);
            this.Controls.Add(this.txtAPaterno);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblIDDireccion);
            this.Controls.Add(this.lblIDEstado);
            this.Controls.Add(this.lblIDTipo);
            this.Controls.Add(this.lblIDEmpresa);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAMaterno);
            this.Controls.Add(this.lblAPaterno);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDV);
            this.Controls.Add(this.lblDV);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.txtIDEmpleado);
            this.Controls.Add(this.lblRut);
            this.Controls.Add(this.lblIDEmpleado);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarEmpleado";
            this.Text = "EditarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Label lblIDEmpleado;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAPaterno;
        private System.Windows.Forms.Label lblAMaterno;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblIDEmpresa;
        private System.Windows.Forms.Label lblIDTipo;
        private System.Windows.Forms.Label lblIDEstado;
        private System.Windows.Forms.Label lblIDDireccion;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtAPaterno;
        private System.Windows.Forms.TextBox txtAMaterno;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtIDEmpresa;
        private System.Windows.Forms.TextBox txtIDTipo;
        private System.Windows.Forms.TextBox txtIDEstado;
        private System.Windows.Forms.TextBox txtIDDireccion;
        private System.Windows.Forms.Button btnEditar;
    }
}