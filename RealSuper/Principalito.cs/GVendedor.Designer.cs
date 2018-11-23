namespace Principalito.cs
{
    partial class GVendedor
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
            this.txtGNombreVendedor = new System.Windows.Forms.TextBox();
            this.txtGApellidoVendedor = new System.Windows.Forms.TextBox();
            this.txtGTelefonoVendedor = new System.Windows.Forms.TextBox();
            this.txtGCedulaVendedor = new System.Windows.Forms.TextBox();
            this.btnRegistrarVendedor = new System.Windows.Forms.Button();
            this.btnVolverVendedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGNombreVendedor
            // 
            this.txtGNombreVendedor.Location = new System.Drawing.Point(100, 62);
            this.txtGNombreVendedor.Name = "txtGNombreVendedor";
            this.txtGNombreVendedor.Size = new System.Drawing.Size(163, 20);
            this.txtGNombreVendedor.TabIndex = 0;
            // 
            // txtGApellidoVendedor
            // 
            this.txtGApellidoVendedor.Location = new System.Drawing.Point(100, 110);
            this.txtGApellidoVendedor.Name = "txtGApellidoVendedor";
            this.txtGApellidoVendedor.Size = new System.Drawing.Size(163, 20);
            this.txtGApellidoVendedor.TabIndex = 1;
            // 
            // txtGTelefonoVendedor
            // 
            this.txtGTelefonoVendedor.Location = new System.Drawing.Point(100, 163);
            this.txtGTelefonoVendedor.Name = "txtGTelefonoVendedor";
            this.txtGTelefonoVendedor.Size = new System.Drawing.Size(163, 20);
            this.txtGTelefonoVendedor.TabIndex = 2;
            // 
            // txtGCedulaVendedor
            // 
            this.txtGCedulaVendedor.Location = new System.Drawing.Point(100, 216);
            this.txtGCedulaVendedor.Name = "txtGCedulaVendedor";
            this.txtGCedulaVendedor.Size = new System.Drawing.Size(163, 20);
            this.txtGCedulaVendedor.TabIndex = 3;
            // 
            // btnRegistrarVendedor
            // 
            this.btnRegistrarVendedor.Location = new System.Drawing.Point(136, 260);
            this.btnRegistrarVendedor.Name = "btnRegistrarVendedor";
            this.btnRegistrarVendedor.Size = new System.Drawing.Size(89, 42);
            this.btnRegistrarVendedor.TabIndex = 4;
            this.btnRegistrarVendedor.Text = "Registrar";
            this.btnRegistrarVendedor.UseVisualStyleBackColor = true;
            this.btnRegistrarVendedor.Click += new System.EventHandler(this.btnRegistrarVendedor_Click);
            // 
            // btnVolverVendedor
            // 
            this.btnVolverVendedor.Location = new System.Drawing.Point(251, 293);
            this.btnVolverVendedor.Name = "btnVolverVendedor";
            this.btnVolverVendedor.Size = new System.Drawing.Size(75, 23);
            this.btnVolverVendedor.TabIndex = 5;
            this.btnVolverVendedor.Text = "Volver";
            this.btnVolverVendedor.UseVisualStyleBackColor = true;
            this.btnVolverVendedor.Click += new System.EventHandler(this.btnVolverVendedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registro de Vendedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido del Vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono del Vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cedula del Vendedor";
            // 
            // GVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 328);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverVendedor);
            this.Controls.Add(this.btnRegistrarVendedor);
            this.Controls.Add(this.txtGCedulaVendedor);
            this.Controls.Add(this.txtGTelefonoVendedor);
            this.Controls.Add(this.txtGApellidoVendedor);
            this.Controls.Add(this.txtGNombreVendedor);
            this.Name = "GVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGNombreVendedor;
        private System.Windows.Forms.TextBox txtGApellidoVendedor;
        private System.Windows.Forms.TextBox txtGTelefonoVendedor;
        private System.Windows.Forms.TextBox txtGCedulaVendedor;
        private System.Windows.Forms.Button btnRegistrarVendedor;
        private System.Windows.Forms.Button btnVolverVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}