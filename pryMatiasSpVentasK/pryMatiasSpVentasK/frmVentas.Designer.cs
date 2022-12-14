namespace pryMatiasSpVentasK
{
    partial class frmVentas
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.lstIdVendedor = new System.Windows.Forms.ComboBox();
            this.lstIdCliente = new System.Windows.Forms.ComboBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroFac = new System.Windows.Forms.TextBox();
            this.lstFactura = new System.Windows.Forms.ComboBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.gbVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(638, 348);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(134, 27);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.lstIdVendedor);
            this.gbVentas.Controls.Add(this.lstIdCliente);
            this.gbVentas.Controls.Add(this.lblPeso);
            this.gbVentas.Controls.Add(this.txtMonto);
            this.gbVentas.Controls.Add(this.dtpFecha);
            this.gbVentas.Controls.Add(this.txtNumeroFac);
            this.gbVentas.Controls.Add(this.lstFactura);
            this.gbVentas.Controls.Add(this.lblFactura);
            this.gbVentas.Controls.Add(this.lblMonto);
            this.gbVentas.Controls.Add(this.lblNumero);
            this.gbVentas.Controls.Add(this.lblVendedor);
            this.gbVentas.Controls.Add(this.lblFecha);
            this.gbVentas.Controls.Add(this.lblCliente);
            this.gbVentas.Location = new System.Drawing.Point(25, 33);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(747, 301);
            this.gbVentas.TabIndex = 8;
            this.gbVentas.TabStop = false;
            this.gbVentas.Text = "Registro de ventas";
            // 
            // lstIdVendedor
            // 
            this.lstIdVendedor.FormattingEnabled = true;
            this.lstIdVendedor.Location = new System.Drawing.Point(606, 164);
            this.lstIdVendedor.Name = "lstIdVendedor";
            this.lstIdVendedor.Size = new System.Drawing.Size(121, 21);
            this.lstIdVendedor.TabIndex = 13;
            // 
            // lstIdCliente
            // 
            this.lstIdCliente.FormattingEnabled = true;
            this.lstIdCliente.Location = new System.Drawing.Point(233, 164);
            this.lstIdCliente.Name = "lstIdCliente";
            this.lstIdCliente.Size = new System.Drawing.Size(121, 21);
            this.lstIdCliente.TabIndex = 12;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(199, 232);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(13, 13);
            this.lblPeso.TabIndex = 8;
            this.lblPeso.Text = "$";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(233, 229);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(121, 20);
            this.txtMonto.TabIndex = 11;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Century Gothic", 5F);
            this.dtpFecha.Location = new System.Drawing.Point(233, 104);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(494, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // txtNumeroFac
            // 
            this.txtNumeroFac.Location = new System.Drawing.Point(606, 43);
            this.txtNumeroFac.Name = "txtNumeroFac";
            this.txtNumeroFac.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroFac.TabIndex = 7;
            // 
            // lstFactura
            // 
            this.lstFactura.FormattingEnabled = true;
            this.lstFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstFactura.Location = new System.Drawing.Point(233, 42);
            this.lstFactura.Name = "lstFactura";
            this.lstFactura.Size = new System.Drawing.Size(121, 21);
            this.lstFactura.TabIndex = 6;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(27, 50);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(79, 13);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "Tipo de factura";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(27, 236);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(389, 46);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(83, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero Factura";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(389, 172);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(67, 13);
            this.lblVendedor.TabIndex = 4;
            this.lblVendedor.Text = "ID Vendedor";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(31, 111);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(27, 172);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(53, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "ID Cliente";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 389);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gbVentas);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.gbVentas.ResumeLayout(false);
            this.gbVentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox gbVentas;
        private System.Windows.Forms.ComboBox lstIdVendedor;
        private System.Windows.Forms.ComboBox lstIdCliente;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNumeroFac;
        private System.Windows.Forms.ComboBox lstFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
    }
}