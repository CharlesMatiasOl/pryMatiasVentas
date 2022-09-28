namespace pryMatiasSpVentasK
{
    partial class frmBusqueda
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
            this.lstCliente = new System.Windows.Forms.ComboBox();
            this.maskFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.facturaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCliente
            // 
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.Location = new System.Drawing.Point(140, 54);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(121, 21);
            this.lstCliente.TabIndex = 11;
            // 
            // maskFecha
            // 
            this.maskFecha.Location = new System.Drawing.Point(140, 97);
            this.maskFecha.Mask = "00/00/0000";
            this.maskFecha.Name = "maskFecha";
            this.maskFecha.Size = new System.Drawing.Size(100, 20);
            this.maskFecha.TabIndex = 12;
            this.maskFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(70, 57);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente";
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facturaTipo,
            this.facturaNumero,
            this.fecha,
            this.clienteId,
            this.vendedorId,
            this.monto});
            this.dgvBusqueda.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvBusqueda.Location = new System.Drawing.Point(22, 213);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.RowHeadersWidth = 51;
            this.dgvBusqueda.RowTemplate.Height = 24;
            this.dgvBusqueda.Size = new System.Drawing.Size(664, 163);
            this.dgvBusqueda.TabIndex = 16;
            // 
            // facturaTipo
            // 
            this.facturaTipo.HeaderText = "Factura Tipo";
            this.facturaTipo.MinimumWidth = 6;
            this.facturaTipo.Name = "facturaTipo";
            this.facturaTipo.Width = 125;
            // 
            // facturaNumero
            // 
            this.facturaNumero.HeaderText = "Factura Numero";
            this.facturaNumero.MinimumWidth = 6;
            this.facturaNumero.Name = "facturaNumero";
            this.facturaNumero.Width = 125;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.Width = 125;
            // 
            // clienteId
            // 
            this.clienteId.HeaderText = "Cliente ID";
            this.clienteId.MinimumWidth = 6;
            this.clienteId.Name = "clienteId";
            this.clienteId.Width = 125;
            // 
            // vendedorId
            // 
            this.vendedorId.HeaderText = "Vendedor ID";
            this.vendedorId.MinimumWidth = 6;
            this.vendedorId.Name = "vendedorId";
            this.vendedorId.Width = 125;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.MinimumWidth = 6;
            this.monto.Name = "monto";
            this.monto.Width = 125;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(70, 100);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(719, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 40);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(719, 277);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(122, 40);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(719, 213);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 40);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(189, 159);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(497, 20);
            this.dtpFecha.TabIndex = 9;
            // 
            // frmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 408);
            this.Controls.Add(this.lstCliente);
            this.Controls.Add(this.maskFecha);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dgvBusqueda);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtpFecha);
            this.Name = "frmBusqueda";
            this.Text = "frmBusqueda";
            this.Load += new System.EventHandler(this.frmBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstCliente;
        private System.Windows.Forms.MaskedTextBox maskFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}