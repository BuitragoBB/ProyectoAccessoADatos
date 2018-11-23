namespace Principalito.cs
{
    partial class GEliminarVenta
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
            this.txtVentaIdEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.btnVolverVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVentaIdEliminar
            // 
            this.txtVentaIdEliminar.Location = new System.Drawing.Point(65, 57);
            this.txtVentaIdEliminar.Name = "txtVentaIdEliminar";
            this.txtVentaIdEliminar.Size = new System.Drawing.Size(150, 20);
            this.txtVentaIdEliminar.TabIndex = 0;
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.Location = new System.Drawing.Point(86, 103);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(109, 46);
            this.btnEliminarVenta.TabIndex = 1;
            this.btnEliminarVenta.Text = "Eliminar";
            this.btnEliminarVenta.UseVisualStyleBackColor = true;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // btnVolverVenta
            // 
            this.btnVolverVenta.Location = new System.Drawing.Point(195, 155);
            this.btnVolverVenta.Name = "btnVolverVenta";
            this.btnVolverVenta.Size = new System.Drawing.Size(69, 28);
            this.btnVolverVenta.TabIndex = 2;
            this.btnVolverVenta.Text = "Volver";
            this.btnVolverVenta.UseVisualStyleBackColor = true;
            this.btnVolverVenta.Click += new System.EventHandler(this.btnVolverVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ventana de Eliminacion de Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 41);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo de la Venta";
            // 
            // GEliminarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverVenta);
            this.Controls.Add(this.btnEliminarVenta);
            this.Controls.Add(this.txtVentaIdEliminar);
            this.Name = "GEliminarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GEliminarVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVentaIdEliminar;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Button btnVolverVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}