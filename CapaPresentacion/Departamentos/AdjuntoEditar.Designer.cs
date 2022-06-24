
namespace CapaPresentacion.Departamentos
{
    partial class AdjuntoEditar
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
            this.txtIdAdjunto = new System.Windows.Forms.TextBox();
            this.txtNombreDepto = new System.Windows.Forms.TextBox();
            this.lblIdAdjunto = new System.Windows.Forms.Label();
            this.lblNombreDepto = new System.Windows.Forms.Label();
            this.lblIdDepto = new System.Windows.Forms.Label();
            this.txtIdDepto = new System.Windows.Forms.TextBox();
            this.btnEliminarAdjunto = new System.Windows.Forms.Button();
            this.btnArtas = new System.Windows.Forms.Button();
            this.gbxMenuAdjuntos = new System.Windows.Forms.GroupBox();
            this.dgvDeptos = new System.Windows.Forms.DataGridView();
            this.dgvAdjuntos = new System.Windows.Forms.DataGridView();
            this.id_Depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denombreDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEDeptoListaJoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.cEAdjuntosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cEDepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDEPARTAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDADJUNTOHABITACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDFECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxMenuAdjuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDeptoListaJoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEAdjuntosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDepartamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdAdjunto
            // 
            this.txtIdAdjunto.Enabled = false;
            this.txtIdAdjunto.Location = new System.Drawing.Point(370, 146);
            this.txtIdAdjunto.Name = "txtIdAdjunto";
            this.txtIdAdjunto.Size = new System.Drawing.Size(51, 20);
            this.txtIdAdjunto.TabIndex = 9;
            // 
            // txtNombreDepto
            // 
            this.txtNombreDepto.Enabled = false;
            this.txtNombreDepto.Location = new System.Drawing.Point(238, 13);
            this.txtNombreDepto.Name = "txtNombreDepto";
            this.txtNombreDepto.Size = new System.Drawing.Size(217, 20);
            this.txtNombreDepto.TabIndex = 6;
            // 
            // lblIdAdjunto
            // 
            this.lblIdAdjunto.AutoSize = true;
            this.lblIdAdjunto.Location = new System.Drawing.Point(309, 149);
            this.lblIdAdjunto.Name = "lblIdAdjunto";
            this.lblIdAdjunto.Size = new System.Drawing.Size(55, 13);
            this.lblIdAdjunto.TabIndex = 5;
            this.lblIdAdjunto.Text = "Id Adjunto";
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
            // btnEliminarAdjunto
            // 
            this.btnEliminarAdjunto.Location = new System.Drawing.Point(312, 172);
            this.btnEliminarAdjunto.Name = "btnEliminarAdjunto";
            this.btnEliminarAdjunto.Size = new System.Drawing.Size(109, 23);
            this.btnEliminarAdjunto.TabIndex = 0;
            this.btnEliminarAdjunto.Text = "Eliminar Adjunto";
            this.btnEliminarAdjunto.UseVisualStyleBackColor = true;
            this.btnEliminarAdjunto.Click += new System.EventHandler(this.btnEliminarAdjunto_Click);
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
            // gbxMenuAdjuntos
            // 
            this.gbxMenuAdjuntos.Controls.Add(this.btnArtas);
            this.gbxMenuAdjuntos.Controls.Add(this.dgvDeptos);
            this.gbxMenuAdjuntos.Controls.Add(this.pictureBoxImage);
            this.gbxMenuAdjuntos.Controls.Add(this.txtIdAdjunto);
            this.gbxMenuAdjuntos.Controls.Add(this.txtNombreDepto);
            this.gbxMenuAdjuntos.Controls.Add(this.lblIdAdjunto);
            this.gbxMenuAdjuntos.Controls.Add(this.lblNombreDepto);
            this.gbxMenuAdjuntos.Controls.Add(this.lblIdDepto);
            this.gbxMenuAdjuntos.Controls.Add(this.txtIdDepto);
            this.gbxMenuAdjuntos.Controls.Add(this.btnEliminarAdjunto);
            this.gbxMenuAdjuntos.Location = new System.Drawing.Point(8, 7);
            this.gbxMenuAdjuntos.Name = "gbxMenuAdjuntos";
            this.gbxMenuAdjuntos.Size = new System.Drawing.Size(763, 211);
            this.gbxMenuAdjuntos.TabIndex = 3;
            this.gbxMenuAdjuntos.TabStop = false;
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
            this.dgvDeptos.Size = new System.Drawing.Size(287, 125);
            this.dgvDeptos.TabIndex = 2;
            this.dgvDeptos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeptos_CellClick);
            this.dgvDeptos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDeptos_KeyUp);
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
            this.aDFECHACREACIONDataGridViewTextBoxColumn});
            this.dgvAdjuntos.DataSource = this.cEAdjuntosBindingSource;
            this.dgvAdjuntos.Location = new System.Drawing.Point(8, 224);
            this.dgvAdjuntos.Name = "dgvAdjuntos";
            this.dgvAdjuntos.Size = new System.Drawing.Size(785, 220);
            this.dgvAdjuntos.TabIndex = 2;
            this.dgvAdjuntos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdjuntos_CellClick);
            this.dgvAdjuntos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvAdjuntos_KeyUp);
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
            // pictureBoxImage
            // 
            this.pictureBoxImage.Image = global::CapaPresentacion.Properties.Resources.deptoDibujo1;
            this.pictureBoxImage.Location = new System.Drawing.Point(462, 10);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(315, 195);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 10;
            this.pictureBoxImage.TabStop = false;
            // 
            // cEAdjuntosBindingSource
            // 
            this.cEAdjuntosBindingSource.DataSource = typeof(CapaEntidad.CEAdjuntos);
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
            // AdjuntoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxMenuAdjuntos);
            this.Controls.Add(this.dgvAdjuntos);
            this.Name = "AdjuntoEditar";
            this.Text = "AdjuntoEditar";
            this.gbxMenuAdjuntos.ResumeLayout(false);
            this.gbxMenuAdjuntos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDeptoListaJoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEAdjuntosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDepartamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cEDepartamentoBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.TextBox txtIdAdjunto;
        private System.Windows.Forms.TextBox txtNombreDepto;
        private System.Windows.Forms.Label lblIdAdjunto;
        private System.Windows.Forms.Label lblNombreDepto;
        private System.Windows.Forms.Label lblIdDepto;
        private System.Windows.Forms.TextBox txtIdDepto;
        private System.Windows.Forms.BindingSource cEDeptoListaJoinBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn denombreDepto;
        private System.Windows.Forms.Button btnEliminarAdjunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Depto;
        private System.Windows.Forms.Button btnArtas;
        private System.Windows.Forms.GroupBox gbxMenuAdjuntos;
        private System.Windows.Forms.DataGridView dgvDeptos;
        private System.Windows.Forms.BindingSource cEAdjuntosBindingSource;
        private System.Windows.Forms.DataGridView dgvAdjuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDEPARTAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDADJUNTOHABITACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDFECHACREACIONDataGridViewTextBoxColumn;
    }
}