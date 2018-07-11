namespace UILayer
{
    partial class DetalleVenta
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
            this.okButon = new System.Windows.Forms.Button();
            this.anularButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productosGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // okButon
            // 
            this.okButon.Location = new System.Drawing.Point(494, 411);
            this.okButon.Name = "okButon";
            this.okButon.Size = new System.Drawing.Size(154, 51);
            this.okButon.TabIndex = 0;
            this.okButon.Text = "Aceptar";
            this.okButon.UseVisualStyleBackColor = true;
            this.okButon.Click += new System.EventHandler(this.AceptarClickEvent);
            // 
            // anularButton
            // 
            this.anularButton.Location = new System.Drawing.Point(12, 411);
            this.anularButton.Name = "anularButton";
            this.anularButton.Size = new System.Drawing.Size(154, 51);
            this.anularButton.TabIndex = 1;
            this.anularButton.Text = "Anular Venta";
            this.anularButton.UseVisualStyleBackColor = true;
            this.anularButton.Click += new System.EventHandler(this.AnularVentaEvent);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productosGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 393);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles de Producto";
            // 
            // productosGridView
            // 
            this.productosGridView.AllowUserToAddRows = false;
            this.productosGridView.AllowUserToDeleteRows = false;
            this.productosGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productosGridView.Location = new System.Drawing.Point(3, 18);
            this.productosGridView.Name = "productosGridView";
            this.productosGridView.RowTemplate.Height = 24;
            this.productosGridView.Size = new System.Drawing.Size(630, 372);
            this.productosGridView.TabIndex = 0;
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 476);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.anularButton);
            this.Controls.Add(this.okButon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Venta";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButon;
        private System.Windows.Forms.Button anularButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView productosGridView;
    }
}