namespace UILayer
{
    partial class CrearOferta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearOferta));
            this.especGroupBox = new System.Windows.Forms.GroupBox();
            this.CheckDispoButton = new System.Windows.Forms.Button();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productosGroupBox = new System.Windows.Forms.GroupBox();
            this.productosGridView = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngresarOferta = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.especGroupBox.SuspendLayout();
            this.productosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // especGroupBox
            // 
            this.especGroupBox.Controls.Add(this.CheckDispoButton);
            this.especGroupBox.Controls.Add(this.CodeBox);
            this.especGroupBox.Controls.Add(this.PriceBox);
            this.especGroupBox.Controls.Add(this.NameBox);
            this.especGroupBox.Controls.Add(this.label3);
            this.especGroupBox.Controls.Add(this.label2);
            this.especGroupBox.Controls.Add(this.label1);
            this.especGroupBox.Location = new System.Drawing.Point(12, 12);
            this.especGroupBox.Name = "especGroupBox";
            this.especGroupBox.Size = new System.Drawing.Size(739, 129);
            this.especGroupBox.TabIndex = 0;
            this.especGroupBox.TabStop = false;
            this.especGroupBox.Text = "Especificaciones de la Oferta";
            // 
            // CheckDispoButton
            // 
            this.CheckDispoButton.Location = new System.Drawing.Point(529, 77);
            this.CheckDispoButton.Name = "CheckDispoButton";
            this.CheckDispoButton.Size = new System.Drawing.Size(169, 32);
            this.CheckDispoButton.TabIndex = 6;
            this.CheckDispoButton.Text = "Verificar Disponibilidad";
            this.CheckDispoButton.UseVisualStyleBackColor = true;
            this.CheckDispoButton.Click += new System.EventHandler(this.CheckEvent);
            // 
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(517, 35);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(197, 22);
            this.CodeBox.TabIndex = 5;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(151, 82);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(216, 22);
            this.PriceBox.TabIndex = 4;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(151, 35);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(216, 22);
            this.NameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(382, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo de Oferta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Oferta :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productosGroupBox
            // 
            this.productosGroupBox.Controls.Add(this.productosGridView);
            this.productosGroupBox.Location = new System.Drawing.Point(12, 147);
            this.productosGroupBox.Name = "productosGroupBox";
            this.productosGroupBox.Size = new System.Drawing.Size(739, 367);
            this.productosGroupBox.TabIndex = 1;
            this.productosGroupBox.TabStop = false;
            this.productosGroupBox.Text = "Productos Asociados";
            // 
            // productosGridView
            // 
            this.productosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad});
            this.productosGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productosGridView.Location = new System.Drawing.Point(3, 18);
            this.productosGridView.Name = "productosGridView";
            this.productosGridView.RowTemplate.Height = 24;
            this.productosGridView.Size = new System.Drawing.Size(733, 346);
            this.productosGridView.TabIndex = 0;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.FillWeight = 126.9036F;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.FillWeight = 73.09644F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // IngresarOferta
            // 
            this.IngresarOferta.Location = new System.Drawing.Point(545, 532);
            this.IngresarOferta.Name = "IngresarOferta";
            this.IngresarOferta.Size = new System.Drawing.Size(181, 54);
            this.IngresarOferta.TabIndex = 2;
            this.IngresarOferta.Text = "Ingresar Oferta";
            this.IngresarOferta.UseVisualStyleBackColor = true;
            this.IngresarOferta.Click += new System.EventHandler(this.IngresarOfertaEvent);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(15, 532);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(181, 54);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // CrearOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 598);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.IngresarOferta);
            this.Controls.Add(this.productosGroupBox);
            this.Controls.Add(this.especGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(781, 645);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(781, 645);
            this.Name = "CrearOferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Oferta";
            this.especGroupBox.ResumeLayout(false);
            this.especGroupBox.PerformLayout();
            this.productosGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox especGroupBox;
        private System.Windows.Forms.Button CheckDispoButton;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox productosGroupBox;
        private System.Windows.Forms.DataGridView productosGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button IngresarOferta;
        private System.Windows.Forms.Button cancelar;
    }
}