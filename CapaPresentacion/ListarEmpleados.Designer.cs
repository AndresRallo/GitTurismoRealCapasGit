
namespace CapaPresentacion
{
    partial class ListarEmpleados
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvVEHICULO = new System.Windows.Forms.DataGridView();
            this.cEEmpleadoDireccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDEMPLEADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMRUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAPATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAMATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dedireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVEHICULO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEEmpleadoDireccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Empleados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(618, 95);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            this.tPDESCRIPCIONDataGridViewTextBoxColumn,
            this.dedireccionDataGridViewTextBoxColumn,
            this.denumeroDataGridViewTextBoxColumn,
            this.cdescripcionDataGridViewTextBoxColumn,
            this.rEDESCRIPCIONDataGridViewTextBoxColumn,
            this.eSDESCRIPCIONDataGridViewTextBoxColumn});
            this.dataGridViewEmpleados.DataSource = this.cEEmpleadoDireccionBindingSource;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(36, 130);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(717, 128);
            this.dataGridViewEmpleados.TabIndex = 2;
            this.dataGridViewEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellContentClick);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(36, 95);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(135, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(509, 95);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(103, 23);
            this.btnProbarConexion.TabIndex = 5;
            this.btnProbarConexion.Text = "Probar Conexion";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dgvVEHICULO
            // 
            this.dgvVEHICULO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVEHICULO.Location = new System.Drawing.Point(36, 282);
            this.dgvVEHICULO.Name = "dgvVEHICULO";
            this.dgvVEHICULO.Size = new System.Drawing.Size(717, 139);
            this.dgvVEHICULO.TabIndex = 6;
            // 
            // cEEmpleadoDireccionBindingSource
            // 
            this.cEEmpleadoDireccionBindingSource.DataSource = typeof(CapaEntidad.CEEmpleado_Direccion);
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
            // tPDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.tPDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "TP_DESCRIPCION";
            this.tPDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "TP_DESCRIPCION";
            this.tPDESCRIPCIONDataGridViewTextBoxColumn.Name = "tPDESCRIPCIONDataGridViewTextBoxColumn";
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
            // cdescripcionDataGridViewTextBoxColumn
            // 
            this.cdescripcionDataGridViewTextBoxColumn.DataPropertyName = "c_descripcion";
            this.cdescripcionDataGridViewTextBoxColumn.HeaderText = "c_descripcion";
            this.cdescripcionDataGridViewTextBoxColumn.Name = "cdescripcionDataGridViewTextBoxColumn";
            // 
            // rEDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.rEDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "RE_DESCRIPCION";
            this.rEDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "RE_DESCRIPCION";
            this.rEDESCRIPCIONDataGridViewTextBoxColumn.Name = "rEDESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // eSDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.eSDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "ES_DESCRIPCION";
            this.eSDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "ES_DESCRIPCION";
            this.eSDESCRIPCIONDataGridViewTextBoxColumn.Name = "eSDESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // ListarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVEHICULO);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Name = "ListarEmpleados";
            this.Text = "ListarEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVEHICULO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEEmpleadoDireccionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnProbarConexion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvVEHICULO;
        private System.Windows.Forms.BindingSource cEEmpleadoDireccionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEMPLEADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMRUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAPATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAMATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPDESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dedireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEDESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSDESCRIPCIONDataGridViewTextBoxColumn;
    }
}