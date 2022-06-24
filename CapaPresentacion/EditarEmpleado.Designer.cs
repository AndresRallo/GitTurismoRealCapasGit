
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.cEEmpleadoDireccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNUM_DIRECCION = new System.Windows.Forms.TextBox();
            this.lblNumDireccion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDIRECCION = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAMATERNO = new System.Windows.Forms.TextBox();
            this.txtAPATERNO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIDDireccion = new System.Windows.Forms.TextBox();
            this.cbIDTipo = new System.Windows.Forms.ComboBox();
            this.lblIDTipo = new System.Windows.Forms.Label();
            this.groupBoxVehiculo = new System.Windows.Forms.GroupBox();
            this.txtAnioVe = new System.Windows.Forms.TextBox();
            this.lblAnioVe = new System.Windows.Forms.Label();
            this.txtMarcaVe = new System.Windows.Forms.TextBox();
            this.lblMarcaVe = new System.Windows.Forms.Label();
            this.txtPatenteVe = new System.Windows.Forms.TextBox();
            this.lblPatenteVe = new System.Windows.Forms.Label();
            this.cbESTADO = new System.Windows.Forms.ComboBox();
            this.lblIDEstado = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.cbComuna = new System.Windows.Forms.ComboBox();
            this.lblComuna = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IDEMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VE_MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VE_ANIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VE_PATENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMNOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMCONTRASEÑA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.de_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.de_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTIPOEMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP_DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ES_DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDREGION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEDESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEEmpleadoDireccionBindingSource)).BeginInit();
            this.groupBoxVehiculo.SuspendLayout();
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
            this.label2.Size = new System.Drawing.Size(328, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "* Para editar empleado ingrese su ID y ID Direccion correspondiente";
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmpleados.AutoGenerateColumns = false;
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEMPLEADO,
            this.VE_MARCA,
            this.VE_ANIO,
            this.VE_PATENTE,
            this.iDDIRECCION,
            this.eMNOMBRE,
            this.eMAPATERNO,
            this.eMAMATERNO,
            this.eMCONTRASEÑA,
            this.de_direccion,
            this.de_numero,
            this.iDTIPOEMPLEADO,
            this.TP_DESCRIPCION,
            this.iDESTADO,
            this.ES_DESCRIPCION,
            this.idcomuna,
            this.cdescripcion,
            this.iDREGION,
            this.rEDESCRIPCION});
            this.dataGridViewEmpleados.DataSource = this.cEEmpleadoDireccionBindingSource;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(290, 215);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(498, 154);
            this.dataGridViewEmpleados.TabIndex = 2;
            this.dataGridViewEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellClick);
            this.dataGridViewEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellDoubleClick);
            this.dataGridViewEmpleados.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridViewEmpleados_KeyUp);
            // 
            // cEEmpleadoDireccionBindingSource
            // 
            this.cEEmpleadoDireccionBindingSource.DataSource = typeof(CapaEntidad.CEEmpleado_Direccion);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(653, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(290, 186);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(150, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar Empleados";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(552, 415);
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
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Enabled = false;
            this.txtIDEmpleado.Location = new System.Drawing.Point(121, 89);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(38, 20);
            this.txtIDEmpleado.TabIndex = 8;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(132, 349);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 23);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.Text = "Editar Empleado";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNUM_DIRECCION
            // 
            this.txtNUM_DIRECCION.Location = new System.Drawing.Point(121, 245);
            this.txtNUM_DIRECCION.Name = "txtNUM_DIRECCION";
            this.txtNUM_DIRECCION.Size = new System.Drawing.Size(146, 20);
            this.txtNUM_DIRECCION.TabIndex = 57;
            // 
            // lblNumDireccion
            // 
            this.lblNumDireccion.AutoSize = true;
            this.lblNumDireccion.Location = new System.Drawing.Point(21, 248);
            this.lblNumDireccion.Name = "lblNumDireccion";
            this.lblNumDireccion.Size = new System.Drawing.Size(44, 13);
            this.lblNumDireccion.TabIndex = 56;
            this.lblNumDireccion.Text = "Número";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(21, 222);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 55;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDIRECCION
            // 
            this.txtDIRECCION.Location = new System.Drawing.Point(121, 219);
            this.txtDIRECCION.Name = "txtDIRECCION";
            this.txtDIRECCION.Size = new System.Drawing.Size(146, 20);
            this.txtDIRECCION.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Apellido Materno";
            // 
            // txtAMATERNO
            // 
            this.txtAMATERNO.Location = new System.Drawing.Point(121, 167);
            this.txtAMATERNO.Name = "txtAMATERNO";
            this.txtAMATERNO.Size = new System.Drawing.Size(146, 20);
            this.txtAMATERNO.TabIndex = 45;
            // 
            // txtAPATERNO
            // 
            this.txtAPATERNO.Location = new System.Drawing.Point(121, 141);
            this.txtAPATERNO.Name = "txtAPATERNO";
            this.txtAPATERNO.Size = new System.Drawing.Size(146, 20);
            this.txtAPATERNO.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Apellido Paterno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Nombre";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(121, 115);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(146, 20);
            this.txtNOMBRE.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "ID Direccion";
            // 
            // txtIDDireccion
            // 
            this.txtIDDireccion.Enabled = false;
            this.txtIDDireccion.Location = new System.Drawing.Point(243, 89);
            this.txtIDDireccion.Name = "txtIDDireccion";
            this.txtIDDireccion.Size = new System.Drawing.Size(24, 20);
            this.txtIDDireccion.TabIndex = 60;
            // 
            // cbIDTipo
            // 
            this.cbIDTipo.FormattingEnabled = true;
            this.cbIDTipo.Items.AddRange(new object[] {
            "1. Administrador",
            "2. Recepcionista",
            "3. Chofer",
            "4. Guia Turistico"});
            this.cbIDTipo.Location = new System.Drawing.Point(121, 271);
            this.cbIDTipo.Name = "cbIDTipo";
            this.cbIDTipo.Size = new System.Drawing.Size(146, 21);
            this.cbIDTipo.TabIndex = 62;
            this.cbIDTipo.SelectedIndexChanged += new System.EventHandler(this.cbIDTipo_SelectedIndexChanged);
            // 
            // lblIDTipo
            // 
            this.lblIDTipo.AutoSize = true;
            this.lblIDTipo.Location = new System.Drawing.Point(21, 274);
            this.lblIDTipo.Name = "lblIDTipo";
            this.lblIDTipo.Size = new System.Drawing.Size(42, 13);
            this.lblIDTipo.TabIndex = 61;
            this.lblIDTipo.Text = "ID Tipo";
            // 
            // groupBoxVehiculo
            // 
            this.groupBoxVehiculo.Controls.Add(this.txtAnioVe);
            this.groupBoxVehiculo.Controls.Add(this.lblAnioVe);
            this.groupBoxVehiculo.Controls.Add(this.txtMarcaVe);
            this.groupBoxVehiculo.Controls.Add(this.lblMarcaVe);
            this.groupBoxVehiculo.Controls.Add(this.txtPatenteVe);
            this.groupBoxVehiculo.Controls.Add(this.lblPatenteVe);
            this.groupBoxVehiculo.Enabled = false;
            this.groupBoxVehiculo.Location = new System.Drawing.Point(545, 70);
            this.groupBoxVehiculo.Name = "groupBoxVehiculo";
            this.groupBoxVehiculo.Size = new System.Drawing.Size(243, 113);
            this.groupBoxVehiculo.TabIndex = 67;
            this.groupBoxVehiculo.TabStop = false;
            this.groupBoxVehiculo.Text = "Editar Vehículo";
            this.groupBoxVehiculo.Visible = false;
            this.groupBoxVehiculo.Enter += new System.EventHandler(this.groupBoxVehiculo_Enter);
            // 
            // txtAnioVe
            // 
            this.txtAnioVe.Location = new System.Drawing.Point(102, 82);
            this.txtAnioVe.Name = "txtAnioVe";
            this.txtAnioVe.Size = new System.Drawing.Size(135, 20);
            this.txtAnioVe.TabIndex = 33;
            // 
            // lblAnioVe
            // 
            this.lblAnioVe.AutoSize = true;
            this.lblAnioVe.Location = new System.Drawing.Point(6, 85);
            this.lblAnioVe.Name = "lblAnioVe";
            this.lblAnioVe.Size = new System.Drawing.Size(72, 13);
            this.lblAnioVe.TabIndex = 32;
            this.lblAnioVe.Text = "Año Vehículo";
            // 
            // txtMarcaVe
            // 
            this.txtMarcaVe.Location = new System.Drawing.Point(102, 56);
            this.txtMarcaVe.Name = "txtMarcaVe";
            this.txtMarcaVe.Size = new System.Drawing.Size(135, 20);
            this.txtMarcaVe.TabIndex = 31;
            // 
            // lblMarcaVe
            // 
            this.lblMarcaVe.AutoSize = true;
            this.lblMarcaVe.Location = new System.Drawing.Point(6, 59);
            this.lblMarcaVe.Name = "lblMarcaVe";
            this.lblMarcaVe.Size = new System.Drawing.Size(83, 13);
            this.lblMarcaVe.TabIndex = 30;
            this.lblMarcaVe.Text = "Marca Vehículo";
            // 
            // txtPatenteVe
            // 
            this.txtPatenteVe.Location = new System.Drawing.Point(102, 27);
            this.txtPatenteVe.Name = "txtPatenteVe";
            this.txtPatenteVe.Size = new System.Drawing.Size(135, 20);
            this.txtPatenteVe.TabIndex = 29;
            // 
            // lblPatenteVe
            // 
            this.lblPatenteVe.AutoSize = true;
            this.lblPatenteVe.Location = new System.Drawing.Point(6, 30);
            this.lblPatenteVe.Name = "lblPatenteVe";
            this.lblPatenteVe.Size = new System.Drawing.Size(90, 13);
            this.lblPatenteVe.TabIndex = 29;
            this.lblPatenteVe.Text = "Patente Vehículo";
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
            this.cbESTADO.Location = new System.Drawing.Point(121, 298);
            this.cbESTADO.Name = "cbESTADO";
            this.cbESTADO.Size = new System.Drawing.Size(146, 21);
            this.cbESTADO.TabIndex = 69;
            // 
            // lblIDEstado
            // 
            this.lblIDEstado.AutoSize = true;
            this.lblIDEstado.Location = new System.Drawing.Point(21, 301);
            this.lblIDEstado.Name = "lblIDEstado";
            this.lblIDEstado.Size = new System.Drawing.Size(40, 13);
            this.lblIDEstado.TabIndex = 68;
            this.lblIDEstado.Text = "Estado";
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(384, 89);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(146, 21);
            this.cbRegion.TabIndex = 73;
            this.cbRegion.SelectedIndexChanged += new System.EventHandler(this.cbRegion_SelectedIndexChanged);
            // 
            // cbComuna
            // 
            this.cbComuna.AutoCompleteCustomSource.AddRange(new string[] {
            "Seleccione Tipo de Empleado",
            "1. Administrador",
            "2. Recepcionista",
            "3. Chofer",
            "4. Guia Turistico"});
            this.cbComuna.FormattingEnabled = true;
            this.cbComuna.Location = new System.Drawing.Point(384, 118);
            this.cbComuna.Name = "cbComuna";
            this.cbComuna.Size = new System.Drawing.Size(146, 21);
            this.cbComuna.TabIndex = 72;
            // 
            // lblComuna
            // 
            this.lblComuna.AutoSize = true;
            this.lblComuna.Location = new System.Drawing.Point(284, 121);
            this.lblComuna.Name = "lblComuna";
            this.lblComuna.Size = new System.Drawing.Size(46, 13);
            this.lblComuna.TabIndex = 71;
            this.lblComuna.Text = "Comuna";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(284, 92);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 70;
            this.lblRegion.Text = "Región";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(121, 193);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(146, 20);
            this.txtPW.TabIndex = 47;
            this.txtPW.TextChanged += new System.EventHandler(this.txtPW_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Contraseña";
            // 
            // IDEMPLEADO
            // 
            this.IDEMPLEADO.DataPropertyName = "IDEMPLEADO";
            this.IDEMPLEADO.HeaderText = "IDEMPLEADO";
            this.IDEMPLEADO.Name = "IDEMPLEADO";
            // 
            // VE_MARCA
            // 
            this.VE_MARCA.DataPropertyName = "VE_MARCA";
            this.VE_MARCA.HeaderText = "VE_MARCA";
            this.VE_MARCA.Name = "VE_MARCA";
            this.VE_MARCA.Visible = false;
            // 
            // VE_ANIO
            // 
            this.VE_ANIO.DataPropertyName = "VE_ANIO";
            this.VE_ANIO.HeaderText = "VE_ANIO";
            this.VE_ANIO.Name = "VE_ANIO";
            this.VE_ANIO.Visible = false;
            // 
            // VE_PATENTE
            // 
            this.VE_PATENTE.DataPropertyName = "VE_PATENTE";
            this.VE_PATENTE.HeaderText = "VE_PATENTE";
            this.VE_PATENTE.Name = "VE_PATENTE";
            this.VE_PATENTE.Visible = false;
            // 
            // iDDIRECCION
            // 
            this.iDDIRECCION.DataPropertyName = "IDDIRECCION";
            this.iDDIRECCION.HeaderText = "IDDIRECCION";
            this.iDDIRECCION.Name = "iDDIRECCION";
            this.iDDIRECCION.Visible = false;
            // 
            // eMNOMBRE
            // 
            this.eMNOMBRE.DataPropertyName = "EM_NOMBRE";
            this.eMNOMBRE.HeaderText = "NOMBRE";
            this.eMNOMBRE.Name = "eMNOMBRE";
            // 
            // eMAPATERNO
            // 
            this.eMAPATERNO.DataPropertyName = "EM_APATERNO";
            this.eMAPATERNO.HeaderText = "APELLIDO PATERNO";
            this.eMAPATERNO.Name = "eMAPATERNO";
            // 
            // eMAMATERNO
            // 
            this.eMAMATERNO.DataPropertyName = "EM_AMATERNO";
            this.eMAMATERNO.HeaderText = "APELLIDO MATERNO";
            this.eMAMATERNO.Name = "eMAMATERNO";
            // 
            // eMCONTRASEÑA
            // 
            this.eMCONTRASEÑA.DataPropertyName = "EM_CONTRASEÑA";
            this.eMCONTRASEÑA.HeaderText = "EM_CONTRASEÑA";
            this.eMCONTRASEÑA.Name = "eMCONTRASEÑA";
            this.eMCONTRASEÑA.Visible = false;
            // 
            // de_direccion
            // 
            this.de_direccion.DataPropertyName = "de_direccion";
            this.de_direccion.HeaderText = "DIRECCIÓN";
            this.de_direccion.Name = "de_direccion";
            // 
            // de_numero
            // 
            this.de_numero.DataPropertyName = "de_numero";
            this.de_numero.HeaderText = "NÚMERO";
            this.de_numero.Name = "de_numero";
            // 
            // iDTIPOEMPLEADO
            // 
            this.iDTIPOEMPLEADO.DataPropertyName = "IDTIPOEMPLEADO";
            this.iDTIPOEMPLEADO.HeaderText = "IDTIPOEMPLEADO";
            this.iDTIPOEMPLEADO.Name = "iDTIPOEMPLEADO";
            this.iDTIPOEMPLEADO.Visible = false;
            // 
            // TP_DESCRIPCION
            // 
            this.TP_DESCRIPCION.DataPropertyName = "TP_DESCRIPCION";
            this.TP_DESCRIPCION.HeaderText = "TIPO EMPLEADO";
            this.TP_DESCRIPCION.Name = "TP_DESCRIPCION";
            // 
            // iDESTADO
            // 
            this.iDESTADO.DataPropertyName = "IDESTADO";
            this.iDESTADO.HeaderText = "IDESTADO";
            this.iDESTADO.Name = "iDESTADO";
            this.iDESTADO.Visible = false;
            // 
            // ES_DESCRIPCION
            // 
            this.ES_DESCRIPCION.DataPropertyName = "ES_DESCRIPCION";
            this.ES_DESCRIPCION.HeaderText = "ESTADO";
            this.ES_DESCRIPCION.Name = "ES_DESCRIPCION";
            // 
            // idcomuna
            // 
            this.idcomuna.DataPropertyName = "id_comuna";
            this.idcomuna.HeaderText = "id_comuna";
            this.idcomuna.Name = "idcomuna";
            this.idcomuna.Visible = false;
            // 
            // cdescripcion
            // 
            this.cdescripcion.DataPropertyName = "c_descripcion";
            this.cdescripcion.HeaderText = "COMUNA";
            this.cdescripcion.Name = "cdescripcion";
            // 
            // iDREGION
            // 
            this.iDREGION.DataPropertyName = "IDREGION";
            this.iDREGION.HeaderText = "IDREGION";
            this.iDREGION.Name = "iDREGION";
            this.iDREGION.Visible = false;
            // 
            // rEDESCRIPCION
            // 
            this.rEDESCRIPCION.DataPropertyName = "RE_DESCRIPCION";
            this.rEDESCRIPCION.HeaderText = "REGIÓN";
            this.rEDESCRIPCION.Name = "rEDESCRIPCION";
            // 
            // EditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.cbComuna);
            this.Controls.Add(this.lblComuna);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cbESTADO);
            this.Controls.Add(this.lblIDEstado);
            this.Controls.Add(this.groupBoxVehiculo);
            this.Controls.Add(this.cbIDTipo);
            this.Controls.Add(this.lblIDTipo);
            this.Controls.Add(this.txtIDDireccion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNUM_DIRECCION);
            this.Controls.Add(this.lblNumDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDIRECCION);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtAMATERNO);
            this.Controls.Add(this.txtAPATERNO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtIDEmpleado);
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
            ((System.ComponentModel.ISupportInitialize)(this.cEEmpleadoDireccionBindingSource)).EndInit();
            this.groupBoxVehiculo.ResumeLayout(false);
            this.groupBoxVehiculo.PerformLayout();
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
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNUM_DIRECCION;
        private System.Windows.Forms.Label lblNumDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDIRECCION;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAMATERNO;
        private System.Windows.Forms.TextBox txtAPATERNO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIDDireccion;
        private System.Windows.Forms.ComboBox cbIDTipo;
        private System.Windows.Forms.Label lblIDTipo;
        private System.Windows.Forms.GroupBox groupBoxVehiculo;
        private System.Windows.Forms.TextBox txtAnioVe;
        private System.Windows.Forms.Label lblAnioVe;
        private System.Windows.Forms.TextBox txtMarcaVe;
        private System.Windows.Forms.Label lblMarcaVe;
        private System.Windows.Forms.TextBox txtPatenteVe;
        private System.Windows.Forms.Label lblPatenteVe;
        private System.Windows.Forms.ComboBox cbESTADO;
        private System.Windows.Forms.Label lblIDEstado;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.ComboBox cbComuna;
        private System.Windows.Forms.Label lblComuna;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource cEEmpleadoDireccionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMRUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAPATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEMPRESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDireccionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dedireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VE_MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VE_ANIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VE_PATENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMNOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMCONTRASEÑA;
        private System.Windows.Forms.DataGridViewTextBoxColumn de_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn de_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTIPOEMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP_DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ES_DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDREGION;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEDESCRIPCION;
    }
}