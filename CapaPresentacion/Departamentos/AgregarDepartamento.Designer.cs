
namespace CapaPresentacion.Departamentos
{
    partial class AgregarDepartamento
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
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgreDepto = new System.Windows.Forms.Button();
            this.lblTipoDepa = new System.Windows.Forms.Label();
            this.lblIDEstado = new System.Windows.Forms.Label();
            this.lblDesDepto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescDepto = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblAgregarEmpleado = new System.Windows.Forms.Label();
            this.cbxTipoDepto = new System.Windows.Forms.ComboBox();
            this.cbxEstadoDepa = new System.Windows.Forms.ComboBox();
            this.lblEstadoDepa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstrellas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(242, 420);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(135, 23);
            this.btnProbarConexion.TabIndex = 53;
            this.btnProbarConexion.Text = "Probar Conexion";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(161, 420);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 52;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnAgreDepto
            // 
            this.btnAgreDepto.Location = new System.Drawing.Point(20, 420);
            this.btnAgreDepto.Name = "btnAgreDepto";
            this.btnAgreDepto.Size = new System.Drawing.Size(135, 23);
            this.btnAgreDepto.TabIndex = 51;
            this.btnAgreDepto.Text = "Agregar Departamento";
            this.btnAgreDepto.UseVisualStyleBackColor = true;
            this.btnAgreDepto.Click += new System.EventHandler(this.btnAgreDepto_Click);
            // 
            // lblTipoDepa
            // 
            this.lblTipoDepa.AutoSize = true;
            this.lblTipoDepa.Location = new System.Drawing.Point(23, 231);
            this.lblTipoDepa.Name = "lblTipoDepa";
            this.lblTipoDepa.Size = new System.Drawing.Size(113, 13);
            this.lblTipoDepa.TabIndex = 50;
            this.lblTipoDepa.Text = "Tipo de Departamento";
            // 
            // lblIDEstado
            // 
            this.lblIDEstado.AutoSize = true;
            this.lblIDEstado.Location = new System.Drawing.Point(23, 139);
            this.lblIDEstado.Name = "lblIDEstado";
            this.lblIDEstado.Size = new System.Drawing.Size(124, 13);
            this.lblIDEstado.TabIndex = 49;
            this.lblIDEstado.Text = "Agregar Precio en Pesos";
            // 
            // lblDesDepto
            // 
            this.lblDesDepto.AutoSize = true;
            this.lblDesDepto.Location = new System.Drawing.Point(20, 99);
            this.lblDesDepto.Name = "lblDesDepto";
            this.lblDesDepto.Size = new System.Drawing.Size(150, 13);
            this.lblDesDepto.TabIndex = 48;
            this.lblDesDepto.Text = "Descripción del Departamento";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(183, 136);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(185, 20);
            this.txtPrecio.TabIndex = 45;
            // 
            // txtDescDepto
            // 
            this.txtDescDepto.Location = new System.Drawing.Point(183, 99);
            this.txtDescDepto.Name = "txtDescDepto";
            this.txtDescDepto.Size = new System.Drawing.Size(185, 20);
            this.txtDescDepto.TabIndex = 44;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(20, 64);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(348, 13);
            this.lblDesc.TabIndex = 30;
            this.lblDesc.Text = "* Para agregar Departamento ingrese sus credenciales correspondientes";
            // 
            // lblAgregarEmpleado
            // 
            this.lblAgregarEmpleado.AutoSize = true;
            this.lblAgregarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblAgregarEmpleado.Location = new System.Drawing.Point(12, 18);
            this.lblAgregarEmpleado.Name = "lblAgregarEmpleado";
            this.lblAgregarEmpleado.Size = new System.Drawing.Size(424, 46);
            this.lblAgregarEmpleado.TabIndex = 27;
            this.lblAgregarEmpleado.Text = "Agregar Departamento";
            // 
            // cbxTipoDepto
            // 
            this.cbxTipoDepto.FormattingEnabled = true;
            this.cbxTipoDepto.Location = new System.Drawing.Point(183, 231);
            this.cbxTipoDepto.Name = "cbxTipoDepto";
            this.cbxTipoDepto.Size = new System.Drawing.Size(185, 21);
            this.cbxTipoDepto.TabIndex = 54;
            this.cbxTipoDepto.SelectedIndexChanged += new System.EventHandler(this.cbxTipoDepto_SelectedIndexChanged);
            // 
            // cbxEstadoDepa
            // 
            this.cbxEstadoDepa.FormattingEnabled = true;
            this.cbxEstadoDepa.Location = new System.Drawing.Point(183, 258);
            this.cbxEstadoDepa.Name = "cbxEstadoDepa";
            this.cbxEstadoDepa.Size = new System.Drawing.Size(185, 21);
            this.cbxEstadoDepa.TabIndex = 56;
            // 
            // lblEstadoDepa
            // 
            this.lblEstadoDepa.AutoSize = true;
            this.lblEstadoDepa.Location = new System.Drawing.Point(20, 265);
            this.lblEstadoDepa.Name = "lblEstadoDepa";
            this.lblEstadoDepa.Size = new System.Drawing.Size(127, 13);
            this.lblEstadoDepa.TabIndex = 55;
            this.lblEstadoDepa.Text = "Estado del Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Número Estrellas";
            // 
            // txtEstrellas
            // 
            this.txtEstrellas.Location = new System.Drawing.Point(183, 187);
            this.txtEstrellas.Name = "txtEstrellas";
            this.txtEstrellas.Size = new System.Drawing.Size(64, 20);
            this.txtEstrellas.TabIndex = 58;
            // 
            // AgregarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEstrellas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEstadoDepa);
            this.Controls.Add(this.lblEstadoDepa);
            this.Controls.Add(this.cbxTipoDepto);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgreDepto);
            this.Controls.Add(this.lblTipoDepa);
            this.Controls.Add(this.lblIDEstado);
            this.Controls.Add(this.lblDesDepto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescDepto);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblAgregarEmpleado);
            this.Name = "AgregarDepartamento";
            this.Text = "AgregarDepartamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgreDepto;
        private System.Windows.Forms.Label lblTipoDepa;
        private System.Windows.Forms.Label lblIDEstado;
        private System.Windows.Forms.Label lblDesDepto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescDepto;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblAgregarEmpleado;
        private System.Windows.Forms.ComboBox cbxTipoDepto;
        private System.Windows.Forms.ComboBox cbxEstadoDepa;
        private System.Windows.Forms.Label lblEstadoDepa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstrellas;
    }
}