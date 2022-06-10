
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
            this.components = new System.ComponentModel.Container();
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
            this.iDEMPLEADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMRUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAPATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAMATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMCONTRASEÑADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEMPRESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTIPOEMPLEADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDESTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDireccionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dedireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDREGIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEEmpleadoDireccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEEmpleadoDireccionBindingSource)).BeginInit();
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
            this.txtIDEmpleado.Enabled = false;
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
            this.dataGridViewEmpleados.AutoGenerateColumns = false;
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEMPLEADODataGridViewTextBoxColumn,
            this.eMRUTDataGridViewTextBoxColumn,
            this.eMDVDataGridViewTextBoxColumn,
            this.eMNOMBREDataGridViewTextBoxColumn,
            this.eMAPATERNODataGridViewTextBoxColumn,
            this.eMAMATERNODataGridViewTextBoxColumn,
            this.eMEMAILDataGridViewTextBoxColumn,
            this.eMCONTRASEÑADataGridViewTextBoxColumn,
            this.iDEMPRESADataGridViewTextBoxColumn,
            this.iDTIPOEMPLEADODataGridViewTextBoxColumn,
            this.iDESTADODataGridViewTextBoxColumn,
            this.iDDIRECCIONDataGridViewTextBoxColumn,
            this.idDireccionDataGridViewTextBoxColumn1,
            this.dedireccionDataGridViewTextBoxColumn,
            this.denumeroDataGridViewTextBoxColumn,
            this.idcomunaDataGridViewTextBoxColumn,
            this.cdescripcionDataGridViewTextBoxColumn,
            this.iDREGIONDataGridViewTextBoxColumn,
            this.rEDESCRIPCIONDataGridViewTextBoxColumn,
            this.tPDESCRIPCIONDataGridViewTextBoxColumn,
            this.eSDESCRIPCIONDataGridViewTextBoxColumn});
            this.dataGridViewEmpleados.DataSource = this.cEEmpleadoDireccionBindingSource;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(24, 111);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(764, 327);
            this.dataGridViewEmpleados.TabIndex = 4;
            this.dataGridViewEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellClick);
            this.dataGridViewEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellContentClick);
            this.dataGridViewEmpleados.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridViewEmpleados_KeyUp);
            // 
            // btnListarEmpleados
            // 
            this.btnListarEmpleados.Location = new System.Drawing.Point(404, 82);
            this.btnListarEmpleados.Name = "btnListarEmpleados";
            this.btnListarEmpleados.Size = new System.Drawing.Size(135, 23);
            this.btnListarEmpleados.TabIndex = 5;
            this.btnListarEmpleados.Text = "Actualizar";
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
            // iDEMPLEADODataGridViewTextBoxColumn
            // 
            this.iDEMPLEADODataGridViewTextBoxColumn.DataPropertyName = "IDEMPLEADO";
            this.iDEMPLEADODataGridViewTextBoxColumn.HeaderText = "IDEMPLEADO";
            this.iDEMPLEADODataGridViewTextBoxColumn.Name = "iDEMPLEADODataGridViewTextBoxColumn";
            // 
            // eMRUTDataGridViewTextBoxColumn
            // 
            this.eMRUTDataGridViewTextBoxColumn.DataPropertyName = "EM_RUT";
            this.eMRUTDataGridViewTextBoxColumn.HeaderText = "EM_RUT";
            this.eMRUTDataGridViewTextBoxColumn.Name = "eMRUTDataGridViewTextBoxColumn";
            // 
            // eMDVDataGridViewTextBoxColumn
            // 
            this.eMDVDataGridViewTextBoxColumn.DataPropertyName = "EM_DV";
            this.eMDVDataGridViewTextBoxColumn.HeaderText = "EM_DV";
            this.eMDVDataGridViewTextBoxColumn.Name = "eMDVDataGridViewTextBoxColumn";
            // 
            // eMNOMBREDataGridViewTextBoxColumn
            // 
            this.eMNOMBREDataGridViewTextBoxColumn.DataPropertyName = "EM_NOMBRE";
            this.eMNOMBREDataGridViewTextBoxColumn.HeaderText = "EM_NOMBRE";
            this.eMNOMBREDataGridViewTextBoxColumn.Name = "eMNOMBREDataGridViewTextBoxColumn";
            // 
            // eMAPATERNODataGridViewTextBoxColumn
            // 
            this.eMAPATERNODataGridViewTextBoxColumn.DataPropertyName = "EM_APATERNO";
            this.eMAPATERNODataGridViewTextBoxColumn.HeaderText = "EM_APATERNO";
            this.eMAPATERNODataGridViewTextBoxColumn.Name = "eMAPATERNODataGridViewTextBoxColumn";
            // 
            // eMAMATERNODataGridViewTextBoxColumn
            // 
            this.eMAMATERNODataGridViewTextBoxColumn.DataPropertyName = "EM_AMATERNO";
            this.eMAMATERNODataGridViewTextBoxColumn.HeaderText = "EM_AMATERNO";
            this.eMAMATERNODataGridViewTextBoxColumn.Name = "eMAMATERNODataGridViewTextBoxColumn";
            // 
            // eMEMAILDataGridViewTextBoxColumn
            // 
            this.eMEMAILDataGridViewTextBoxColumn.DataPropertyName = "EM_EMAIL";
            this.eMEMAILDataGridViewTextBoxColumn.HeaderText = "EM_EMAIL";
            this.eMEMAILDataGridViewTextBoxColumn.Name = "eMEMAILDataGridViewTextBoxColumn";
            // 
            // eMCONTRASEÑADataGridViewTextBoxColumn
            // 
            this.eMCONTRASEÑADataGridViewTextBoxColumn.DataPropertyName = "EM_CONTRASEÑA";
            this.eMCONTRASEÑADataGridViewTextBoxColumn.HeaderText = "EM_CONTRASEÑA";
            this.eMCONTRASEÑADataGridViewTextBoxColumn.Name = "eMCONTRASEÑADataGridViewTextBoxColumn";
            // 
            // iDEMPRESADataGridViewTextBoxColumn
            // 
            this.iDEMPRESADataGridViewTextBoxColumn.DataPropertyName = "IDEMPRESA";
            this.iDEMPRESADataGridViewTextBoxColumn.HeaderText = "IDEMPRESA";
            this.iDEMPRESADataGridViewTextBoxColumn.Name = "iDEMPRESADataGridViewTextBoxColumn";
            // 
            // iDTIPOEMPLEADODataGridViewTextBoxColumn
            // 
            this.iDTIPOEMPLEADODataGridViewTextBoxColumn.DataPropertyName = "IDTIPOEMPLEADO";
            this.iDTIPOEMPLEADODataGridViewTextBoxColumn.HeaderText = "IDTIPOEMPLEADO";
            this.iDTIPOEMPLEADODataGridViewTextBoxColumn.Name = "iDTIPOEMPLEADODataGridViewTextBoxColumn";
            // 
            // iDESTADODataGridViewTextBoxColumn
            // 
            this.iDESTADODataGridViewTextBoxColumn.DataPropertyName = "IDESTADO";
            this.iDESTADODataGridViewTextBoxColumn.HeaderText = "IDESTADO";
            this.iDESTADODataGridViewTextBoxColumn.Name = "iDESTADODataGridViewTextBoxColumn";
            // 
            // iDDIRECCIONDataGridViewTextBoxColumn
            // 
            this.iDDIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "IDDIRECCION";
            this.iDDIRECCIONDataGridViewTextBoxColumn.HeaderText = "IDDIRECCION";
            this.iDDIRECCIONDataGridViewTextBoxColumn.Name = "iDDIRECCIONDataGridViewTextBoxColumn";
            // 
            // idDireccionDataGridViewTextBoxColumn1
            // 
            this.idDireccionDataGridViewTextBoxColumn1.DataPropertyName = "idDireccion";
            this.idDireccionDataGridViewTextBoxColumn1.HeaderText = "idDireccion";
            this.idDireccionDataGridViewTextBoxColumn1.Name = "idDireccionDataGridViewTextBoxColumn1";
            // 
            // dedireccionDataGridViewTextBoxColumn
            // 
            this.dedireccionDataGridViewTextBoxColumn.DataPropertyName = "de_direccion";
            this.dedireccionDataGridViewTextBoxColumn.HeaderText = "de_direccion";
            this.dedireccionDataGridViewTextBoxColumn.Name = "dedireccionDataGridViewTextBoxColumn";
            // 
            // denumeroDataGridViewTextBoxColumn
            // 
            this.denumeroDataGridViewTextBoxColumn.DataPropertyName = "de_numero";
            this.denumeroDataGridViewTextBoxColumn.HeaderText = "de_numero";
            this.denumeroDataGridViewTextBoxColumn.Name = "denumeroDataGridViewTextBoxColumn";
            // 
            // idcomunaDataGridViewTextBoxColumn
            // 
            this.idcomunaDataGridViewTextBoxColumn.DataPropertyName = "id_comuna";
            this.idcomunaDataGridViewTextBoxColumn.HeaderText = "id_comuna";
            this.idcomunaDataGridViewTextBoxColumn.Name = "idcomunaDataGridViewTextBoxColumn";
            // 
            // cdescripcionDataGridViewTextBoxColumn
            // 
            this.cdescripcionDataGridViewTextBoxColumn.DataPropertyName = "c_descripcion";
            this.cdescripcionDataGridViewTextBoxColumn.HeaderText = "c_descripcion";
            this.cdescripcionDataGridViewTextBoxColumn.Name = "cdescripcionDataGridViewTextBoxColumn";
            // 
            // iDREGIONDataGridViewTextBoxColumn
            // 
            this.iDREGIONDataGridViewTextBoxColumn.DataPropertyName = "IDREGION";
            this.iDREGIONDataGridViewTextBoxColumn.HeaderText = "IDREGION";
            this.iDREGIONDataGridViewTextBoxColumn.Name = "iDREGIONDataGridViewTextBoxColumn";
            // 
            // rEDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.rEDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "RE_DESCRIPCION";
            this.rEDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "RE_DESCRIPCION";
            this.rEDESCRIPCIONDataGridViewTextBoxColumn.Name = "rEDESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // tPDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.tPDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "TP_DESCRIPCION";
            this.tPDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "TP_DESCRIPCION";
            this.tPDESCRIPCIONDataGridViewTextBoxColumn.Name = "tPDESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // eSDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.eSDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "ES_DESCRIPCION";
            this.eSDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "ES_DESCRIPCION";
            this.eSDESCRIPCIONDataGridViewTextBoxColumn.Name = "eSDESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // cEEmpleadoDireccionBindingSource
            // 
            this.cEEmpleadoDireccionBindingSource.DataSource = typeof(CapaEntidad.CEEmpleado_Direccion);
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
            ((System.ComponentModel.ISupportInitialize)(this.cEEmpleadoDireccionBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEMPLEADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMRUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAPATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAMATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMCONTRASEÑADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEMPRESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTIPOEMPLEADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDESTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDireccionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dedireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDREGIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEDESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPDESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSDESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cEEmpleadoDireccionBindingSource;
    }
}