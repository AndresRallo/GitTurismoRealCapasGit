
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
            this.components = new System.ComponentModel.Container();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListarUsuario = new System.Windows.Forms.Button();
            this.dgvUSER = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.lblIngresarID = new System.Windows.Forms.Label();
            this.lblEliminarEmpleado = new System.Windows.Forms.Label();
            this.cbESTADO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iDUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSRUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSAPATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSAMATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSTELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSCONTRASEÑADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDESTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEUSERESTADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEUSERESTADOBindingSource)).BeginInit();
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
            // dgvUSER
            // 
            this.dgvUSER.AutoGenerateColumns = false;
            this.dgvUSER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUSER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUSUARIODataGridViewTextBoxColumn,
            this.uSRUTDataGridViewTextBoxColumn,
            this.uSDVDataGridViewTextBoxColumn,
            this.uSNOMBREDataGridViewTextBoxColumn,
            this.uSAPATERNODataGridViewTextBoxColumn,
            this.uSAMATERNODataGridViewTextBoxColumn,
            this.uSTELEFONODataGridViewTextBoxColumn,
            this.uSEMAILDataGridViewTextBoxColumn,
            this.uSCONTRASEÑADataGridViewTextBoxColumn,
            this.iDESTADODataGridViewTextBoxColumn,
            this.eSDESCRIPCIONDataGridViewTextBoxColumn});
            this.dgvUSER.DataSource = this.cEUSERESTADOBindingSource;
            this.dgvUSER.Location = new System.Drawing.Point(24, 109);
            this.dgvUSER.Name = "dgvUSER";
            this.dgvUSER.Size = new System.Drawing.Size(764, 329);
            this.dgvUSER.TabIndex = 12;
            this.dgvUSER.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUSER_CellClick);
            this.dgvUSER.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvUSER_KeyUp);
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
            this.txtIDUsuario.Enabled = false;
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
            // iDUSUARIODataGridViewTextBoxColumn
            // 
            this.iDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "IDUSUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.HeaderText = "IDUSUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.Name = "iDUSUARIODataGridViewTextBoxColumn";
            // 
            // uSRUTDataGridViewTextBoxColumn
            // 
            this.uSRUTDataGridViewTextBoxColumn.DataPropertyName = "US_RUT";
            this.uSRUTDataGridViewTextBoxColumn.HeaderText = "US_RUT";
            this.uSRUTDataGridViewTextBoxColumn.Name = "uSRUTDataGridViewTextBoxColumn";
            // 
            // uSDVDataGridViewTextBoxColumn
            // 
            this.uSDVDataGridViewTextBoxColumn.DataPropertyName = "US_DV";
            this.uSDVDataGridViewTextBoxColumn.HeaderText = "US_DV";
            this.uSDVDataGridViewTextBoxColumn.Name = "uSDVDataGridViewTextBoxColumn";
            // 
            // uSNOMBREDataGridViewTextBoxColumn
            // 
            this.uSNOMBREDataGridViewTextBoxColumn.DataPropertyName = "US_NOMBRE";
            this.uSNOMBREDataGridViewTextBoxColumn.HeaderText = "US_NOMBRE";
            this.uSNOMBREDataGridViewTextBoxColumn.Name = "uSNOMBREDataGridViewTextBoxColumn";
            // 
            // uSAPATERNODataGridViewTextBoxColumn
            // 
            this.uSAPATERNODataGridViewTextBoxColumn.DataPropertyName = "US_APATERNO";
            this.uSAPATERNODataGridViewTextBoxColumn.HeaderText = "US_APATERNO";
            this.uSAPATERNODataGridViewTextBoxColumn.Name = "uSAPATERNODataGridViewTextBoxColumn";
            // 
            // uSAMATERNODataGridViewTextBoxColumn
            // 
            this.uSAMATERNODataGridViewTextBoxColumn.DataPropertyName = "US_AMATERNO";
            this.uSAMATERNODataGridViewTextBoxColumn.HeaderText = "US_AMATERNO";
            this.uSAMATERNODataGridViewTextBoxColumn.Name = "uSAMATERNODataGridViewTextBoxColumn";
            // 
            // uSTELEFONODataGridViewTextBoxColumn
            // 
            this.uSTELEFONODataGridViewTextBoxColumn.DataPropertyName = "US_TELEFONO";
            this.uSTELEFONODataGridViewTextBoxColumn.HeaderText = "US_TELEFONO";
            this.uSTELEFONODataGridViewTextBoxColumn.Name = "uSTELEFONODataGridViewTextBoxColumn";
            // 
            // uSEMAILDataGridViewTextBoxColumn
            // 
            this.uSEMAILDataGridViewTextBoxColumn.DataPropertyName = "US_EMAIL";
            this.uSEMAILDataGridViewTextBoxColumn.HeaderText = "US_EMAIL";
            this.uSEMAILDataGridViewTextBoxColumn.Name = "uSEMAILDataGridViewTextBoxColumn";
            // 
            // uSCONTRASEÑADataGridViewTextBoxColumn
            // 
            this.uSCONTRASEÑADataGridViewTextBoxColumn.DataPropertyName = "US_CONTRASEÑA";
            this.uSCONTRASEÑADataGridViewTextBoxColumn.HeaderText = "US_CONTRASEÑA";
            this.uSCONTRASEÑADataGridViewTextBoxColumn.Name = "uSCONTRASEÑADataGridViewTextBoxColumn";
            // 
            // iDESTADODataGridViewTextBoxColumn
            // 
            this.iDESTADODataGridViewTextBoxColumn.DataPropertyName = "IDESTADO";
            this.iDESTADODataGridViewTextBoxColumn.HeaderText = "IDESTADO";
            this.iDESTADODataGridViewTextBoxColumn.Name = "iDESTADODataGridViewTextBoxColumn";
            // 
            // eSDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.eSDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "ES_DESCRIPCION";
            this.eSDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "ES_DESCRIPCION";
            this.eSDESCRIPCIONDataGridViewTextBoxColumn.Name = "eSDESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // cEUSERESTADOBindingSource
            // 
            this.cEUSERESTADOBindingSource.DataSource = typeof(CapaEntidad.CEUSER_ESTADO);
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
            this.Controls.Add(this.dgvUSER);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.lblIngresarID);
            this.Controls.Add(this.lblEliminarEmpleado);
            this.Name = "CambiarEstadoUsuario";
            this.Text = "EliminarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEUSERESTADOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnVolver;
        protected internal System.Windows.Forms.Button btnListarUsuario;
        private System.Windows.Forms.DataGridView dgvUSER;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label lblIngresarID;
        private System.Windows.Forms.Label lblEliminarEmpleado;
        private System.Windows.Forms.ComboBox cbESTADO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSRUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSAPATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSAMATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSTELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSCONTRASEÑADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDESTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSDESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cEUSERESTADOBindingSource;
    }
}