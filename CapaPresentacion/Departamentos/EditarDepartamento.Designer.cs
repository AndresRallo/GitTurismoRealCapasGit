
namespace CapaPresentacion.Departamentos
{
    partial class EditarDepartamento
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbxCarDepto = new System.Windows.Forms.GroupBox();
            this.txtNumDepto = new System.Windows.Forms.TextBox();
            this.lblNumDepto = new System.Windows.Forms.Label();
            this.txtCantHabitaciones = new System.Windows.Forms.TextBox();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.txtCanPersonas = new System.Windows.Forms.TextBox();
            this.lblCantPersonas = new System.Windows.Forms.Label();
            this.txtCantBanos = new System.Windows.Forms.TextBox();
            this.lblCantBanos = new System.Windows.Forms.Label();
            this.txtCanCamas = new System.Windows.Forms.TextBox();
            this.lblCantCamas = new System.Windows.Forms.Label();
            this.gbxDepto = new System.Windows.Forms.GroupBox();
            this.txtIdDepto = new System.Windows.Forms.TextBox();
            this.lblIdDepto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescDepto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtEstrellas = new System.Windows.Forms.TextBox();
            this.lblDesDepto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIDEstado = new System.Windows.Forms.Label();
            this.cbxEstadoDepa = new System.Windows.Forms.ComboBox();
            this.lblTipoDepa = new System.Windows.Forms.Label();
            this.lblEstadoDepa = new System.Windows.Forms.Label();
            this.cbxTipoDepto = new System.Windows.Forms.ComboBox();
            this.gbxDireccion = new System.Windows.Forms.GroupBox();
            this.txtIdCaract = new System.Windows.Forms.TextBox();
            this.lblIdCaract = new System.Windows.Forms.Label();
            this.txtIdDirc = new System.Windows.Forms.TextBox();
            this.lblIdDirec = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cbxComuna = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.gbxCarDepto.SuspendLayout();
            this.gbxDepto.SuspendLayout();
            this.gbxDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(21, 354);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 22);
            this.btnEditar.TabIndex = 62;
            this.btnEditar.Text = "Editar Departamento";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Location = new System.Drawing.Point(216, 204);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.Size = new System.Drawing.Size(572, 234);
            this.dgvDepartamentos.TabIndex = 34;
            this.dgvDepartamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamentos_CellClick);
            this.dgvDepartamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamentos_CellContentClick);
            this.dgvDepartamentos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDepartamentos_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 46);
            this.label1.TabIndex = 32;
            this.label1.Text = "Editar Departamento";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(21, 414);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 23);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gbxCarDepto
            // 
            this.gbxCarDepto.Controls.Add(this.txtNumDepto);
            this.gbxCarDepto.Controls.Add(this.lblNumDepto);
            this.gbxCarDepto.Controls.Add(this.txtCantHabitaciones);
            this.gbxCarDepto.Controls.Add(this.lblHabitaciones);
            this.gbxCarDepto.Controls.Add(this.txtCheckOut);
            this.gbxCarDepto.Controls.Add(this.lblCheckOut);
            this.gbxCarDepto.Controls.Add(this.txtCheckIn);
            this.gbxCarDepto.Controls.Add(this.lblCheckIn);
            this.gbxCarDepto.Controls.Add(this.txtCanPersonas);
            this.gbxCarDepto.Controls.Add(this.lblCantPersonas);
            this.gbxCarDepto.Controls.Add(this.txtCantBanos);
            this.gbxCarDepto.Controls.Add(this.lblCantBanos);
            this.gbxCarDepto.Controls.Add(this.txtCanCamas);
            this.gbxCarDepto.Controls.Add(this.lblCantCamas);
            this.gbxCarDepto.Location = new System.Drawing.Point(572, 13);
            this.gbxCarDepto.Name = "gbxCarDepto";
            this.gbxCarDepto.Size = new System.Drawing.Size(228, 189);
            this.gbxCarDepto.TabIndex = 74;
            this.gbxCarDepto.TabStop = false;
            // 
            // txtNumDepto
            // 
            this.txtNumDepto.Location = new System.Drawing.Point(151, 19);
            this.txtNumDepto.Name = "txtNumDepto";
            this.txtNumDepto.Size = new System.Drawing.Size(65, 20);
            this.txtNumDepto.TabIndex = 74;
            // 
            // lblNumDepto
            // 
            this.lblNumDepto.AutoSize = true;
            this.lblNumDepto.Location = new System.Drawing.Point(6, 26);
            this.lblNumDepto.Name = "lblNumDepto";
            this.lblNumDepto.Size = new System.Drawing.Size(114, 13);
            this.lblNumDepto.TabIndex = 75;
            this.lblNumDepto.Text = "Número Departamento";
            // 
            // txtCantHabitaciones
            // 
            this.txtCantHabitaciones.Location = new System.Drawing.Point(152, 43);
            this.txtCantHabitaciones.Name = "txtCantHabitaciones";
            this.txtCantHabitaciones.Size = new System.Drawing.Size(63, 20);
            this.txtCantHabitaciones.TabIndex = 72;
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Location = new System.Drawing.Point(6, 50);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(129, 13);
            this.lblHabitaciones.TabIndex = 73;
            this.lblHabitaciones.Text = "Cantidad de Habitaciones";
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Location = new System.Drawing.Point(152, 163);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(63, 20);
            this.txtCheckOut.TabIndex = 70;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(6, 170);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(58, 13);
            this.lblCheckOut.TabIndex = 71;
            this.lblCheckOut.Text = "Check Out";
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Location = new System.Drawing.Point(152, 139);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(63, 20);
            this.txtCheckIn.TabIndex = 68;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(6, 146);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(50, 13);
            this.lblCheckIn.TabIndex = 69;
            this.lblCheckIn.Text = "Check In";
            // 
            // txtCanPersonas
            // 
            this.txtCanPersonas.Location = new System.Drawing.Point(152, 115);
            this.txtCanPersonas.Name = "txtCanPersonas";
            this.txtCanPersonas.Size = new System.Drawing.Size(63, 20);
            this.txtCanPersonas.TabIndex = 66;
            // 
            // lblCantPersonas
            // 
            this.lblCantPersonas.AutoSize = true;
            this.lblCantPersonas.Location = new System.Drawing.Point(6, 122);
            this.lblCantPersonas.Name = "lblCantPersonas";
            this.lblCantPersonas.Size = new System.Drawing.Size(111, 13);
            this.lblCantPersonas.TabIndex = 67;
            this.lblCantPersonas.Text = "Cantidad de Personas";
            // 
            // txtCantBanos
            // 
            this.txtCantBanos.Location = new System.Drawing.Point(152, 91);
            this.txtCantBanos.Name = "txtCantBanos";
            this.txtCantBanos.Size = new System.Drawing.Size(63, 20);
            this.txtCantBanos.TabIndex = 64;
            // 
            // lblCantBanos
            // 
            this.lblCantBanos.AutoSize = true;
            this.lblCantBanos.Location = new System.Drawing.Point(6, 98);
            this.lblCantBanos.Name = "lblCantBanos";
            this.lblCantBanos.Size = new System.Drawing.Size(97, 13);
            this.lblCantBanos.TabIndex = 65;
            this.lblCantBanos.Text = "Cantidad de Baños";
            // 
            // txtCanCamas
            // 
            this.txtCanCamas.Location = new System.Drawing.Point(152, 67);
            this.txtCanCamas.Name = "txtCanCamas";
            this.txtCanCamas.Size = new System.Drawing.Size(63, 20);
            this.txtCanCamas.TabIndex = 62;
            // 
            // lblCantCamas
            // 
            this.lblCantCamas.AutoSize = true;
            this.lblCantCamas.Location = new System.Drawing.Point(6, 74);
            this.lblCantCamas.Name = "lblCantCamas";
            this.lblCantCamas.Size = new System.Drawing.Size(99, 13);
            this.lblCantCamas.TabIndex = 63;
            this.lblCantCamas.Text = "Cantidad de Camas";
            // 
            // gbxDepto
            // 
            this.gbxDepto.Controls.Add(this.txtIdDepto);
            this.gbxDepto.Controls.Add(this.lblIdDepto);
            this.gbxDepto.Controls.Add(this.lblNombre);
            this.gbxDepto.Controls.Add(this.txtDescDepto);
            this.gbxDepto.Controls.Add(this.txtNombre);
            this.gbxDepto.Controls.Add(this.txtPrecio);
            this.gbxDepto.Controls.Add(this.txtEstrellas);
            this.gbxDepto.Controls.Add(this.lblDesDepto);
            this.gbxDepto.Controls.Add(this.label3);
            this.gbxDepto.Controls.Add(this.lblIDEstado);
            this.gbxDepto.Controls.Add(this.cbxEstadoDepa);
            this.gbxDepto.Controls.Add(this.lblTipoDepa);
            this.gbxDepto.Controls.Add(this.lblEstadoDepa);
            this.gbxDepto.Controls.Add(this.cbxTipoDepto);
            this.gbxDepto.Location = new System.Drawing.Point(1, 62);
            this.gbxDepto.Name = "gbxDepto";
            this.gbxDepto.Size = new System.Drawing.Size(209, 286);
            this.gbxDepto.TabIndex = 73;
            this.gbxDepto.TabStop = false;
            // 
            // txtIdDepto
            // 
            this.txtIdDepto.Location = new System.Drawing.Point(146, 11);
            this.txtIdDepto.Name = "txtIdDepto";
            this.txtIdDepto.Size = new System.Drawing.Size(51, 20);
            this.txtIdDepto.TabIndex = 62;
            // 
            // lblIdDepto
            // 
            this.lblIdDepto.AutoSize = true;
            this.lblIdDepto.Location = new System.Drawing.Point(12, 15);
            this.lblIdDepto.Name = "lblIdDepto";
            this.lblIdDepto.Size = new System.Drawing.Size(48, 13);
            this.lblIdDepto.TabIndex = 61;
            this.lblIdDepto.Text = "Id Depto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 13);
            this.lblNombre.TabIndex = 60;
            this.lblNombre.Text = "Nombre del departamento";
            // 
            // txtDescDepto
            // 
            this.txtDescDepto.Location = new System.Drawing.Point(12, 97);
            this.txtDescDepto.Name = "txtDescDepto";
            this.txtDescDepto.Size = new System.Drawing.Size(185, 20);
            this.txtDescDepto.TabIndex = 44;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 20);
            this.txtNombre.TabIndex = 59;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(12, 143);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(185, 20);
            this.txtPrecio.TabIndex = 45;
            // 
            // txtEstrellas
            // 
            this.txtEstrellas.Location = new System.Drawing.Point(146, 169);
            this.txtEstrellas.Name = "txtEstrellas";
            this.txtEstrellas.Size = new System.Drawing.Size(51, 20);
            this.txtEstrellas.TabIndex = 58;
            // 
            // lblDesDepto
            // 
            this.lblDesDepto.AutoSize = true;
            this.lblDesDepto.Location = new System.Drawing.Point(12, 76);
            this.lblDesDepto.Name = "lblDesDepto";
            this.lblDesDepto.Size = new System.Drawing.Size(150, 13);
            this.lblDesDepto.TabIndex = 48;
            this.lblDesDepto.Text = "Descripción del Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Número Estrellas";
            // 
            // lblIDEstado
            // 
            this.lblIDEstado.AutoSize = true;
            this.lblIDEstado.Location = new System.Drawing.Point(12, 122);
            this.lblIDEstado.Name = "lblIDEstado";
            this.lblIDEstado.Size = new System.Drawing.Size(124, 13);
            this.lblIDEstado.TabIndex = 49;
            this.lblIDEstado.Text = "Agregar Precio en Pesos";
            // 
            // cbxEstadoDepa
            // 
            this.cbxEstadoDepa.FormattingEnabled = true;
            this.cbxEstadoDepa.Location = new System.Drawing.Point(12, 256);
            this.cbxEstadoDepa.Name = "cbxEstadoDepa";
            this.cbxEstadoDepa.Size = new System.Drawing.Size(185, 21);
            this.cbxEstadoDepa.TabIndex = 56;
            // 
            // lblTipoDepa
            // 
            this.lblTipoDepa.AutoSize = true;
            this.lblTipoDepa.Location = new System.Drawing.Point(12, 191);
            this.lblTipoDepa.Name = "lblTipoDepa";
            this.lblTipoDepa.Size = new System.Drawing.Size(113, 13);
            this.lblTipoDepa.TabIndex = 50;
            this.lblTipoDepa.Text = "Tipo de Departamento";
            // 
            // lblEstadoDepa
            // 
            this.lblEstadoDepa.AutoSize = true;
            this.lblEstadoDepa.Location = new System.Drawing.Point(12, 240);
            this.lblEstadoDepa.Name = "lblEstadoDepa";
            this.lblEstadoDepa.Size = new System.Drawing.Size(127, 13);
            this.lblEstadoDepa.TabIndex = 55;
            this.lblEstadoDepa.Text = "Estado del Departamento";
            // 
            // cbxTipoDepto
            // 
            this.cbxTipoDepto.FormattingEnabled = true;
            this.cbxTipoDepto.Location = new System.Drawing.Point(12, 214);
            this.cbxTipoDepto.Name = "cbxTipoDepto";
            this.cbxTipoDepto.Size = new System.Drawing.Size(185, 21);
            this.cbxTipoDepto.TabIndex = 54;
            // 
            // gbxDireccion
            // 
            this.gbxDireccion.Controls.Add(this.txtIdCaract);
            this.gbxDireccion.Controls.Add(this.lblIdCaract);
            this.gbxDireccion.Controls.Add(this.txtIdDirc);
            this.gbxDireccion.Controls.Add(this.lblIdDirec);
            this.gbxDireccion.Controls.Add(this.lblRegion);
            this.gbxDireccion.Controls.Add(this.cbxRegion);
            this.gbxDireccion.Controls.Add(this.label2);
            this.gbxDireccion.Controls.Add(this.txtNumero);
            this.gbxDireccion.Controls.Add(this.cbxComuna);
            this.gbxDireccion.Controls.Add(this.lblNumero);
            this.gbxDireccion.Controls.Add(this.txtDireccion);
            this.gbxDireccion.Controls.Add(this.lblDireccion);
            this.gbxDireccion.Location = new System.Drawing.Point(216, 62);
            this.gbxDireccion.Name = "gbxDireccion";
            this.gbxDireccion.Size = new System.Drawing.Size(338, 140);
            this.gbxDireccion.TabIndex = 74;
            this.gbxDireccion.TabStop = false;
            // 
            // txtIdCaract
            // 
            this.txtIdCaract.Location = new System.Drawing.Point(285, 16);
            this.txtIdCaract.Name = "txtIdCaract";
            this.txtIdCaract.Size = new System.Drawing.Size(47, 20);
            this.txtIdCaract.TabIndex = 67;
            // 
            // lblIdCaract
            // 
            this.lblIdCaract.AutoSize = true;
            this.lblIdCaract.Location = new System.Drawing.Point(189, 20);
            this.lblIdCaract.Name = "lblIdCaract";
            this.lblIdCaract.Size = new System.Drawing.Size(90, 13);
            this.lblIdCaract.TabIndex = 66;
            this.lblIdCaract.Text = "Id Características";
            // 
            // txtIdDirc
            // 
            this.txtIdDirc.Location = new System.Drawing.Point(81, 16);
            this.txtIdDirc.Name = "txtIdDirc";
            this.txtIdDirc.Size = new System.Drawing.Size(47, 20);
            this.txtIdDirc.TabIndex = 64;
            // 
            // lblIdDirec
            // 
            this.lblIdDirec.AutoSize = true;
            this.lblIdDirec.Location = new System.Drawing.Point(12, 20);
            this.lblIdDirec.Name = "lblIdDirec";
            this.lblIdDirec.Size = new System.Drawing.Size(65, 13);
            this.lblIdDirec.TabIndex = 63;
            this.lblIdDirec.Text = "Id DIrección";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegion.Location = new System.Drawing.Point(6, 47);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 64;
            this.lblRegion.Text = "Región";
            // 
            // cbxRegion
            // 
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Location = new System.Drawing.Point(6, 67);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(156, 21);
            this.cbxRegion.TabIndex = 65;
            this.cbxRegion.SelectedIndexChanged += new System.EventHandler(this.cbxRegion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Comuna";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(254, 116);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 20);
            this.txtNumero.TabIndex = 62;
            // 
            // cbxComuna
            // 
            this.cbxComuna.FormattingEnabled = true;
            this.cbxComuna.Location = new System.Drawing.Point(182, 67);
            this.cbxComuna.Name = "cbxComuna";
            this.cbxComuna.Size = new System.Drawing.Size(156, 21);
            this.cbxComuna.TabIndex = 62;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(253, 99);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 63;
            this.lblNumero.Text = "Número";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(9, 116);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(219, 20);
            this.txtDireccion.TabIndex = 61;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(8, 95);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 61;
            this.lblDireccion.Text = "Dirección";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(21, 384);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(135, 22);
            this.btnListar.TabIndex = 75;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // EditarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gbxDireccion);
            this.Controls.Add(this.gbxCarDepto);
            this.Controls.Add(this.gbxDepto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvDepartamentos);
            this.Controls.Add(this.label1);
            this.Name = "EditarDepartamento";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.gbxCarDepto.ResumeLayout(false);
            this.gbxCarDepto.PerformLayout();
            this.gbxDepto.ResumeLayout(false);
            this.gbxDepto.PerformLayout();
            this.gbxDireccion.ResumeLayout(false);
            this.gbxDireccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gbxCarDepto;
        private System.Windows.Forms.TextBox txtCantHabitaciones;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.TextBox txtCanPersonas;
        private System.Windows.Forms.Label lblCantPersonas;
        private System.Windows.Forms.TextBox txtCantBanos;
        private System.Windows.Forms.Label lblCantBanos;
        private System.Windows.Forms.TextBox txtCanCamas;
        private System.Windows.Forms.Label lblCantCamas;
        private System.Windows.Forms.GroupBox gbxDepto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescDepto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtEstrellas;
        private System.Windows.Forms.Label lblDesDepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIDEstado;
        private System.Windows.Forms.ComboBox cbxEstadoDepa;
        private System.Windows.Forms.Label lblTipoDepa;
        private System.Windows.Forms.Label lblEstadoDepa;
        private System.Windows.Forms.ComboBox cbxTipoDepto;
        private System.Windows.Forms.GroupBox gbxDireccion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cbxComuna;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtIdDepto;
        private System.Windows.Forms.Label lblIdDepto;
        private System.Windows.Forms.TextBox txtIdDirc;
        private System.Windows.Forms.Label lblIdDirec;
        private System.Windows.Forms.TextBox txtIdCaract;
        private System.Windows.Forms.Label lblIdCaract;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtNumDepto;
        private System.Windows.Forms.Label lblNumDepto;
    }
}