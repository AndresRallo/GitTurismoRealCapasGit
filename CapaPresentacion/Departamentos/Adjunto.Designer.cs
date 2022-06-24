
namespace CapaPresentacion.Departamentos
{
    partial class Adjunto
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
            this.dgvAdjuntos = new System.Windows.Forms.DataGridView();
            this.cEAdjuntosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxMenuAdjuntos = new System.Windows.Forms.GroupBox();
            this.txtNombreImg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArtas = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.dgvDeptos = new System.Windows.Forms.DataGridView();
            this.id_Depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denombreDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEDeptoListaJoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblEstadoDepto = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.txtRutaImagen = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCargarImg = new System.Windows.Forms.Button();
            this.txtNombreDepto = new System.Windows.Forms.TextBox();
            this.lblRutaImg = new System.Windows.Forms.Label();
            this.lblNombreDepto = new System.Windows.Forms.Label();
            this.dtpFechaImg = new System.Windows.Forms.DateTimePicker();
            this.lblIdDepto = new System.Windows.Forms.Label();
            this.txtIdDepto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cEDepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDEPARTAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDADJUNTOHABITACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDFECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDESTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEAdjuntosBindingSource)).BeginInit();
            this.gbxMenuAdjuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDeptoListaJoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDepartamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdjuntos
            // 
            this.dgvAdjuntos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdjuntos.AutoGenerateColumns = false;
            this.dgvAdjuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdjuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDEPARTAMENTODataGridViewTextBoxColumn,
            this.nombreDeptoDataGridViewTextBoxColumn,
            this.iDADJUNTOHABITACIONDataGridViewTextBoxColumn,
            this.aDNOMBREDataGridViewTextBoxColumn,
            this.aDFECHACREACIONDataGridViewTextBoxColumn,
            this.iDESTADODataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvAdjuntos.DataSource = this.cEAdjuntosBindingSource;
            this.dgvAdjuntos.Location = new System.Drawing.Point(12, 218);
            this.dgvAdjuntos.Name = "dgvAdjuntos";
            this.dgvAdjuntos.Size = new System.Drawing.Size(785, 220);
            this.dgvAdjuntos.TabIndex = 0;
            this.dgvAdjuntos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdjuntos_CellClick);
            this.dgvAdjuntos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvAdjuntos_KeyUp);
            // 
            // cEAdjuntosBindingSource
            // 
            this.cEAdjuntosBindingSource.DataSource = typeof(CapaEntidad.CEAdjuntos);
            // 
            // gbxMenuAdjuntos
            // 
            this.gbxMenuAdjuntos.Controls.Add(this.txtNombreImg);
            this.gbxMenuAdjuntos.Controls.Add(this.label1);
            this.gbxMenuAdjuntos.Controls.Add(this.btnArtas);
            this.gbxMenuAdjuntos.Controls.Add(this.cbxEstado);
            this.gbxMenuAdjuntos.Controls.Add(this.dgvDeptos);
            this.gbxMenuAdjuntos.Controls.Add(this.lblEstadoDepto);
            this.gbxMenuAdjuntos.Controls.Add(this.pictureBoxImage);
            this.gbxMenuAdjuntos.Controls.Add(this.txtRutaImagen);
            this.gbxMenuAdjuntos.Controls.Add(this.lblFecha);
            this.gbxMenuAdjuntos.Controls.Add(this.btnCargarImg);
            this.gbxMenuAdjuntos.Controls.Add(this.txtNombreDepto);
            this.gbxMenuAdjuntos.Controls.Add(this.lblRutaImg);
            this.gbxMenuAdjuntos.Controls.Add(this.lblNombreDepto);
            this.gbxMenuAdjuntos.Controls.Add(this.dtpFechaImg);
            this.gbxMenuAdjuntos.Controls.Add(this.lblIdDepto);
            this.gbxMenuAdjuntos.Controls.Add(this.txtIdDepto);
            this.gbxMenuAdjuntos.Controls.Add(this.btnGuardar);
            this.gbxMenuAdjuntos.Location = new System.Drawing.Point(12, 1);
            this.gbxMenuAdjuntos.Name = "gbxMenuAdjuntos";
            this.gbxMenuAdjuntos.Size = new System.Drawing.Size(763, 211);
            this.gbxMenuAdjuntos.TabIndex = 1;
            this.gbxMenuAdjuntos.TabStop = false;
            // 
            // txtNombreImg
            // 
            this.txtNombreImg.Enabled = false;
            this.txtNombreImg.Location = new System.Drawing.Point(70, 36);
            this.txtNombreImg.Name = "txtNombreImg";
            this.txtNombreImg.Size = new System.Drawing.Size(261, 20);
            this.txtNombreImg.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre Img";
            // 
            // btnArtas
            // 
            this.btnArtas.Location = new System.Drawing.Point(3, 12);
            this.btnArtas.Name = "btnArtas";
            this.btnArtas.Size = new System.Drawing.Size(47, 23);
            this.btnArtas.TabIndex = 13;
            this.btnArtas.Text = "Atrás";
            this.btnArtas.UseVisualStyleBackColor = true;
            this.btnArtas.Click += new System.EventHandler(this.btnArtas_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(362, 138);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(94, 21);
            this.cbxEstado.TabIndex = 12;
            // 
            // dgvDeptos
            // 
            this.dgvDeptos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeptos.AutoGenerateColumns = false;
            this.dgvDeptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Depto,
            this.denombreDepto});
            this.dgvDeptos.DataSource = this.cEDeptoListaJoinBindingSource;
            this.dgvDeptos.Location = new System.Drawing.Point(9, 80);
            this.dgvDeptos.Name = "dgvDeptos";
            this.dgvDeptos.Size = new System.Drawing.Size(347, 125);
            this.dgvDeptos.TabIndex = 2;
            this.dgvDeptos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeptos_CellClick);
            this.dgvDeptos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDeptos_KeyUp);
            // 
            // id_Depto
            // 
            this.id_Depto.DataPropertyName = "idDepto";
            this.id_Depto.HeaderText = "Id Departamento";
            this.id_Depto.Name = "id_Depto";
            // 
            // denombreDepto
            // 
            this.denombreDepto.DataPropertyName = "de_nombre";
            this.denombreDepto.HeaderText = "de_nombre";
            this.denombreDepto.Name = "denombreDepto";
            // 
            // cEDeptoListaJoinBindingSource
            // 
            this.cEDeptoListaJoinBindingSource.DataSource = typeof(CapaEntidad.CEDeptoListaJoin);
            // 
            // lblEstadoDepto
            // 
            this.lblEstadoDepto.AutoSize = true;
            this.lblEstadoDepto.Location = new System.Drawing.Point(410, 122);
            this.lblEstadoDepto.Name = "lblEstadoDepto";
            this.lblEstadoDepto.Size = new System.Drawing.Size(46, 13);
            this.lblEstadoDepto.TabIndex = 11;
            this.lblEstadoDepto.Text = "Estado: ";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Image = global::CapaPresentacion.Properties.Resources.deptoDibujo1;
            this.pictureBoxImage.Location = new System.Drawing.Point(462, 10);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(315, 195);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 10;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.pictureBoxImage_Click);
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Enabled = false;
            this.txtRutaImagen.Location = new System.Drawing.Point(70, 57);
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.Size = new System.Drawing.Size(261, 20);
            this.txtRutaImagen.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(337, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // btnCargarImg
            // 
            this.btnCargarImg.Location = new System.Drawing.Point(362, 64);
            this.btnCargarImg.Name = "btnCargarImg";
            this.btnCargarImg.Size = new System.Drawing.Size(94, 23);
            this.btnCargarImg.TabIndex = 7;
            this.btnCargarImg.Text = "Cargar Imágen";
            this.btnCargarImg.UseVisualStyleBackColor = true;
            this.btnCargarImg.Click += new System.EventHandler(this.btnCargarImg_Click);
            // 
            // txtNombreDepto
            // 
            this.txtNombreDepto.Enabled = false;
            this.txtNombreDepto.Location = new System.Drawing.Point(238, 13);
            this.txtNombreDepto.Name = "txtNombreDepto";
            this.txtNombreDepto.Size = new System.Drawing.Size(217, 20);
            this.txtNombreDepto.TabIndex = 6;
            // 
            // lblRutaImg
            // 
            this.lblRutaImg.AutoSize = true;
            this.lblRutaImg.Location = new System.Drawing.Point(7, 61);
            this.lblRutaImg.Name = "lblRutaImg";
            this.lblRutaImg.Size = new System.Drawing.Size(50, 13);
            this.lblRutaImg.TabIndex = 5;
            this.lblRutaImg.Text = "Ruta Img";
            // 
            // lblNombreDepto
            // 
            this.lblNombreDepto.AutoSize = true;
            this.lblNombreDepto.Location = new System.Drawing.Point(159, 17);
            this.lblNombreDepto.Name = "lblNombreDepto";
            this.lblNombreDepto.Size = new System.Drawing.Size(79, 13);
            this.lblNombreDepto.TabIndex = 4;
            this.lblNombreDepto.Text = "Nombre Depto:";
            // 
            // dtpFechaImg
            // 
            this.dtpFechaImg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaImg.Location = new System.Drawing.Point(380, 38);
            this.dtpFechaImg.Name = "dtpFechaImg";
            this.dtpFechaImg.Size = new System.Drawing.Size(75, 20);
            this.dtpFechaImg.TabIndex = 3;
            // 
            // lblIdDepto
            // 
            this.lblIdDepto.AutoSize = true;
            this.lblIdDepto.Location = new System.Drawing.Point(56, 17);
            this.lblIdDepto.Name = "lblIdDepto";
            this.lblIdDepto.Size = new System.Drawing.Size(48, 13);
            this.lblIdDepto.TabIndex = 2;
            this.lblIdDepto.Text = "IdDepto:";
            // 
            // txtIdDepto
            // 
            this.txtIdDepto.Enabled = false;
            this.txtIdDepto.Location = new System.Drawing.Point(104, 13);
            this.txtIdDepto.Name = "txtIdDepto";
            this.txtIdDepto.Size = new System.Drawing.Size(47, 20);
            this.txtIdDepto.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(362, 96);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar/Editar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cEDepartamentoBindingSource
            // 
            this.cEDepartamentoBindingSource.DataSource = typeof(CapaEntidad.CEDepartamento);
            // 
            // iDDEPARTAMENTODataGridViewTextBoxColumn
            // 
            this.iDDEPARTAMENTODataGridViewTextBoxColumn.DataPropertyName = "IDDEPARTAMENTO";
            this.iDDEPARTAMENTODataGridViewTextBoxColumn.HeaderText = "Id Depto";
            this.iDDEPARTAMENTODataGridViewTextBoxColumn.Name = "iDDEPARTAMENTODataGridViewTextBoxColumn";
            // 
            // nombreDeptoDataGridViewTextBoxColumn
            // 
            this.nombreDeptoDataGridViewTextBoxColumn.DataPropertyName = "nombreDepto";
            this.nombreDeptoDataGridViewTextBoxColumn.HeaderText = "Nombre Departamento";
            this.nombreDeptoDataGridViewTextBoxColumn.Name = "nombreDeptoDataGridViewTextBoxColumn";
            // 
            // iDADJUNTOHABITACIONDataGridViewTextBoxColumn
            // 
            this.iDADJUNTOHABITACIONDataGridViewTextBoxColumn.DataPropertyName = "IDADJUNTOHABITACION";
            this.iDADJUNTOHABITACIONDataGridViewTextBoxColumn.HeaderText = "ID  Adjunto";
            this.iDADJUNTOHABITACIONDataGridViewTextBoxColumn.Name = "iDADJUNTOHABITACIONDataGridViewTextBoxColumn";
            // 
            // aDNOMBREDataGridViewTextBoxColumn
            // 
            this.aDNOMBREDataGridViewTextBoxColumn.DataPropertyName = "AD_NOMBRE";
            this.aDNOMBREDataGridViewTextBoxColumn.HeaderText = "Nombre Imagen";
            this.aDNOMBREDataGridViewTextBoxColumn.Name = "aDNOMBREDataGridViewTextBoxColumn";
            // 
            // aDFECHACREACIONDataGridViewTextBoxColumn
            // 
            this.aDFECHACREACIONDataGridViewTextBoxColumn.DataPropertyName = "AD_FECHACREACION";
            this.aDFECHACREACIONDataGridViewTextBoxColumn.HeaderText = "Fecha Creación";
            this.aDFECHACREACIONDataGridViewTextBoxColumn.Name = "aDFECHACREACIONDataGridViewTextBoxColumn";
            // 
            // iDESTADODataGridViewTextBoxColumn
            // 
            this.iDESTADODataGridViewTextBoxColumn.DataPropertyName = "IDESTADO";
            this.iDESTADODataGridViewTextBoxColumn.HeaderText = "Id_estado";
            this.iDESTADODataGridViewTextBoxColumn.Name = "iDESTADODataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // Adjunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxMenuAdjuntos);
            this.Controls.Add(this.dgvAdjuntos);
            this.Name = "Adjunto";
            this.Text = "Adjunto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEAdjuntosBindingSource)).EndInit();
            this.gbxMenuAdjuntos.ResumeLayout(false);
            this.gbxMenuAdjuntos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDeptoListaJoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDepartamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdjuntos;
        private System.Windows.Forms.GroupBox gbxMenuAdjuntos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtIdDepto;
        private System.Windows.Forms.Label lblIdDepto;
        private System.Windows.Forms.Label lblRutaImg;
        private System.Windows.Forms.Label lblNombreDepto;
        private System.Windows.Forms.DateTimePicker dtpFechaImg;
        private System.Windows.Forms.TextBox txtNombreDepto;
        private System.Windows.Forms.Button btnCargarImg;
        private System.Windows.Forms.TextBox txtRutaImagen;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label lblEstadoDepto;
        private System.Windows.Forms.BindingSource cEAdjuntosBindingSource;
        private System.Windows.Forms.DataGridView dgvDeptos;
        private System.Windows.Forms.BindingSource cEDepartamentoBindingSource;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn denombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn de_nombre;
        private System.Windows.Forms.BindingSource cEDeptoListaJoinBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDeptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Depto;
        private System.Windows.Forms.DataGridViewTextBoxColumn denombreDepto;
        private System.Windows.Forms.Button btnArtas;
        private System.Windows.Forms.TextBox txtNombreImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDEPARTAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDADJUNTOHABITACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDFECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDESTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}