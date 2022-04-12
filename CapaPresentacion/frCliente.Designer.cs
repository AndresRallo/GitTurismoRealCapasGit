
namespace CapaPresentacion
{
    partial class frCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.conectaPrueba = new System.Windows.Forms.Button();
            this.btnProbarCon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Controls.Add(this.lblRut);
            this.groupBox1.Location = new System.Drawing.Point(300, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(67, 186);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(54, 144);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 3;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(54, 67);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(100, 20);
            this.txtRut.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(49, 109);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(110, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Ingrese la Contraseña";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(70, 32);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(68, 13);
            this.lblRut.TabIndex = 0;
            this.lblRut.Text = "Ingrese RUT";
            // 
            // conectaPrueba
            // 
            this.conectaPrueba.Location = new System.Drawing.Point(300, 363);
            this.conectaPrueba.Name = "conectaPrueba";
            this.conectaPrueba.Size = new System.Drawing.Size(200, 23);
            this.conectaPrueba.TabIndex = 5;
            this.conectaPrueba.Text = "Limpiar";
            this.conectaPrueba.UseVisualStyleBackColor = true;
            this.conectaPrueba.Click += new System.EventHandler(this.conectaPrueba_Click);
            // 
            // btnProbarCon
            // 
            this.btnProbarCon.Location = new System.Drawing.Point(300, 403);
            this.btnProbarCon.Name = "btnProbarCon";
            this.btnProbarCon.Size = new System.Drawing.Size(200, 23);
            this.btnProbarCon.TabIndex = 6;
            this.btnProbarCon.Text = "ProbarConexion";
            this.btnProbarCon.UseVisualStyleBackColor = true;
            this.btnProbarCon.Click += new System.EventHandler(this.btnProbarCon_Click);
            // 
            // frCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProbarCon);
            this.Controls.Add(this.conectaPrueba);
            this.Controls.Add(this.groupBox1);
            this.Name = "frCliente";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button conectaPrueba;
        private System.Windows.Forms.Button btnProbarCon;
    }
}

