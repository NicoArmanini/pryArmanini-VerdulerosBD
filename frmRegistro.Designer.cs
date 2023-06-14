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
            this.lblVerduleria = new System.Windows.Forms.Label();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.cmbNombreVendedor = new System.Windows.Forms.ComboBox();
            this.cmbNombreProducto = new System.Windows.Forms.ComboBox();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.lblKilos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.mrcRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVerduleria
            // 
            this.lblVerduleria.AutoSize = true;
            this.lblVerduleria.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerduleria.Location = new System.Drawing.Point(66, 18);
            this.lblVerduleria.Name = "lblVerduleria";
            this.lblVerduleria.Size = new System.Drawing.Size(133, 29);
            this.lblVerduleria.TabIndex = 0;
            this.lblVerduleria.Text = "Verduleria";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Location = new System.Drawing.Point(68, 30);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(93, 13);
            this.lblNombreVendedor.TabIndex = 2;
            this.lblNombreVendedor.Text = "Nombre Vendedor";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(190, 418);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(93, 34);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(71, 109);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(90, 13);
            this.lblNombreProducto.TabIndex = 5;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.dtpFecha);
            this.mrcRegistro.Controls.Add(this.lblFechaVenta);
            this.mrcRegistro.Controls.Add(this.cmbNombreVendedor);
            this.mrcRegistro.Controls.Add(this.cmbNombreProducto);
            this.mrcRegistro.Controls.Add(this.txtKilos);
            this.mrcRegistro.Controls.Add(this.lblKilos);
            this.mrcRegistro.Controls.Add(this.lblNombreProducto);
            this.mrcRegistro.Controls.Add(this.lblNombreVendedor);
            this.mrcRegistro.Location = new System.Drawing.Point(12, 61);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(275, 336);
            this.mrcRegistro.TabIndex = 7;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro";
            // 
            // cmbNombreVendedor
            // 
            this.cmbNombreVendedor.FormattingEnabled = true;
            this.cmbNombreVendedor.Location = new System.Drawing.Point(71, 58);
            this.cmbNombreVendedor.Name = "cmbNombreVendedor";
            this.cmbNombreVendedor.Size = new System.Drawing.Size(103, 21);
            this.cmbNombreVendedor.TabIndex = 10;
            // 
            // cmbNombreProducto
            // 
            this.cmbNombreProducto.FormattingEnabled = true;
            this.cmbNombreProducto.Location = new System.Drawing.Point(71, 144);
            this.cmbNombreProducto.Name = "cmbNombreProducto";
            this.cmbNombreProducto.Size = new System.Drawing.Size(104, 21);
            this.cmbNombreProducto.TabIndex = 9;
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(70, 284);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(104, 20);
            this.txtKilos.TabIndex = 8;
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(103, 259);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(29, 13);
            this.lblKilos.TabIndex = 7;
            this.lblKilos.Text = "Kilos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(21, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 32);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(73, 184);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(88, 13);
            this.lblFechaVenta.TabIndex = 11;
            this.lblFechaVenta.Text = "Fecha de Ventas";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(70, 210);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(105, 20);
            this.dtpFecha.TabIndex = 12;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 478);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcRegistro);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblVerduleria);
            this.Name = "frmRegistro";
            this.Text = "Form1";
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
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaVenta;
    }
}

