namespace Principalito.cs
{
    partial class GUpdateProducto
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
            this.txtCodigoProductoEditar = new System.Windows.Forms.TextBox();
            this.txtNombreProductoEditar = new System.Windows.Forms.TextBox();
            this.txtCantidadProductoEditar = new System.Windows.Forms.TextBox();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.btnVolverEditarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorProductoEditar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigoProductoEditar
            // 
            this.txtCodigoProductoEditar.Location = new System.Drawing.Point(62, 82);
            this.txtCodigoProductoEditar.Name = "txtCodigoProductoEditar";
            this.txtCodigoProductoEditar.Size = new System.Drawing.Size(182, 20);
            this.txtCodigoProductoEditar.TabIndex = 0;
            // 
            // txtNombreProductoEditar
            // 
            this.txtNombreProductoEditar.Location = new System.Drawing.Point(62, 138);
            this.txtNombreProductoEditar.Name = "txtNombreProductoEditar";
            this.txtNombreProductoEditar.Size = new System.Drawing.Size(182, 20);
            this.txtNombreProductoEditar.TabIndex = 1;
            // 
            // txtCantidadProductoEditar
            // 
            this.txtCantidadProductoEditar.Location = new System.Drawing.Point(62, 193);
            this.txtCantidadProductoEditar.Name = "txtCantidadProductoEditar";
            this.txtCantidadProductoEditar.Size = new System.Drawing.Size(182, 20);
            this.txtCantidadProductoEditar.TabIndex = 2;
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Location = new System.Drawing.Point(111, 287);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(89, 44);
            this.btnActualizarProducto.TabIndex = 4;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // btnVolverEditarProducto
            // 
            this.btnVolverEditarProducto.Location = new System.Drawing.Point(220, 326);
            this.btnVolverEditarProducto.Name = "btnVolverEditarProducto";
            this.btnVolverEditarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnVolverEditarProducto.TabIndex = 5;
            this.btnVolverEditarProducto.Text = "Volver";
            this.btnVolverEditarProducto.UseVisualStyleBackColor = true;
            this.btnVolverEditarProducto.Click += new System.EventHandler(this.btnVolverEditarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ventana de Editar Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo del Producto a Editar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nuevo Nombre del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nueva Cantidad del Producto";
            // 
            // txtValorProductoEditar
            // 
            this.txtValorProductoEditar.Location = new System.Drawing.Point(62, 250);
            this.txtValorProductoEditar.Name = "txtValorProductoEditar";
            this.txtValorProductoEditar.Size = new System.Drawing.Size(182, 20);
            this.txtValorProductoEditar.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nuevo Valor del Producto";
            // 
            // GUpdateProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorProductoEditar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverEditarProducto);
            this.Controls.Add(this.btnActualizarProducto);
            this.Controls.Add(this.txtCantidadProductoEditar);
            this.Controls.Add(this.txtNombreProductoEditar);
            this.Controls.Add(this.txtCodigoProductoEditar);
            this.Name = "GUpdateProducto";
            this.Text = "GUpdateProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoProductoEditar;
        private System.Windows.Forms.TextBox txtNombreProductoEditar;
        private System.Windows.Forms.TextBox txtCantidadProductoEditar;
        private System.Windows.Forms.Button btnActualizarProducto;
        private System.Windows.Forms.Button btnVolverEditarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorProductoEditar;
        private System.Windows.Forms.Label label5;
    }
}