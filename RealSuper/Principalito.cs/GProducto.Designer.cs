namespace Principalito.cs
{
    partial class GProducto
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
            this.txtGPNombreProducto = new System.Windows.Forms.TextBox();
            this.txtGPCantidadProducto = new System.Windows.Forms.TextBox();
            this.txtGPValorProducto = new System.Windows.Forms.TextBox();
            this.btnGPRegistrarProducto = new System.Windows.Forms.Button();
            this.btnGPVolverProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGPNombreProducto
            // 
            this.txtGPNombreProducto.Location = new System.Drawing.Point(108, 91);
            this.txtGPNombreProducto.Name = "txtGPNombreProducto";
            this.txtGPNombreProducto.Size = new System.Drawing.Size(151, 20);
            this.txtGPNombreProducto.TabIndex = 0;
            // 
            // txtGPCantidadProducto
            // 
            this.txtGPCantidadProducto.Location = new System.Drawing.Point(108, 128);
            this.txtGPCantidadProducto.Name = "txtGPCantidadProducto";
            this.txtGPCantidadProducto.Size = new System.Drawing.Size(151, 20);
            this.txtGPCantidadProducto.TabIndex = 1;
            // 
            // txtGPValorProducto
            // 
            this.txtGPValorProducto.Location = new System.Drawing.Point(108, 169);
            this.txtGPValorProducto.Name = "txtGPValorProducto";
            this.txtGPValorProducto.Size = new System.Drawing.Size(151, 20);
            this.txtGPValorProducto.TabIndex = 2;
            // 
            // btnGPRegistrarProducto
            // 
            this.btnGPRegistrarProducto.Location = new System.Drawing.Point(139, 221);
            this.btnGPRegistrarProducto.Name = "btnGPRegistrarProducto";
            this.btnGPRegistrarProducto.Size = new System.Drawing.Size(86, 43);
            this.btnGPRegistrarProducto.TabIndex = 3;
            this.btnGPRegistrarProducto.Text = "Registrar";
            this.btnGPRegistrarProducto.UseVisualStyleBackColor = true;
            this.btnGPRegistrarProducto.Click += new System.EventHandler(this.btnGPRegistrarProducto_Click);
            // 
            // btnGPVolverProducto
            // 
            this.btnGPVolverProducto.Location = new System.Drawing.Point(275, 265);
            this.btnGPVolverProducto.Name = "btnGPVolverProducto";
            this.btnGPVolverProducto.Size = new System.Drawing.Size(64, 28);
            this.btnGPVolverProducto.TabIndex = 4;
            this.btnGPVolverProducto.Text = "Volver";
            this.btnGPVolverProducto.UseVisualStyleBackColor = true;
            this.btnGPVolverProducto.Click += new System.EventHandler(this.btnGPVolverProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ventana de Registro Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre del Poducto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor del Producto";
            // 
            // GProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 305);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGPVolverProducto);
            this.Controls.Add(this.btnGPRegistrarProducto);
            this.Controls.Add(this.txtGPValorProducto);
            this.Controls.Add(this.txtGPCantidadProducto);
            this.Controls.Add(this.txtGPNombreProducto);
            this.Name = "GProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGPNombreProducto;
        private System.Windows.Forms.TextBox txtGPCantidadProducto;
        private System.Windows.Forms.TextBox txtGPValorProducto;
        private System.Windows.Forms.Button btnGPRegistrarProducto;
        private System.Windows.Forms.Button btnGPVolverProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}