
namespace CapaPresentacion
{
    partial class CambiarEstadoEmpleado
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
            this.lblEliminarEmpleado = new System.Windows.Forms.Label();
            this.lblIngresarID = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.btnListarEmpleados = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.cbESTADO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEliminarEmpleado
            // 
            this.lblEliminarEmpleado.AutoSize = true;
            this.lblEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblEliminarEmpleado.Location = new System.Drawing.Point(13, 13);
            this.lblEliminarEmpleado.Name = "lblEliminarEmpleado";
            this.lblEliminarEmpleado.Size = new System.Drawing.Size(497, 46);
            this.lblEliminarEmpleado.TabIndex = 0;
            this.lblEliminarEmpleado.Text = "Cambiar Estado Empleado";
            this.lblEliminarEmpleado.Click += new System.EventHandler(this.lblEliminarEmpleado_Click);
            // 
            // lblIngresarID
            // 
            this.lblIngresarID.AutoSize = true;
            this.lblIngresarID.Location = new System.Drawing.Point(21, 63);
            this.lblIngresarID.Name = "lblIngresarID";
            this.lblIngresarID.Size = new System.Drawing.Size(444, 13);
            this.lblIngresarID.TabIndex = 1;
            this.lblIngresarID.Text = "* Para cambiar el estado del empleado ingrese su ID correspondiente / 1. Activo -" +
    " 2. Inactivo";
            this.lblIngresarID.Click += new System.EventHandler(this.lblIngresarID_Click);
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Location = new System.Drawing.Point(62, 82);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(22, 20);
            this.txtIDEmpleado.TabIndex = 2;
            this.txtIDEmpleado.TextChanged += new System.EventHandler(this.txtIDEmpleado_TextChanged);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.Location = new System.Drawing.Point(263, 82);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(135, 23);
            this.btnCambiarEstado.TabIndex = 3;
            this.btnCambiarEstado.Text = "Cambiar Estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(24, 111);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(764, 327);
            this.dataGridViewEmpleados.TabIndex = 4;
            this.dataGridViewEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellContentClick);
            // 
            // btnListarEmpleados
            // 
            this.btnListarEmpleados.Location = new System.Drawing.Point(404, 82);
            this.btnListarEmpleados.Name = "btnListarEmpleados";
            this.btnListarEmpleados.Size = new System.Drawing.Size(135, 23);
            this.btnListarEmpleados.TabIndex = 5;
            this.btnListarEmpleados.Text = "Listar/Actualizar";
            this.btnListarEmpleados.UseVisualStyleBackColor = true;
            this.btnListarEmpleados.Click += new System.EventHandler(this.btnListarEmpleados_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(653, 82);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(545, 82);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(102, 23);
            this.btnProbarConexion.TabIndex = 7;
            this.btnProbarConexion.Text = "Probar Conexion";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
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
            this.cbESTADO.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID";
            // 
            // CambiarEstadoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbESTADO);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnListarEmpleados);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.txtIDEmpleado);
            this.Controls.Add(this.lblIngresarID);
            this.Controls.Add(this.lblEliminarEmpleado);
            this.Name = "CambiarEstadoEmpleado";
            this.Text = "EliminarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEliminarEmpleado;
        private System.Windows.Forms.Label lblIngresarID;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        protected internal System.Windows.Forms.Button btnListarEmpleados;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.ComboBox cbESTADO;
        private System.Windows.Forms.Label label1;
    }
}