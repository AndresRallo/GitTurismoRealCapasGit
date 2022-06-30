
namespace CapaPresentacion.Servicios
{
    partial class ListService
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
            this.gridServicios = new System.Windows.Forms.DataGridView();
            this.idServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idComunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Servicios";
            // 
            // gridServicios
            // 
            this.gridServicios.AutoGenerateColumns = false;
            this.gridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServiceDataGridViewTextBoxColumn,
            this.nameServiceDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn,
            this.direccionSucursalDataGridViewTextBoxColumn,
            this.numeroDireccionDataGridViewTextBoxColumn,
            this.idComunaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.tipoServicioDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.gridServicios.DataSource = this.cEServiceBindingSource;
            this.gridServicios.Location = new System.Drawing.Point(32, 114);
            this.gridServicios.Margin = new System.Windows.Forms.Padding(4);
            this.gridServicios.Name = "gridServicios";
            this.gridServicios.RowHeadersWidth = 51;
            this.gridServicios.Size = new System.Drawing.Size(1019, 356);
            this.gridServicios.TabIndex = 0;
            this.gridServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridServicios_CellContentClick);
            // 
            // idServiceDataGridViewTextBoxColumn
            // 
            this.idServiceDataGridViewTextBoxColumn.DataPropertyName = "IdService";
            this.idServiceDataGridViewTextBoxColumn.HeaderText = "IdService";
            this.idServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idServiceDataGridViewTextBoxColumn.Name = "idServiceDataGridViewTextBoxColumn";
            this.idServiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameServiceDataGridViewTextBoxColumn
            // 
            this.nameServiceDataGridViewTextBoxColumn.DataPropertyName = "NameService";
            this.nameServiceDataGridViewTextBoxColumn.HeaderText = "NameService";
            this.nameServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameServiceDataGridViewTextBoxColumn.Name = "nameServiceDataGridViewTextBoxColumn";
            this.nameServiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // ivaDataGridViewTextBoxColumn
            // 
            this.ivaDataGridViewTextBoxColumn.DataPropertyName = "Iva";
            this.ivaDataGridViewTextBoxColumn.HeaderText = "Iva";
            this.ivaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ivaDataGridViewTextBoxColumn.Name = "ivaDataGridViewTextBoxColumn";
            this.ivaDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionSucursalDataGridViewTextBoxColumn
            // 
            this.direccionSucursalDataGridViewTextBoxColumn.DataPropertyName = "DireccionSucursal";
            this.direccionSucursalDataGridViewTextBoxColumn.HeaderText = "DireccionSucursal";
            this.direccionSucursalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionSucursalDataGridViewTextBoxColumn.Name = "direccionSucursalDataGridViewTextBoxColumn";
            this.direccionSucursalDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroDireccionDataGridViewTextBoxColumn
            // 
            this.numeroDireccionDataGridViewTextBoxColumn.DataPropertyName = "NumeroDireccion";
            this.numeroDireccionDataGridViewTextBoxColumn.HeaderText = "NumeroDireccion";
            this.numeroDireccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroDireccionDataGridViewTextBoxColumn.Name = "numeroDireccionDataGridViewTextBoxColumn";
            this.numeroDireccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // idComunaDataGridViewTextBoxColumn
            // 
            this.idComunaDataGridViewTextBoxColumn.DataPropertyName = "IdComuna";
            this.idComunaDataGridViewTextBoxColumn.HeaderText = "IdComuna";
            this.idComunaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idComunaDataGridViewTextBoxColumn.Name = "idComunaDataGridViewTextBoxColumn";
            this.idComunaDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoServicioDataGridViewTextBoxColumn
            // 
            this.tipoServicioDataGridViewTextBoxColumn.DataPropertyName = "TipoServicio";
            this.tipoServicioDataGridViewTextBoxColumn.HeaderText = "TipoServicio";
            this.tipoServicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoServicioDataGridViewTextBoxColumn.Name = "tipoServicioDataGridViewTextBoxColumn";
            this.tipoServicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // cEServiceBindingSource
            // 
            this.cEServiceBindingSource.DataSource = typeof(CapaEntidad.CEService);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(32, 514);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 28);
            this.btnVolver.TabIndex = 47;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ListService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridServicios);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListService";
            this.Text = "ListService";
            ((System.ComponentModel.ISupportInitialize)(this.gridServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cEServiceBindingSource;
        private System.Windows.Forms.Button btnVolver;
    }
}