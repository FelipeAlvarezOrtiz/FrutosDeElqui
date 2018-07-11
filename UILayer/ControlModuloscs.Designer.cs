namespace UILayer
{
    partial class ControlModuloscs
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
            this.addNuevoProducto = new System.Windows.Forms.Button();
            this.modificarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNuevoProducto
            // 
            this.addNuevoProducto.Location = new System.Drawing.Point(12, 26);
            this.addNuevoProducto.Name = "addNuevoProducto";
            this.addNuevoProducto.Size = new System.Drawing.Size(183, 157);
            this.addNuevoProducto.TabIndex = 0;
            this.addNuevoProducto.Text = "Agregar Nuevo Producto";
            this.addNuevoProducto.UseVisualStyleBackColor = true;
            this.addNuevoProducto.Click += new System.EventHandler(this.AgregarProductoEvento);
            // 
            // modificarProducto
            // 
            this.modificarProducto.Location = new System.Drawing.Point(241, 26);
            this.modificarProducto.Name = "modificarProducto";
            this.modificarProducto.Size = new System.Drawing.Size(189, 157);
            this.modificarProducto.TabIndex = 2;
            this.modificarProducto.Text = "Modificar Producto Existente";
            this.modificarProducto.UseVisualStyleBackColor = true;
            this.modificarProducto.Click += new System.EventHandler(this.ModificarProductoEvent);
            // 
            // ControlModuloscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 228);
            this.Controls.Add(this.modificarProducto);
            this.Controls.Add(this.addNuevoProducto);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 275);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 275);
            this.Name = "ControlModuloscs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Modulos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNuevoProducto;
        private System.Windows.Forms.Button modificarProducto;
    }
}