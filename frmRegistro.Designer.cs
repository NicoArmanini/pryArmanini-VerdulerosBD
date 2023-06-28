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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.cmbNombreVendedor = new System.Windows.Forms.ComboBox();
            this.cmbNombreProducto = new System.Windows.Forms.ComboBox();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.lblKilos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVerduleria
            // 
            this.lblVerduleria.AutoSize = true;
            this.lblVerduleria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.lblVerduleria.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerduleria.ForeColor = System.Drawing.Color.Black;
            this.lblVerduleria.Location = new System.Drawing.Point(56, 31);
            this.lblVerduleria.Name = "lblVerduleria";
            this.lblVerduleria.Size = new System.Drawing.Size(133, 29);
            this.lblVerduleria.TabIndex = 0;
            this.lblVerduleria.Text = "Verduleria";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Location = new System.Drawing.Point(52, 34);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(93, 13);
            this.lblNombreVendedor.TabIndex = 2;
            this.lblNombreVendedor.Text = "Nombre Vendedor";
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGrabar.Location = new System.Drawing.Point(117, 379);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(93, 34);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(52, 98);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(90, 13);
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
            this.mrcRegistro.Location = new System.Drawing.Point(31, 78);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(190, 287);
            this.mrcRegistro.TabIndex = 7;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(21, 194);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(147, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(55, 169);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(88, 13);
            this.lblFechaVenta.TabIndex = 11;
            this.lblFechaVenta.Text = "Fecha de Ventas";
            // 
            // cmbNombreVendedor
            // 
            this.cmbNombreVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreVendedor.FormattingEnabled = true;
            this.cmbNombreVendedor.Location = new System.Drawing.Point(43, 62);
            this.cmbNombreVendedor.Name = "cmbNombreVendedor";
            this.cmbNombreVendedor.Size = new System.Drawing.Size(103, 21);
            this.cmbNombreVendedor.TabIndex = 10;
            // 
            // cmbNombreProducto
            // 
            this.cmbNombreProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreProducto.FormattingEnabled = true;
            this.cmbNombreProducto.Location = new System.Drawing.Point(41, 122);
            this.cmbNombreProducto.Name = "cmbNombreProducto";
            this.cmbNombreProducto.Size = new System.Drawing.Size(104, 21);
            this.cmbNombreProducto.TabIndex = 9;
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(41, 257);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(104, 20);
            this.txtKilos.TabIndex = 8;
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(74, 232);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(29, 13);
            this.lblKilos.TabIndex = 7;
            this.lblKilos.Text = "Kilos";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.Location = new System.Drawing.Point(11, 381);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 32);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::pryArmanini_VerdulerosBD.Properties.Resources.verduu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(237, 428);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcRegistro);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblVerduleria);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

