namespace pryArmanini_VerdulerosBD
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.lblVerduleria = new System.Windows.Forms.Label();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.cmbNombreVendedor = new System.Windows.Forms.ComboBox();
            this.cmbNombreProducto = new System.Windows.Forms.ComboBox();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.lblKilos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.mrcRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVerduleria
            // 
            this.lblVerduleria.AutoSize = true;
            this.lblVerduleria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblVerduleria.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerduleria.ForeColor = System.Drawing.Color.Black;
            this.lblVerduleria.Location = new System.Drawing.Point(75, 38);
            this.lblVerduleria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerduleria.Name = "lblVerduleria";
            this.lblVerduleria.Size = new System.Drawing.Size(165, 35);
            this.lblVerduleria.TabIndex = 0;
            this.lblVerduleria.Text = "Verduleria";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Location = new System.Drawing.Point(69, 42);
            this.lblNombreVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(119, 16);
            this.lblNombreVendedor.TabIndex = 2;
            this.lblNombreVendedor.Text = "Nombre Vendedor";
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGrabar.Location = new System.Drawing.Point(156, 467);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(124, 42);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(69, 120);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(113, 16);
            this.lblNombreProducto.TabIndex = 5;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.BackColor = System.Drawing.Color.Transparent;
            this.mrcRegistro.Controls.Add(this.dtpFecha);
            this.mrcRegistro.Controls.Add(this.lblFechaVenta);
            this.mrcRegistro.Controls.Add(this.cmbNombreVendedor);
            this.mrcRegistro.Controls.Add(this.cmbNombreProducto);
            this.mrcRegistro.Controls.Add(this.txtKilos);
            this.mrcRegistro.Controls.Add(this.lblKilos);
            this.mrcRegistro.Controls.Add(this.lblNombreProducto);
            this.mrcRegistro.Controls.Add(this.lblNombreVendedor);
            this.mrcRegistro.ForeColor = System.Drawing.Color.Black;
            this.mrcRegistro.Location = new System.Drawing.Point(41, 96);
            this.mrcRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Padding = new System.Windows.Forms.Padding(4);
            this.mrcRegistro.Size = new System.Drawing.Size(253, 353);
            this.mrcRegistro.TabIndex = 7;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(73, 208);
            this.lblFechaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(109, 16);
            this.lblFechaVenta.TabIndex = 11;
            this.lblFechaVenta.Text = "Fecha de Ventas";
            // 
            // cmbNombreVendedor
            // 
            this.cmbNombreVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreVendedor.FormattingEnabled = true;
            this.cmbNombreVendedor.Location = new System.Drawing.Point(57, 76);
            this.cmbNombreVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNombreVendedor.Name = "cmbNombreVendedor";
            this.cmbNombreVendedor.Size = new System.Drawing.Size(136, 24);
            this.cmbNombreVendedor.TabIndex = 10;
            // 
            // cmbNombreProducto
            // 
            this.cmbNombreProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreProducto.FormattingEnabled = true;
            this.cmbNombreProducto.Location = new System.Drawing.Point(55, 150);
            this.cmbNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNombreProducto.Name = "cmbNombreProducto";
            this.cmbNombreProducto.Size = new System.Drawing.Size(137, 24);
            this.cmbNombreProducto.TabIndex = 9;
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(55, 316);
            this.txtKilos.Margin = new System.Windows.Forms.Padding(4);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(137, 22);
            this.txtKilos.TabIndex = 8;
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(99, 285);
            this.lblKilos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(36, 16);
            this.lblKilos.TabIndex = 7;
            this.lblKilos.Text = "Kilos";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.Location = new System.Drawing.Point(15, 469);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 39);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(40, 238);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(176, 22);
            this.dtpFecha.TabIndex = 13;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::pryArmanini_VerdulerosBD.Properties.Resources.verduu;
            this.ClientSize = new System.Drawing.Size(316, 527);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcRegistro);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblVerduleria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Ventas";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerduleria;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.ComboBox cmbNombreVendedor;
        private System.Windows.Forms.ComboBox cmbNombreProducto;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}

