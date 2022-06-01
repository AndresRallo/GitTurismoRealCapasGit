
namespace CapaPresentacion
{
    partial class ListarUsuario
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
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvUSER = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblListaUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSER)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(519, 90);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(103, 23);
            this.btnProbarConexion.TabIndex = 10;
            this.btnProbarConexion.Text = "Probar Conexion";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(46, 90);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(135, 23);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvUSER
            // 
            this.dgvUSER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUSER.Location = new System.Drawing.Point(46, 125);
            this.dgvUSER.Name = "dgvUSER";
            this.dgvUSER.Size = new System.Drawing.Size(717, 308);
            this.dgvUSER.TabIndex = 8;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(628, 90);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblListaUser
            // 
            this.lblListaUser.AutoSize = true;
            this.lblListaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblListaUser.Location = new System.Drawing.Point(38, 18);
            this.lblListaUser.Name = "lblListaUser";
            this.lblListaUser.Size = new System.Drawing.Size(328, 46);
            this.lblListaUser.TabIndex = 6;
            this.lblListaUser.Text = "Lista de Usuarios";
            // 
            // ListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvUSER);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblListaUser);
            this.Name = "ListarUsuario";
            this.Text = "ListarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvUSER;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblListaUser;
    }
}