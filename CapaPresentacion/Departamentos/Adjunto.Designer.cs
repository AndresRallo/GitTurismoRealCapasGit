
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
            this.gbxMenuAdjuntos = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNomImg = new System.Windows.Forms.Label();
            this.lblNombreDepto = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblIdDepto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargarImg = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblEstadoDepto = new System.Windows.Forms.Label();
            this.cEAdjuntosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDEPARTAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDADJUNTOHABITACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDFECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDTIPOARCHIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDESTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeptos = new System.Windows.Forms.DataGridView();
            this.cEDepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDeptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjuntos)).BeginInit();
            this.gbxMenuAdjuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEAdjuntosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptos)).BeginInit();
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
            this.aDTIPOARCHIVODataGridViewTextBoxColumn,
            this.iDESTADODataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvAdjuntos.DataSource = this.cEAdjuntosBindingSource;
            this.dgvAdjuntos.Location = new System.Drawing.Point(12, 218);
            this.dgvAdjuntos.Name = "dgvAdjuntos";
            this.dgvAdjuntos.Size = new System.Drawing.Size(785, 220);
            this.dgvAdjuntos.TabIndex = 0;
            // 
            // gbxMenuAdjuntos
            // 
            this.gbxMenuAdjuntos.Controls.Add(this.cbxEstado);
            this.gbxMenuAdjuntos.Controls.Add(this.dgvDeptos);
            this.gbxMenuAdjuntos.Controls.Add(this.lblEstadoDepto);
            this.gbxMenuAdjuntos.Controls.Add(this.pictureBox);
            this.gbxMenuAdjuntos.Controls.Add(this.textBox3);
            this.gbxMenuAdjuntos.Controls.Add(this.lblFecha);
            this.gbxMenuAdjuntos.Controls.Add(this.btnCargarImg);
            this.gbxMenuAdjuntos.Controls.Add(this.textBox2);
            this.gbxMenuAdjuntos.Controls.Add(this.lblNomImg);
            this.gbxMenuAdjuntos.Controls.Add(this.lblNombreDepto);
            this.gbxMenuAdjuntos.Controls.Add(this.dateTimePicker1);
            this.gbxMenuAdjuntos.Controls.Add(this.lblIdDepto);
            this.gbxMenuAdjuntos.Controls.Add(this.textBox1);
            this.gbxMenuAdjuntos.Controls.Add(this.btnGuardar);
            this.gbxMenuAdjuntos.Location = new System.Drawing.Point(12, 1);
            this.gbxMenuAdjuntos.Name = "gbxMenuAdjuntos";
            this.gbxMenuAdjuntos.Size = new System.Drawing.Size(763, 211);
            this.gbxMenuAdjuntos.TabIndex = 1;
            this.gbxMenuAdjuntos.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lblNomImg
            // 
            this.lblNomImg.AutoSize = true;
            this.lblNomImg.Location = new System.Drawing.Point(7, 42);
            this.lblNomImg.Name = "lblNomImg";
            this.lblNomImg.Size = new System.Drawing.Size(52, 13);
            this.lblNomImg.TabIndex = 5;
            this.lblNomImg.Text = "Nom. Img";
            // 
            // lblNombreDepto
            // 
            this.lblNombreDepto.AutoSize = true;
            this.lblNombreDepto.Location = new System.Drawing.Point(143, 16);
            this.lblNombreDepto.Name = "lblNombreDepto";
            this.lblNombreDepto.Size = new System.Drawing.Size(79, 13);
            this.lblNombreDepto.TabIndex = 4;
            this.lblNombreDepto.Text = "Nombre Depto:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblIdDepto
            // 
            this.lblIdDepto.AutoSize = true;
            this.lblIdDepto.Location = new System.Drawing.Point(6, 16);
            this.lblIdDepto.Name = "lblIdDepto";
            this.lblIdDepto.Size = new System.Drawing.Size(48, 13);
            this.lblIdDepto.TabIndex = 2;
            this.lblIdDepto.Text = "IdDepto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(362, 96);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar/Editar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCargarImg
            // 
            this.btnCargarImg.Location = new System.Drawing.Point(362, 64);
            this.btnCargarImg.Name = "btnCargarImg";
            this.btnCargarImg.Size = new System.Drawing.Size(94, 23);
            this.btnCargarImg.TabIndex = 7;
            this.btnCargarImg.Text = "Cargar Imágen";
            this.btnCargarImg.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(213, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(65, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 20);
            this.textBox3.TabIndex = 9;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::CapaPresentacion.Properties.Resources.deptoDibujo1;
            this.pictureBox.Location = new System.Drawing.Point(470, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(287, 195);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
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
            // cEAdjuntosBindingSource
            // 
            this.cEAdjuntosBindingSource.DataSource = typeof(CapaEntidad.CEAdjuntos);
            // 
            // iDDEPARTAMENTODataGridViewTextBoxColumn
            // 
            this.iDDEPARTAMENTODataGridViewTextBoxColumn.DataPropertyName = "IDDEPARTAMENTO";
            this.iDDEPARTAMENTODataGridViewTextBoxColumn.HeaderText = "IDDEPARTAMENTO";
            this.iDDEPARTAMENTODataGridViewTextBoxColumn.Name = "iDDEPARTAMENTODataGridViewTextBoxColumn";
            // 
            // nombreDeptoDataGridViewTextBoxColumn
            // 
            this.nombreDeptoDataGridViewTextBoxColumn.DataPropertyName = "nombreDepto";
            this.nombreDeptoDataGridViewTextBoxColumn.HeaderText = "nombreDepto";
            this.nombreDeptoDataGridViewTextBoxColumn.Name = "nombreDeptoDataGridViewTextBoxColumn";
            // 
            // iDADJUNTOHABITACIONDataGridViewTextBoxColumn
            // 
            this.iDADJUNTOHABITACIONDataGridViewTextBoxColumn.DataPropertyName = "IDADJUNTOHABITACION";
            this.iDADJUNTOHABITACIONDataGridViewTextBoxColumn.HeaderText = "IDADJUNTOHABITACION";
            this.iDADJUNTOHABITACIONDataGridViewTextBoxColumn.Name = "iDADJUNTOHABITACIONDataGridViewTextBoxColumn";
            // 
            // aDNOMBREDataGridViewTextBoxColumn
            // 
            this.aDNOMBREDataGridViewTextBoxColumn.DataPropertyName = "AD_NOMBRE";
            this.aDNOMBREDataGridViewTextBoxColumn.HeaderText = "AD_NOMBRE";
            this.aDNOMBREDataGridViewTextBoxColumn.Name = "aDNOMBREDataGridViewTextBoxColumn";
            // 
            // aDFECHACREACIONDataGridViewTextBoxColumn
            // 
            this.aDFECHACREACIONDataGridViewTextBoxColumn.DataPropertyName = "AD_FECHACREACION";
            this.aDFECHACREACIONDataGridViewTextBoxColumn.HeaderText = "AD_FECHACREACION";
            this.aDFECHACREACIONDataGridViewTextBoxColumn.Name = "aDFECHACREACIONDataGridViewTextBoxColumn";
            // 
            // aDTIPOARCHIVODataGridViewTextBoxColumn
            // 
            this.aDTIPOARCHIVODataGridViewTextBoxColumn.DataPropertyName = "AD_TIPOARCHIVO";
            this.aDTIPOARCHIVODataGridViewTextBoxColumn.HeaderText = "AD_TIPOARCHIVO";
            this.aDTIPOARCHIVODataGridViewTextBoxColumn.Name = "aDTIPOARCHIVODataGridViewTextBoxColumn";
            // 
            // iDESTADODataGridViewTextBoxColumn
            // 
            this.iDESTADODataGridViewTextBoxColumn.DataPropertyName = "IDESTADO";
            this.iDESTADODataGridViewTextBoxColumn.HeaderText = "IDESTADO";
            this.iDESTADODataGridViewTextBoxColumn.Name = "iDESTADODataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // dgvDeptos
            // 
            this.dgvDeptos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeptos.AutoGenerateColumns = false;
            this.dgvDeptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDeptoDataGridViewTextBoxColumn,
            this.denombreDataGridViewTextBoxColumn});
            this.dgvDeptos.DataSource = this.cEDepartamentoBindingSource;
            this.dgvDeptos.Location = new System.Drawing.Point(9, 80);
            this.dgvDeptos.Name = "dgvDeptos";
            this.dgvDeptos.Size = new System.Drawing.Size(347, 125);
            this.dgvDeptos.TabIndex = 2;
            // 
            // cEDepartamentoBindingSource
            // 
            this.cEDepartamentoBindingSource.DataSource = typeof(CapaEntidad.CEDepartamento);
            // 
            // idDeptoDataGridViewTextBoxColumn
            // 
            this.idDeptoDataGridViewTextBoxColumn.DataPropertyName = "idDepto";
            this.idDeptoDataGridViewTextBoxColumn.HeaderText = "idDepto";
            this.idDeptoDataGridViewTextBoxColumn.Name = "idDeptoDataGridViewTextBoxColumn";
            // 
            // denombreDataGridViewTextBoxColumn
            // 
            this.denombreDataGridViewTextBoxColumn.DataPropertyName = "de_nombre";
            this.denombreDataGridViewTextBoxColumn.HeaderText = "de_nombre";
            this.denombreDataGridViewTextBoxColumn.Name = "denombreDataGridViewTextBoxColumn";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(362, 138);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(94, 21);
            this.cbxEstado.TabIndex = 12;
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
            this.gbxMenuAdjuntos.ResumeLayout(false);
            this.gbxMenuAdjuntos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEAdjuntosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDepartamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdjuntos;
        private System.Windows.Forms.GroupBox gbxMenuAdjuntos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIdDepto;
        private System.Windows.Forms.Label lblNomImg;
        private System.Windows.Forms.Label lblNombreDepto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCargarImg;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblEstadoDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDEPARTAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDADJUNTOHABITACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDFECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDTIPOARCHIVODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDESTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cEAdjuntosBindingSource;
        private System.Windows.Forms.DataGridView dgvDeptos;
        private System.Windows.Forms.BindingSource cEDepartamentoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDeptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxEstado;
    }
}