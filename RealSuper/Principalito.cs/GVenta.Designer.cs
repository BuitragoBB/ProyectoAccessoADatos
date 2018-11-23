namespace Principalito.cs
{
    partial class GVenta
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
            this.txtGVProductoId = new System.Windows.Forms.TextBox();
            this.txtGVClienteId = new System.Windows.Forms.TextBox();
            this.txtGVVendedorId = new System.Windows.Forms.TextBox();
            this.txtGVCantidadProductos = new System.Windows.Forms.TextBox();
            this.btnGVRegistrarVenta = new System.Windows.Forms.Button();
            this.btnVolerVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGVFechaVentaPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtGVProductoId
            // 
            this.txtGVProductoId.Location = new System.Drawing.Point(87, 58);
            this.txtGVProductoId.Name = "txtGVProductoId";
            this.txtGVProductoId.Size = new System.Drawing.Size(200, 20);
            this.txtGVProductoId.TabIndex = 0;
            // 
            // txtGVClienteId
            // 
            this.txtGVClienteId.Location = new System.Drawing.Point(87, 99);
            this.txtGVClienteId.Name = "txtGVClienteId";
            this.txtGVClienteId.Size = new System.Drawing.Size(200, 20);
            this.txtGVClienteId.TabIndex = 1;
            // 
            // txtGVVendedorId
            // 
            this.txtGVVendedorId.Location = new System.Drawing.Point(87, 139);
            this.txtGVVendedorId.Name = "txtGVVendedorId";
            this.txtGVVendedorId.Size = new System.Drawing.Size(200, 20);
            this.txtGVVendedorId.TabIndex = 2;
            // 
            // txtGVCantidadProductos
            // 
            this.txtGVCantidadProductos.Location = new System.Drawing.Point(87, 180);
            this.txtGVCantidadProductos.Name = "txtGVCantidadProductos";
            this.txtGVCantidadProductos.Size = new System.Drawing.Size(200, 20);
            this.txtGVCantidadProductos.TabIndex = 3;
            // 
            // btnGVRegistrarVenta
            // 
            this.btnGVRegistrarVenta.Location = new System.Drawing.Point(140, 267);
            this.btnGVRegistrarVenta.Name = "btnGVRegistrarVenta";
            this.btnGVRegistrarVenta.Size = new System.Drawing.Size(93, 42);
            this.btnGVRegistrarVenta.TabIndex = 5;
            this.btnGVRegistrarVenta.Text = "Registrar";
            this.btnGVRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnGVRegistrarVenta.Click += new System.EventHandler(this.btnGVRegistrarVenta_Click);
            // 
            // btnVolerVenta
            // 
            this.btnVolerVenta.Location = new System.Drawing.Point(282, 286);
            this.btnVolerVenta.Name = "btnVolerVenta";
            this.btnVolerVenta.Size = new System.Drawing.Size(75, 23);
            this.btnVolerVenta.TabIndex = 6;
            this.btnVolerVenta.Text = "Volver";
            this.btnVolerVenta.UseVisualStyleBackColor = true;
            this.btnVolerVenta.Click += new System.EventHandler(this.btnVolerVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registro de Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo del Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codigo del Vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de Venta";
            // 
            // txtGVFechaVentaPicker
            // 
            this.txtGVFechaVentaPicker.Location = new System.Drawing.Point(87, 226);
            this.txtGVFechaVentaPicker.Name = "txtGVFechaVentaPicker";
            this.txtGVFechaVentaPicker.Size = new System.Drawing.Size(200, 20);
            this.txtGVFechaVentaPicker.TabIndex = 4;
            // 
            // GVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 331);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolerVenta);
            this.Controls.Add(this.btnGVRegistrarVenta);
            this.Controls.Add(this.txtGVFechaVentaPicker);
            this.Controls.Add(this.txtGVCantidadProductos);
            this.Controls.Add(this.txtGVVendedorId);
            this.Controls.Add(this.txtGVClienteId);
            this.Controls.Add(this.txtGVProductoId);
            this.Name = "GVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GVenta";
            this.Load += new System.EventHandler(this.GVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGVProductoId;
        private System.Windows.Forms.TextBox txtGVClienteId;
        private System.Windows.Forms.TextBox txtGVVendedorId;
        private System.Windows.Forms.TextBox txtGVCantidadProductos;
        private System.Windows.Forms.Button btnGVRegistrarVenta;
        private System.Windows.Forms.Button btnVolerVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtGVFechaVentaPicker;
    }
}