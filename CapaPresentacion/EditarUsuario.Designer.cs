
namespace CapaPresentacion
{
    partial class EditarUsuario
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblAMaterno = new System.Windows.Forms.Label();
            this.lblAPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvUSER = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbESTADO = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ES_DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cEUSERESTADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cEUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEUSERESTADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(24, 415);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 23);
            this.btnEditar.TabIndex = 62;
            this.btnEditar.Text = "Editar Usuario";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(111, 219);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(100, 20);
            this.txtContrasenia.TabIndex = 57;
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(111, 193);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtAMaterno.TabIndex = 55;
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(111, 167);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(100, 20);
            this.txtAPaterno.TabIndex = 54;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(111, 141);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 53;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(21, 222);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenia.TabIndex = 48;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblAMaterno
            // 
            this.lblAMaterno.AutoSize = true;
            this.lblAMaterno.Location = new System.Drawing.Point(21, 196);
            this.lblAMaterno.Name = "lblAMaterno";
            this.lblAMaterno.Size = new System.Drawing.Size(86, 13);
            this.lblAMaterno.TabIndex = 46;
            this.lblAMaterno.Text = "Apellido Materno";
            // 
            // lblAPaterno
            // 
            this.lblAPaterno.AutoSize = true;
            this.lblAPaterno.Location = new System.Drawing.Point(21, 170);
            this.lblAPaterno.Name = "lblAPaterno";
            this.lblAPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblAPaterno.TabIndex = 45;
            this.lblAPaterno.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 144);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Nombre";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Enabled = false;
            this.txtIDUsuario.Location = new System.Drawing.Point(111, 89);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIDUsuario.TabIndex = 40;
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Location = new System.Drawing.Point(21, 92);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(21, 13);
            this.lblIDEmpleado.TabIndex = 38;
            this.lblIDEmpleado.Text = "ID ";
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(396, 58);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(95, 23);
            this.btnProbarConexion.TabIndex = 37;
            this.btnProbarConexion.Text = "Probar Conexion";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(497, 58);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(150, 23);
            this.btnListar.TabIndex = 36;
            this.btnListar.Text = "Actualizar Lista";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(653, 58);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 23);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            this.ES_DESCRIPCION});
            this.dgvUSER.DataSource = this.cEUSERESTADOBindingSource;
            this.dgvUSER.Location = new System.Drawing.Point(334, 92);
            this.dgvUSER.Name = "dgvUSER";
            this.dgvUSER.Size = new System.Drawing.Size(454, 346);
            this.dgvUSER.TabIndex = 34;
            this.dgvUSER.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUSER_CellClick);
            this.dgvUSER.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvUSER_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "* Para editar usuario ingrese su ID correspondiente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 46);
            this.label1.TabIndex = 32;
            this.label1.Text = "Editar Usuario";
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
            this.cbESTADO.Location = new System.Drawing.Point(111, 245);
            this.cbESTADO.Name = "cbESTADO";
            this.cbESTADO.Size = new System.Drawing.Size(100, 21);
            this.cbESTADO.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "ID Estado";
            // 
            // ES_DESCRIPCION
            // 
            this.ES_DESCRIPCION.DataPropertyName = "ES_DESCRIPCION";
            this.ES_DESCRIPCION.HeaderText = "ES_DESCRIPCION";
            this.ES_DESCRIPCION.Name = "ES_DESCRIPCION";
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
            // cEUSERESTADOBindingSource
            // 
            this.cEUSERESTADOBindingSource.DataSource = typeof(CapaEntidad.CEUSER_ESTADO);
            // 
            // cEUsuarioBindingSource
            // 
            this.cEUsuarioBindingSource.DataSource = typeof(CapaEntidad.CEUsuario);
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbESTADO);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtAMaterno);
            this.Controls.Add(this.txtAPaterno);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblAMaterno);
            this.Controls.Add(this.lblAPaterno);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.lblIDEmpleado);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvUSER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarUsuario";
            this.Text = "EditarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEUSERESTADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtAMaterno;
        private System.Windows.Forms.TextBox txtAPaterno;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblAMaterno;
        private System.Windows.Forms.Label lblAPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label lblIDEmpleado;
        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvUSER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbESTADO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource cEUsuarioBindingSource;
        private System.Windows.Forms.BindingSource cEUSERESTADOBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ES_DESCRIPCION;
    }
}