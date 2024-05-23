namespace app_hdp2
{
    partial class frmVender
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
            this.dtgCarrito = new System.Windows.Forms.DataGridView();
            this.gpFormulario = new System.Windows.Forms.GroupBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarrito)).BeginInit();
            this.gpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCarrito
            // 
            this.dtgCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNombre,
            this.clPrecio});
            this.dtgCarrito.Location = new System.Drawing.Point(12, 48);
            this.dtgCarrito.Name = "dtgCarrito";
            this.dtgCarrito.Size = new System.Drawing.Size(467, 214);
            this.dtgCarrito.TabIndex = 0;
            // 
            // gpFormulario
            // 
            this.gpFormulario.Controls.Add(this.cbProducto);
            this.gpFormulario.Controls.Add(this.lblProducto);
            this.gpFormulario.Controls.Add(this.btnAgregar);
            this.gpFormulario.Location = new System.Drawing.Point(499, 48);
            this.gpFormulario.Name = "gpFormulario";
            this.gpFormulario.Size = new System.Drawing.Size(289, 214);
            this.gpFormulario.TabIndex = 1;
            this.gpFormulario.TabStop = false;
            this.gpFormulario.Text = "groupBox1";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(66, 16);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(217, 21);
            this.cbProducto.TabIndex = 4;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(7, 16);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Producto:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 167);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 41);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(12, 268);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(92, 41);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(598, 271);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(92, 41);
            this.btnTerminar.TabIndex = 4;
            this.btnTerminar.Text = "Realizar venta";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(696, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 41);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar venta";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(13, 13);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(61, 10);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(212, 21);
            this.cbCliente.TabIndex = 5;
            // 
            // clNombre
            // 
            this.clNombre.HeaderText = "Producto";
            this.clNombre.Name = "clNombre";
            // 
            // clPrecio
            // 
            this.clPrecio.HeaderText = "Precio";
            this.clPrecio.Name = "clPrecio";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.gpFormulario);
            this.Controls.Add(this.dtgCarrito);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarrito)).EndInit();
            this.gpFormulario.ResumeLayout(false);
            this.gpFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCarrito;
        private System.Windows.Forms.GroupBox gpFormulario;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
    }
}