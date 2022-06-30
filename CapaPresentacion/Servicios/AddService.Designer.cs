
namespace CapaPresentacion
{
    partial class CreateServiceBooking
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCrearServicio = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.txtNumDireccion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxComuna = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.textDireccionSucursal = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip5.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crear Servicio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 100);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click_1);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click_1);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(133, 100);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem1.Text = "Listar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem2.Text = "Agregar";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem3.Text = "Editar";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem4.Text = "Eliminar";
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16});
            this.contextMenuStrip5.Name = "contextMenuStrip1";
            this.contextMenuStrip5.Size = new System.Drawing.Size(133, 100);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem13.Text = "Listar";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem14.Text = "Agregar";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem15.Text = "Editar";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem16.Text = "Eliminar";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.contextMenuStrip3.Name = "contextMenuStrip1";
            this.contextMenuStrip3.Size = new System.Drawing.Size(133, 100);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem5.Text = "Listar";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem6.Text = "Agregar";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem7.Text = "Editar";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem8.Text = "Eliminar";
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.contextMenuStrip4.Name = "contextMenuStrip1";
            this.contextMenuStrip4.Size = new System.Drawing.Size(133, 100);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem9.Text = "Listar";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem10.Text = "Agregar";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem11.Text = "Editar";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem12.Text = "Eliminar";
            // 
            // btnCrearServicio
            // 
            this.btnCrearServicio.Location = new System.Drawing.Point(496, 467);
            this.btnCrearServicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearServicio.Name = "btnCrearServicio";
            this.btnCrearServicio.Size = new System.Drawing.Size(149, 28);
            this.btnCrearServicio.TabIndex = 15;
            this.btnCrearServicio.Text = "Crear Servicio";
            this.btnCrearServicio.UseVisualStyleBackColor = true;
            this.btnCrearServicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(193, 187);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 31;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(193, 142);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(132, 22);
            this.txtIVA.TabIndex = 30;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(193, 99);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 22);
            this.txtPrecio.TabIndex = 29;
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(193, 57);
            this.txtNombreServicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(132, 22);
            this.txtNombreServicio.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre de Servicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tipo de Servicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dirección sucursal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Valor total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 108);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Precio";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 151);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "IVA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(369, 108);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 17);
            this.label15.TabIndex = 36;
            this.label15.Text = "Descripción de servicio";
            // 
            // comboBoxTipoServicio
            // 
            this.comboBoxTipoServicio.FormattingEnabled = true;
            this.comboBoxTipoServicio.Location = new System.Drawing.Point(496, 57);
            this.comboBoxTipoServicio.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            this.comboBoxTipoServicio.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTipoServicio.TabIndex = 38;
            this.comboBoxTipoServicio.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoServicio_SelectedIndexChanged);
            // 
            // txtNumDireccion
            // 
            this.txtNumDireccion.Location = new System.Drawing.Point(193, 270);
            this.txtNumDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumDireccion.Name = "txtNumDireccion";
            this.txtNumDireccion.Size = new System.Drawing.Size(132, 22);
            this.txtNumDireccion.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 279);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 17);
            this.label17.TabIndex = 40;
            this.label17.Text = "Numero Direccion";
            // 
            // comboBoxComuna
            // 
            this.comboBoxComuna.FormattingEnabled = true;
            this.comboBoxComuna.Location = new System.Drawing.Point(189, 311);
            this.comboBoxComuna.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxComuna.Name = "comboBoxComuna";
            this.comboBoxComuna.Size = new System.Drawing.Size(160, 24);
            this.comboBoxComuna.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 321);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 17);
            this.label16.TabIndex = 42;
            this.label16.Text = "Comuna";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(372, 144);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(284, 194);
            this.txtDescripcion.TabIndex = 44;
            this.txtDescripcion.Text = "";
            // 
            // textDireccionSucursal
            // 
            this.textDireccionSucursal.Location = new System.Drawing.Point(193, 232);
            this.textDireccionSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.textDireccionSucursal.Name = "textDireccionSucursal";
            this.textDireccionSucursal.Size = new System.Drawing.Size(132, 22);
            this.textDireccionSucursal.TabIndex = 45;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(36, 467);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 28);
            this.btnVolver.TabIndex = 46;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // CreateServiceBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(709, 521);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.textDireccionSucursal);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.comboBoxComuna);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtNumDireccion);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBoxTipoServicio);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCrearServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateServiceBooking";
            this.Text = "MantenedorServicioReserva";
            this.Load += new System.EventHandler(this.MantenedorServicioReserva_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip5.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.Button btnCrearServicio;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxTipoServicio;
        private System.Windows.Forms.TextBox txtNumDireccion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxComuna;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.TextBox textDireccionSucursal;
        private System.Windows.Forms.Button btnVolver;
    }
}