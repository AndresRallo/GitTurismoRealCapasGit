
namespace CapaPresentacion.Departamentos
{
    partial class CambiarEstadoDepartamento
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListarDepartamentos = new System.Windows.Forms.Button();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.txtIdDepto = new System.Windows.Forms.TextBox();
            this.lblIngresarID = new System.Windows.Forms.Label();
            this.lblEliminarEmpleado = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.cbxEstadoDepa = new System.Windows.Forms.ComboBox();
            this.cEDeptoListaJoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.idDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCaracteristica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstadoDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.de_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadEstrellas = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.cEDeptoListaJoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.SuspendLayout();
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
            // btnListarDepartamentos
            // 
            this.btnListarDepartamentos.Location = new System.Drawing.Point(512, 79);
            this.btnListarDepartamentos.Name = "btnListarDepartamentos";
            this.btnListarDepartamentos.Size = new System.Drawing.Size(135, 23);
            this.btnListarDepartamentos.TabIndex = 13;
            this.btnListarDepartamentos.Text = "Listar/Actualizar";
            this.btnListarDepartamentos.UseVisualStyleBackColor = true;
            this.btnListarDepartamentos.Click += new System.EventHandler(this.btnListarDepartamentos_Click);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.Location = new System.Drawing.Point(339, 79);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(135, 23);
            this.btnCambiarEstado.TabIndex = 11;
            this.btnCambiarEstado.Text = "Cambiar Estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // txtIdDepto
            // 
            this.txtIdDepto.Location = new System.Drawing.Point(88, 83);
            this.txtIdDepto.Name = "txtIdDepto";
            this.txtIdDepto.Size = new System.Drawing.Size(48, 20);
            this.txtIdDepto.TabIndex = 10;
            // 
            // lblIngresarID
            // 
            this.lblIngresarID.AutoSize = true;
            this.lblIngresarID.Location = new System.Drawing.Point(21, 63);
            this.lblIngresarID.Name = "lblIngresarID";
            this.lblIngresarID.Size = new System.Drawing.Size(383, 13);
            this.lblIngresarID.TabIndex = 9;
            this.lblIngresarID.Text = "* Para cambiar el estado del departamento, ingrese el ID correspondiente / / / /";
            // 
            // lblEliminarEmpleado
            // 
            this.lblEliminarEmpleado.AutoSize = true;
            this.lblEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblEliminarEmpleado.Location = new System.Drawing.Point(13, 13);
            this.lblEliminarEmpleado.Name = "lblEliminarEmpleado";
            this.lblEliminarEmpleado.Size = new System.Drawing.Size(569, 46);
            this.lblEliminarEmpleado.TabIndex = 8;
            this.lblEliminarEmpleado.Text = "Cambiar Estado Departamento";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(32, 84);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "* ID";
            // 
            // cbxEstadoDepa
            // 
            this.cbxEstadoDepa.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "1. Administrador",
            "2. Recepcionista",
            "3. Chofer",
            "4. Guia Turistico"});
            this.cbxEstadoDepa.FormattingEnabled = true;
            this.cbxEstadoDepa.Location = new System.Drawing.Point(164, 81);
            this.cbxEstadoDepa.Name = "cbxEstadoDepa";
            this.cbxEstadoDepa.Size = new System.Drawing.Size(146, 21);
            this.cbxEstadoDepa.TabIndex = 38;
            // 
            // cEDeptoListaJoinBindingSource
            // 
            this.cEDeptoListaJoinBindingSource.DataSource = typeof(CapaEntidad.CEDeptoListaJoin);
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartamentos.AutoGenerateColumns = false;
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepto,
            this.idDireccion,
            this.IdCaracteristica,
            this.idRegion,
            this.id_comuna,
            this.idTipoDepto,
            this.idEstadoDepto,
            this.de_nombre,
            this.descripcionDepto,
            this.precioDepto,
            this.cantidadEstrellas,
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
            this.dgvDepartamentos.Location = new System.Drawing.Point(24, 108);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.Size = new System.Drawing.Size(764, 343);
            this.dgvDepartamentos.TabIndex = 39;
            this.dgvDepartamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamentos_CellClick);
            this.dgvDepartamentos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDepartamentos_KeyUp);
            // 
            // idDepto
            // 
            this.idDepto.DataPropertyName = "idDepto";
            this.idDepto.HeaderText = "id Depto";
            this.idDepto.Name = "idDepto";
            // 
            // idDireccion
            // 
            this.idDireccion.DataPropertyName = "idDireccion";
            this.idDireccion.HeaderText = "idDireccion";
            this.idDireccion.Name = "idDireccion";
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
            // idTipoDepto
            // 
            this.idTipoDepto.DataPropertyName = "idTipoDepto";
            this.idTipoDepto.HeaderText = "idTipoDepto";
            this.idTipoDepto.Name = "idTipoDepto";
            // 
            // idEstadoDepto
            // 
            this.idEstadoDepto.DataPropertyName = "idEstadoDepto";
            this.idEstadoDepto.HeaderText = "idEstadoDepto";
            this.idEstadoDepto.Name = "idEstadoDepto";
            // 
            // de_nombre
            // 
            this.de_nombre.DataPropertyName = "de_nombre";
            this.de_nombre.HeaderText = "Nombre";
            this.de_nombre.Name = "de_nombre";
            // 
            // descripcionDepto
            // 
            this.descripcionDepto.DataPropertyName = "descripcionDepto";
            this.descripcionDepto.HeaderText = "Descripción Departamento";
            this.descripcionDepto.Name = "descripcionDepto";
            // 
            // precioDepto
            // 
            this.precioDepto.DataPropertyName = "precioDepto";
            this.precioDepto.HeaderText = "Precio en $";
            this.precioDepto.Name = "precioDepto";
            // 
            // cantidadEstrellas
            // 
            this.cantidadEstrellas.DataPropertyName = "de_start";
            this.cantidadEstrellas.HeaderText = "Cantidad de Estrellas";
            this.cantidadEstrellas.Name = "cantidadEstrellas";
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
            // CambiarEstadoDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDepartamentos);
            this.Controls.Add(this.cbxEstadoDepa);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnListarDepartamentos);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.txtIdDepto);
            this.Controls.Add(this.lblIngresarID);
            this.Controls.Add(this.lblEliminarEmpleado);
            this.Name = "CambiarEstadoDepartamento";
            this.Text = "EliminarDepartamento";
            ((System.ComponentModel.ISupportInitialize)(this.cEDeptoListaJoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        protected internal System.Windows.Forms.Button btnListarDepartamentos;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.TextBox txtIdDepto;
        private System.Windows.Forms.Label lblIngresarID;
        private System.Windows.Forms.Label lblEliminarEmpleado;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbxEstadoDepa;
        private System.Windows.Forms.BindingSource cEDeptoListaJoinBindingSource;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCaracteristica;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_comuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn de_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadEstrellas;
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