namespace Principalito.cs
{
    partial class GCliente
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
            this.txtGCNombreCliente = new System.Windows.Forms.TextBox();
            this.txtGCApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtGCTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtGCCedulaCliente = new System.Windows.Forms.TextBox();
            this.btnGCRegistrarCliente = new System.Windows.Forms.Button();
            this.btnVolverCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGCNombreCliente
            // 
            this.txtGCNombreCliente.Location = new System.Drawing.Point(95, 57);
            this.txtGCNombreCliente.Name = "txtGCNombreCliente";
            this.txtGCNombreCliente.Size = new System.Drawing.Size(164, 20);
            this.txtGCNombreCliente.TabIndex = 0;
            // 
            // txtGCApellidoCliente
            // 
            this.txtGCApellidoCliente.Location = new System.Drawing.Point(95, 100);
            this.txtGCApellidoCliente.Name = "txtGCApellidoCliente";
            this.txtGCApellidoCliente.Size = new System.Drawing.Size(164, 20);
            this.txtGCApellidoCliente.TabIndex = 1;
            // 
            // txtGCTelefonoCliente
            // 
            this.txtGCTelefonoCliente.Location = new System.Drawing.Point(95, 142);
            this.txtGCTelefonoCliente.Name = "txtGCTelefonoCliente";
            this.txtGCTelefonoCliente.Size = new System.Drawing.Size(164, 20);
            this.txtGCTelefonoCliente.TabIndex = 2;
            // 
            // txtGCCedulaCliente
            // 
            this.txtGCCedulaCliente.Location = new System.Drawing.Point(95, 183);
            this.txtGCCedulaCliente.Name = "txtGCCedulaCliente";
            this.txtGCCedulaCliente.Size = new System.Drawing.Size(164, 20);
            this.txtGCCedulaCliente.TabIndex = 3;
            // 
            // btnGCRegistrarCliente
            // 
            this.btnGCRegistrarCliente.Location = new System.Drawing.Point(134, 220);
            this.btnGCRegistrarCliente.Name = "btnGCRegistrarCliente";
            this.btnGCRegistrarCliente.Size = new System.Drawing.Size(93, 42);
            this.btnGCRegistrarCliente.TabIndex = 4;
            this.btnGCRegistrarCliente.Text = "Registrar";
            this.btnGCRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnGCRegistrarCliente.Click += new System.EventHandler(this.btnGCRegistrarCliente_Click);
            // 
            // btnVolverCliente
            // 
            this.btnVolverCliente.Location = new System.Drawing.Point(260, 250);
            this.btnVolverCliente.Name = "btnVolverCliente";
            this.btnVolverCliente.Size = new System.Drawing.Size(75, 23);
            this.btnVolverCliente.TabIndex = 5;
            this.btnVolverCliente.Text = "Volver";
            this.btnVolverCliente.UseVisualStyleBackColor = true;
            this.btnVolverCliente.Click += new System.EventHandler(this.btnVolverCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registro de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido del Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono del Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cedula del Cliente";
            // 
            // GCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 285);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverCliente);
            this.Controls.Add(this.btnGCRegistrarCliente);
            this.Controls.Add(this.txtGCCedulaCliente);
            this.Controls.Add(this.txtGCTelefonoCliente);
            this.Controls.Add(this.txtGCApellidoCliente);
            this.Controls.Add(this.txtGCNombreCliente);
            this.Name = "GCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGCNombreCliente;
        private System.Windows.Forms.TextBox txtGCApellidoCliente;
        private System.Windows.Forms.TextBox txtGCTelefonoCliente;
        private System.Windows.Forms.TextBox txtGCCedulaCliente;
        private System.Windows.Forms.Button btnGCRegistrarCliente;
        private System.Windows.Forms.Button btnVolverCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}