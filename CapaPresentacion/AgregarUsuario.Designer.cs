
namespace CapaPresentacion
{
    partial class AgregarUsuario
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
            this.lblAgregarUsuario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblIDEstado = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTELEFONO = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAMaterno = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtAMATERNO = new System.Windows.Forms.TextBox();
            this.txtAPATERNO = new System.Windows.Forms.TextBox();
            this.lblAPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.txtRUT = new System.Windows.Forms.TextBox();
            this.lblDV = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.cbESTADO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAgregarUsuario
            // 
            this.lblAgregarUsuario.AutoSize = true;
            this.lblAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblAgregarUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblAgregarUsuario.Name = "lblAgregarUsuario";
            this.lblAgregarUsuario.Size = new System.Drawing.Size(310, 46);
            this.lblAgregarUsuario.TabIndex = 0;
            this.lblAgregarUsuario.Text = "Agregar Usuario";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 59);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(315, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "* Para agregar usuario ingrese sus credenciales correspondientes";
            // 
            // lblIDEstado
            // 
            this.lblIDEstado.AutoSize = true;
            this.lblIDEstado.Location = new System.Drawing.Point(28, 272);
            this.lblIDEstado.Name = "lblIDEstado";
            this.lblIDEstado.Size = new System.Drawing.Size(54, 13);
            this.lblIDEstado.TabIndex = 44;
            this.lblIDEstado.Text = "ID Estado";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(28, 246);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 42;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTELEFONO
            // 
            this.txtTELEFONO.Location = new System.Drawing.Point(122, 243);
            this.txtTELEFONO.Name = "txtTELEFONO";
            this.txtTELEFONO.Size = new System.Drawing.Size(146, 20);
            this.txtTELEFONO.TabIndex = 38;
            this.txtTELEFONO.TextChanged += new System.EventHandler(this.txtTELEFONO_TextChanged);
            this.txtTELEFONO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTELEFONO_KeyPress);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(28, 220);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenia.TabIndex = 37;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 194);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email";
            // 
            // lblAMaterno
            // 
            this.lblAMaterno.AutoSize = true;
            this.lblAMaterno.Location = new System.Drawing.Point(28, 168);
            this.lblAMaterno.Name = "lblAMaterno";
            this.lblAMaterno.Size = new System.Drawing.Size(86, 13);
            this.lblAMaterno.TabIndex = 35;
            this.lblAMaterno.Text = "Apellido Materno";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(122, 217);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(146, 20);
            this.txtPW.TabIndex = 34;
            this.txtPW.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            this.txtPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPW_KeyPress);
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(122, 191);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(146, 20);
            this.txtEMAIL.TabIndex = 33;
            this.txtEMAIL.TextChanged += new System.EventHandler(this.txtEMAIL_TextChanged);
            this.txtEMAIL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEMAIL_KeyPress);
            // 
            // txtAMATERNO
            // 
            this.txtAMATERNO.Location = new System.Drawing.Point(122, 165);
            this.txtAMATERNO.Name = "txtAMATERNO";
            this.txtAMATERNO.Size = new System.Drawing.Size(146, 20);
            this.txtAMATERNO.TabIndex = 32;
            this.txtAMATERNO.TextChanged += new System.EventHandler(this.txtAMATERNO_TextChanged);
            this.txtAMATERNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAMATERNO_KeyPress);
            // 
            // txtAPATERNO
            // 
            this.txtAPATERNO.Location = new System.Drawing.Point(122, 139);
            this.txtAPATERNO.Name = "txtAPATERNO";
            this.txtAPATERNO.Size = new System.Drawing.Size(146, 20);
            this.txtAPATERNO.TabIndex = 31;
            this.txtAPATERNO.TextChanged += new System.EventHandler(this.txtAPATERNO_TextChanged);
            this.txtAPATERNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPATERNO_KeyPress);
            // 
            // lblAPaterno
            // 
            this.lblAPaterno.AutoSize = true;
            this.lblAPaterno.Location = new System.Drawing.Point(28, 142);
            this.lblAPaterno.Name = "lblAPaterno";
            this.lblAPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblAPaterno.TabIndex = 30;
            this.lblAPaterno.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 116);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(122, 113);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(146, 20);
            this.txtNOMBRE.TabIndex = 28;
            this.txtNOMBRE.TextChanged += new System.EventHandler(this.txtNOMBRE_TextChanged);
            this.txtNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOMBRE_KeyPress);
            // 
            // txtDV
            // 
            this.txtDV.Location = new System.Drawing.Point(292, 87);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(30, 20);
            this.txtDV.TabIndex = 27;
            this.txtDV.TextChanged += new System.EventHandler(this.txtDV_TextChanged);
            this.txtDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDV_KeyPress);
            // 
            // txtRUT
            // 
            this.txtRUT.Location = new System.Drawing.Point(122, 87);
            this.txtRUT.Name = "txtRUT";
            this.txtRUT.Size = new System.Drawing.Size(146, 20);
            this.txtRUT.TabIndex = 26;
            this.txtRUT.TextChanged += new System.EventHandler(this.txtRUT_TextChanged);
            this.txtRUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUT_KeyPress);
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.Location = new System.Drawing.Point(328, 90);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(0, 13);
            this.lblDV.TabIndex = 25;
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(28, 90);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(24, 13);
            this.lblRut.TabIndex = 24;
            this.lblRut.Text = "Rut";
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(245, 402);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(135, 23);
            this.btnProbarConexion.TabIndex = 47;
            this.btnProbarConexion.Text = "Probar Conexion";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(164, 402);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 46;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(23, 402);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(135, 23);
            this.btnAgregarUsuario.TabIndex = 45;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
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
            this.cbESTADO.Location = new System.Drawing.Point(122, 272);
            this.cbESTADO.Name = "cbESTADO";
            this.cbESTADO.Size = new System.Drawing.Size(146, 21);
            this.cbESTADO.TabIndex = 48;
            this.cbESTADO.SelectedIndexChanged += new System.EventHandler(this.cbESTADO_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "-";
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbESTADO);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.lblIDEstado);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTELEFONO);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAMaterno);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtAMATERNO);
            this.Controls.Add(this.txtAPATERNO);
            this.Controls.Add(this.lblAPaterno);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.txtDV);
            this.Controls.Add(this.txtRUT);
            this.Controls.Add(this.lblDV);
            this.Controls.Add(this.lblRut);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblAgregarUsuario);
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarUsuario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblIDEstado;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTELEFONO;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAMaterno;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtAMATERNO;
        private System.Windows.Forms.TextBox txtAPATERNO;
        private System.Windows.Forms.Label lblAPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.TextBox txtRUT;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.ComboBox cbESTADO;
        private System.Windows.Forms.Label label1;
    }
}