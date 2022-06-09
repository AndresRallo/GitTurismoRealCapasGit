
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
            this.gridServicios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // gridServicios
            // 
            this.gridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServicio,
            this.nombreServicio,
            this.precio,
            this.iva,
            this.valorTotal,
            this.direccion,
            this.numDireccion,
            this.comuna,
            this.tipoServicio,
            this.descripcion});
            this.gridServicios.Location = new System.Drawing.Point(36, 143);
            this.gridServicios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridServicios.Name = "gridServicios";
            this.gridServicios.RowHeadersWidth = 51;
            this.gridServicios.Size = new System.Drawing.Size(1146, 445);
            this.gridServicios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Servicios";
            // 
            // idServicio
            // 
            this.idServicio.HeaderText = "ID";
            this.idServicio.MinimumWidth = 6;
            this.idServicio.Name = "idServicio";
            this.idServicio.Width = 125;
            // 
            // nombreServicio
            // 
            this.nombreServicio.HeaderText = "Nombre";
            this.nombreServicio.MinimumWidth = 6;
            this.nombreServicio.Name = "nombreServicio";
            this.nombreServicio.Width = 125;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.Width = 125;
            // 
            // iva
            // 
            this.iva.HeaderText = "IVA";
            this.iva.MinimumWidth = 6;
            this.iva.Name = "iva";
            this.iva.Width = 125;
            // 
            // valorTotal
            // 
            this.valorTotal.HeaderText = "Total";
            this.valorTotal.MinimumWidth = 6;
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Width = 125;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.Width = 125;
            // 
            // numDireccion
            // 
            this.numDireccion.HeaderText = "Numero Direccion";
            this.numDireccion.MinimumWidth = 6;
            this.numDireccion.Name = "numDireccion";
            this.numDireccion.Width = 125;
            // 
            // comuna
            // 
            this.comuna.HeaderText = "Comuna";
            this.comuna.MinimumWidth = 6;
            this.comuna.Name = "comuna";
            this.comuna.Width = 125;
            // 
            // tipoServicio
            // 
            this.tipoServicio.HeaderText = "Tipo de Servicio";
            this.tipoServicio.MinimumWidth = 6;
            this.tipoServicio.Name = "tipoServicio";
            this.tipoServicio.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 125;
            // 
            // ListService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridServicios);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListService";
            this.Text = "ListService";
            ((System.ComponentModel.ISupportInitialize)(this.gridServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridServicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}