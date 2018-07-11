namespace UILayer
{
    partial class ModuloInformesVentas
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
            this.components = new System.ComponentModel.Container();
            this.ventasInformesButton = new System.Windows.Forms.Button();
            this.productosInformesButton = new System.Windows.Forms.Button();
            this.toolTipModulos = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ventasInformesButton
            // 
            this.ventasInformesButton.Location = new System.Drawing.Point(25, 38);
            this.ventasInformesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ventasInformesButton.Name = "ventasInformesButton";
            this.ventasInformesButton.Size = new System.Drawing.Size(158, 60);
            this.ventasInformesButton.TabIndex = 0;
            this.ventasInformesButton.Text = "Informe de Ventas";
            this.ventasInformesButton.UseVisualStyleBackColor = true;
            this.ventasInformesButton.Click += new System.EventHandler(this.ventasInformesButton_Click);
            // 
            // productosInformesButton
            // 
            this.productosInformesButton.Location = new System.Drawing.Point(295, 38);
            this.productosInformesButton.Margin = new System.Windows.Forms.Padding(4);
            this.productosInformesButton.Name = "productosInformesButton";
            this.productosInformesButton.Size = new System.Drawing.Size(158, 60);
            this.productosInformesButton.TabIndex = 1;
            this.productosInformesButton.Text = "Ventas de Productos";
            this.productosInformesButton.UseVisualStyleBackColor = true;
            this.productosInformesButton.Click += new System.EventHandler(this.InformeProductosEvent);
            // 
            // ModuloInformesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 139);
            this.Controls.Add(this.productosInformesButton);
            this.Controls.Add(this.ventasInformesButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(484, 186);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(484, 186);
            this.Name = "ModuloInformesVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo de Informes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ventasInformesButton;
        private System.Windows.Forms.Button productosInformesButton;
        private System.Windows.Forms.ToolTip toolTipModulos;
    }
}