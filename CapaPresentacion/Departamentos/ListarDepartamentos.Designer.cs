
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
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dataGridViewDepartamentos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamentos)).BeginInit();
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
            // dataGridViewDepartamentos
            // 
            this.dataGridViewDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartamentos.Location = new System.Drawing.Point(46, 125);
            this.dataGridViewDepartamentos.Name = "dataGridViewDepartamentos";
            this.dataGridViewDepartamentos.Size = new System.Drawing.Size(717, 308);
            this.dataGridViewDepartamentos.TabIndex = 8;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(628, 90);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
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
            // ListarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dataGridViewDepartamentos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Name = "ListarDepartamentos";
            this.Text = "ListarDepartamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dataGridViewDepartamentos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
    }
}