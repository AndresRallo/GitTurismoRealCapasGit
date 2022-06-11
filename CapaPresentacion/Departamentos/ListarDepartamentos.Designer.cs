
namespace CapaPresentacion.Departamentos
{
    partial class ListarDepartamentos
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.cEDeptoListaJoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idcomunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCaracteristicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDirecionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCaracteristica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.de_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.de_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.de_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca_NumDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca_CantHabitaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca_CantCamas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca_CantBaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca_CapPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca_CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca_CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDeptoListaJoinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(516, 70);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(103, 23);
            this.btnProbarConexion.TabIndex = 10;
            this.btnProbarConexion.Text = "Probar Conexion";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(43, 70);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(135, 23);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(625, 70);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista de Departamentos";
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartamentos.AutoGenerateColumns = false;
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomunaDataGridViewTextBoxColumn,
            this.idCaracteristicaDataGridViewTextBoxColumn,
            this.idDirecionDataGridViewTextBoxColumn,
            this.idDepartamentoDataGridViewTextBoxColumn,
            this.IdCaracteristica,
            this.idRegion,
            this.id_comuna,
            this.de_nombre,
            this.tipoDepto,
            this.estadoDepto,
            this.region,
            this.comuna,
            this.de_direccion,
            this.de_numero,
            this.Ca_NumDepto,
            this.Ca_CantHabitaciones,
            this.Ca_CantCamas,
            this.Ca_CantBaño,
            this.Ca_CapPersonas,
            this.Ca_CheckIn,
            this.Ca_CheckOut});
            this.dgvDepartamentos.DataSource = this.cEDeptoListaJoinBindingSource;
            this.dgvDepartamentos.Location = new System.Drawing.Point(12, 95);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.Size = new System.Drawing.Size(776, 343);
            this.dgvDepartamentos.TabIndex = 40;
            // 
            // cEDeptoListaJoinBindingSource
            // 
            this.cEDeptoListaJoinBindingSource.DataSource = typeof(CapaEntidad.CEDeptoListaJoin);
            // 
            // idcomunaDataGridViewTextBoxColumn
            // 
            this.idcomunaDataGridViewTextBoxColumn.DataPropertyName = "id_comuna";
            this.idcomunaDataGridViewTextBoxColumn.HeaderText = "id_comuna";
            this.idcomunaDataGridViewTextBoxColumn.Name = "idcomunaDataGridViewTextBoxColumn";
            // 
            // idCaracteristicaDataGridViewTextBoxColumn
            // 
            this.idCaracteristicaDataGridViewTextBoxColumn.DataPropertyName = "IdCaracteristica";
            this.idCaracteristicaDataGridViewTextBoxColumn.HeaderText = "IdCaracteristica";
            this.idCaracteristicaDataGridViewTextBoxColumn.Name = "idCaracteristicaDataGridViewTextBoxColumn";
            // 
            // idDirecionDataGridViewTextBoxColumn
            // 
            this.idDirecionDataGridViewTextBoxColumn.DataPropertyName = "IdDirecion";
            this.idDirecionDataGridViewTextBoxColumn.HeaderText = "IdDirecion";
            this.idDirecionDataGridViewTextBoxColumn.Name = "idDirecionDataGridViewTextBoxColumn";
            // 
            // idDepartamentoDataGridViewTextBoxColumn
            // 
            this.idDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "IdDepartamento";
            this.idDepartamentoDataGridViewTextBoxColumn.HeaderText = "IdDepartamento";
            this.idDepartamentoDataGridViewTextBoxColumn.Name = "idDepartamentoDataGridViewTextBoxColumn";
            // 
            // IdCaracteristica
            // 
            this.IdCaracteristica.DataPropertyName = "IdCaracteristica";
            this.IdCaracteristica.HeaderText = "IdCaracteristica";
            this.IdCaracteristica.Name = "IdCaracteristica";
            // 
            // idRegion
            // 
            this.idRegion.DataPropertyName = "idRegion";
            this.idRegion.HeaderText = "idRegion";
            this.idRegion.Name = "idRegion";
            // 
            // id_comuna
            // 
            this.id_comuna.DataPropertyName = "id_comuna";
            this.id_comuna.HeaderText = "id_comuna";
            this.id_comuna.Name = "id_comuna";
            // 
            // de_nombre
            // 
            this.de_nombre.DataPropertyName = "de_nombre";
            this.de_nombre.HeaderText = "de_nombre";
            this.de_nombre.Name = "de_nombre";
            // 
            // tipoDepto
            // 
            this.tipoDepto.DataPropertyName = "tipoDepto";
            this.tipoDepto.HeaderText = "Tipo Departamento";
            this.tipoDepto.Name = "tipoDepto";
            // 
            // estadoDepto
            // 
            this.estadoDepto.DataPropertyName = "estadoDepto";
            this.estadoDepto.HeaderText = "Estado Departamento";
            this.estadoDepto.Name = "estadoDepto";
            // 
            // region
            // 
            this.region.DataPropertyName = "region";
            this.region.HeaderText = "Region";
            this.region.Name = "region";
            // 
            // comuna
            // 
            this.comuna.DataPropertyName = "comuna";
            this.comuna.HeaderText = "Comuna";
            this.comuna.Name = "comuna";
            // 
            // de_direccion
            // 
            this.de_direccion.DataPropertyName = "de_direccion";
            this.de_direccion.HeaderText = "Dirección";
            this.de_direccion.Name = "de_direccion";
            // 
            // de_numero
            // 
            this.de_numero.DataPropertyName = "de_numero";
            this.de_numero.HeaderText = "Número";
            this.de_numero.Name = "de_numero";
            // 
            // Ca_NumDepto
            // 
            this.Ca_NumDepto.DataPropertyName = "Ca_NumDepto";
            this.Ca_NumDepto.HeaderText = "Número del Departamento";
            this.Ca_NumDepto.Name = "Ca_NumDepto";
            // 
            // Ca_CantHabitaciones
            // 
            this.Ca_CantHabitaciones.DataPropertyName = "Ca_CantHabitaciones";
            this.Ca_CantHabitaciones.HeaderText = "Cantidad de Habitaciones";
            this.Ca_CantHabitaciones.Name = "Ca_CantHabitaciones";
            // 
            // Ca_CantCamas
            // 
            this.Ca_CantCamas.DataPropertyName = "Ca_CantCamas";
            this.Ca_CantCamas.HeaderText = "Cantidad de Camas";
            this.Ca_CantCamas.Name = "Ca_CantCamas";
            // 
            // Ca_CantBaño
            // 
            this.Ca_CantBaño.DataPropertyName = "Ca_CantBaño";
            this.Ca_CantBaño.HeaderText = "Cantidad de Baños";
            this.Ca_CantBaño.Name = "Ca_CantBaño";
            // 
            // Ca_CapPersonas
            // 
            this.Ca_CapPersonas.DataPropertyName = "Ca_CapPersonas";
            this.Ca_CapPersonas.HeaderText = "Cantidad de Personas";
            this.Ca_CapPersonas.Name = "Ca_CapPersonas";
            // 
            // Ca_CheckIn
            // 
            this.Ca_CheckIn.DataPropertyName = "Ca_CheckIn";
            this.Ca_CheckIn.HeaderText = "Check In";
            this.Ca_CheckIn.Name = "Ca_CheckIn";
            // 
            // Ca_CheckOut
            // 
            this.Ca_CheckOut.DataPropertyName = "Ca_CheckOut";
            this.Ca_CheckOut.HeaderText = "Check Out";
            this.Ca_CheckOut.Name = "Ca_CheckOut";
            // 
            // ListarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDepartamentos);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Name = "ListarDepartamentos";
            this.Text = "ListarDepartamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDeptoListaJoinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.BindingSource cEDeptoListaJoinBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCaracteristicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDirecionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCaracteristica;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_comuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn de_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn comuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn de_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn de_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca_NumDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca_CantHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca_CantCamas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca_CantBaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca_CapPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca_CheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca_CheckOut;
    }
}