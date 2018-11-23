namespace Principalito.cs
{
    partial class GCompra
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
            this.txtGCProductoId = new System.Windows.Forms.TextBox();
            this.txtGCProveedorId = new System.Windows.Forms.TextBox();
            this.txtGCCantidadCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGCFechaTimer = new System.Windows.Forms.DateTimePicker();
            this.btnGCRegistrarCompra = new System.Windows.Forms.Button();
            this.btnGCVolverCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGCProductoId
            // 
            this.txtGCProductoId.Location = new System.Drawing.Point(79, 83);
            this.txtGCProductoId.Name = "txtGCProductoId";
            this.txtGCProductoId.Size = new System.Drawing.Size(200, 20);
            this.txtGCProductoId.TabIndex = 0;
            // 
            // txtGCProveedorId
            // 
            this.txtGCProveedorId.Location = new System.Drawing.Point(79, 124);
            this.txtGCProveedorId.Name = "txtGCProveedorId";
            this.txtGCProveedorId.Size = new System.Drawing.Size(200, 20);
            this.txtGCProveedorId.TabIndex = 1;
            // 
            // txtGCCantidadCompra
            // 
            this.txtGCCantidadCompra.Location = new System.Drawing.Point(79, 165);
            this.txtGCCantidadCompra.Name = "txtGCCantidadCompra";
            this.txtGCCantidadCompra.Size = new System.Drawing.Size(200, 20);
            this.txtGCCantidadCompra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registro de Compras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo del Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad de Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Compra";
            // 
            // txtGCFechaTimer
            // 
            this.txtGCFechaTimer.Location = new System.Drawing.Point(79, 214);
            this.txtGCFechaTimer.Name = "txtGCFechaTimer";
            this.txtGCFechaTimer.Size = new System.Drawing.Size(200, 20);
            this.txtGCFechaTimer.TabIndex = 10;
            // 
            // btnGCRegistrarCompra
            // 
            this.btnGCRegistrarCompra.Location = new System.Drawing.Point(118, 259);
            this.btnGCRegistrarCompra.Name = "btnGCRegistrarCompra";
            this.btnGCRegistrarCompra.Size = new System.Drawing.Size(102, 41);
            this.btnGCRegistrarCompra.TabIndex = 11;
            this.btnGCRegistrarCompra.Text = "Registrar";
            this.btnGCRegistrarCompra.UseVisualStyleBackColor = true;
            this.btnGCRegistrarCompra.Click += new System.EventHandler(this.btnGCRegistrarCompra_Click);
            // 
            // btnGCVolverCompra
            // 
            this.btnGCVolverCompra.Location = new System.Drawing.Point(255, 302);
            this.btnGCVolverCompra.Name = "btnGCVolverCompra";
            this.btnGCVolverCompra.Size = new System.Drawing.Size(69, 26);
            this.btnGCVolverCompra.TabIndex = 12;
            this.btnGCVolverCompra.Text = "Volver";
            this.btnGCVolverCompra.UseVisualStyleBackColor = true;
            this.btnGCVolverCompra.Click += new System.EventHandler(this.btnGCVolverCompra_Click);
            // 
            // GCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 340);
            this.Controls.Add(this.btnGCVolverCompra);
            this.Controls.Add(this.btnGCRegistrarCompra);
            this.Controls.Add(this.txtGCFechaTimer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGCCantidadCompra);
            this.Controls.Add(this.txtGCProveedorId);
            this.Controls.Add(this.txtGCProductoId);
            this.Name = "GCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCompra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGCProductoId;
        private System.Windows.Forms.TextBox txtGCProveedorId;
        private System.Windows.Forms.TextBox txtGCCantidadCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtGCFechaTimer;
        private System.Windows.Forms.Button btnGCRegistrarCompra;
        private System.Windows.Forms.Button btnGCVolverCompra;
    }
}