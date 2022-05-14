
namespace CapaPresentacion
{
    partial class CambiarEstadoUsuario
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
            this.btnListarUsuario = new System.Windows.Forms.Button();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.lblIngresarID = new System.Windows.Forms.Label();
            this.lblEliminarEmpleado = new System.Windows.Forms.Label();
            this.cbESTADO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
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
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(653, 79);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 23);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnListarUsuario
            // 
            this.btnListarUsuario.Location = new System.Drawing.Point(404, 78);
            this.btnListarUsuario.Name = "btnListarUsuario";
            this.btnListarUsuario.Size = new System.Drawing.Size(135, 23);
            this.btnListarUsuario.TabIndex = 13;
            this.btnListarUsuario.Text = "Listar/Actualizar";
            this.btnListarUsuario.UseVisualStyleBackColor = true;
            this.btnListarUsuario.Click += new System.EventHandler(this.btnListarUsuario_Click);
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(24, 109);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(764, 329);
            this.dataGridViewEmpleados.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(263, 79);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Cambiar Estado";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(69, 83);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(21, 20);
            this.txtIDUsuario.TabIndex = 10;
            // 
            // lblIngresarID
            // 
            this.lblIngresarID.AutoSize = true;
            this.lblIngresarID.Location = new System.Drawing.Point(21, 63);
            this.lblIngresarID.Name = "lblIngresarID";
            this.lblIngresarID.Size = new System.Drawing.Size(432, 13);
            this.lblIngresarID.TabIndex = 9;
            this.lblIngresarID.Text = "* Para cambiar el estado del usuario ingrese su ID correspondiente / 1. Activo - " +
    "2. Inactivo";
            // 
            // lblEliminarEmpleado
            // 
            this.lblEliminarEmpleado.AutoSize = true;
            this.lblEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblEliminarEmpleado.Location = new System.Drawing.Point(13, 13);
            this.lblEliminarEmpleado.Name = "lblEliminarEmpleado";
            this.lblEliminarEmpleado.Size = new System.Drawing.Size(455, 46);
            this.lblEliminarEmpleado.TabIndex = 8;
            this.lblEliminarEmpleado.Text = "Cambiar Estado Usuario";
            // 
            // cbESTADO
            // 
            this.cbESTADO.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "1. Administrador",
            "2. Recepcionista",
            "3. Chofer",
            "4. Guia Turistico"});
            this.cbESTADO.FormattingEnabled = true;
            this.cbESTADO.Location = new System.Drawing.Point(111, 82);
            this.cbESTADO.Name = "cbESTADO";
            this.cbESTADO.Size = new System.Drawing.Size(146, 21);
            this.cbESTADO.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID";
            // 
            // CambiarEstadoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbESTADO);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnListarUsuario);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.lblIngresarID);
            this.Controls.Add(this.lblEliminarEmpleado);
            this.Name = "CambiarEstadoUsuario";
            this.Text = "EliminarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnVolver;
        protected internal System.Windows.Forms.Button btnListarUsuario;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label lblIngresarID;
        private System.Windows.Forms.Label lblEliminarEmpleado;
        private System.Windows.Forms.ComboBox cbESTADO;
        private System.Windows.Forms.Label label1;
    }
}