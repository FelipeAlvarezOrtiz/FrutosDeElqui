namespace UILayer
{
    partial class AgregarProducto
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
            this.codeGroupBox = new System.Windows.Forms.GroupBox();
            this.verificarButton = new System.Windows.Forms.Button();
            this.codigoText = new System.Windows.Forms.TextBox();
            this.codeIdLabel = new System.Windows.Forms.Label();
            this.dataProductGroupBox = new System.Windows.Forms.GroupBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.precioMayorTextBox = new System.Windows.Forms.TextBox();
            this.precioDetalleTextBox = new System.Windows.Forms.TextBox();
            this.medidaTextBo = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ingresarProductoButton = new System.Windows.Forms.Button();
            this.CancelarBoton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.stockInicialTextBox = new System.Windows.Forms.TextBox();
            this.codeGroupBox.SuspendLayout();
            this.dataProductGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeGroupBox
            // 
            this.codeGroupBox.Controls.Add(this.verificarButton);
            this.codeGroupBox.Controls.Add(this.codigoText);
            this.codeGroupBox.Controls.Add(this.codeIdLabel);
            this.codeGroupBox.Location = new System.Drawing.Point(16, 16);
            this.codeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.codeGroupBox.Name = "codeGroupBox";
            this.codeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.codeGroupBox.Size = new System.Drawing.Size(403, 86);
            this.codeGroupBox.TabIndex = 0;
            this.codeGroupBox.TabStop = false;
            this.codeGroupBox.Text = "Codigo de Barra";
            // 
            // verificarButton
            // 
            this.verificarButton.Location = new System.Drawing.Point(268, 26);
            this.verificarButton.Name = "verificarButton";
            this.verificarButton.Size = new System.Drawing.Size(128, 48);
            this.verificarButton.TabIndex = 2;
            this.verificarButton.Text = "Verificar Disponibilidad";
            this.verificarButton.UseVisualStyleBackColor = true;
            this.verificarButton.Click += new System.EventHandler(this.VerificarEvent);
            // 
            // codigoText
            // 
            this.codigoText.Location = new System.Drawing.Point(99, 35);
            this.codigoText.Name = "codigoText";
            this.codigoText.Size = new System.Drawing.Size(163, 26);
            this.codigoText.TabIndex = 1;
            // 
            // codeIdLabel
            // 
            this.codeIdLabel.Location = new System.Drawing.Point(7, 32);
            this.codeIdLabel.Name = "codeIdLabel";
            this.codeIdLabel.Size = new System.Drawing.Size(85, 26);
            this.codeIdLabel.TabIndex = 0;
            this.codeIdLabel.Text = "Codigo :";
            this.codeIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataProductGroupBox
            // 
            this.dataProductGroupBox.Controls.Add(this.stockInicialTextBox);
            this.dataProductGroupBox.Controls.Add(this.label6);
            this.dataProductGroupBox.Controls.Add(this.categoriaTextBox);
            this.dataProductGroupBox.Controls.Add(this.precioMayorTextBox);
            this.dataProductGroupBox.Controls.Add(this.precioDetalleTextBox);
            this.dataProductGroupBox.Controls.Add(this.medidaTextBo);
            this.dataProductGroupBox.Controls.Add(this.nameTextBox);
            this.dataProductGroupBox.Controls.Add(this.label5);
            this.dataProductGroupBox.Controls.Add(this.label4);
            this.dataProductGroupBox.Controls.Add(this.label3);
            this.dataProductGroupBox.Controls.Add(this.label2);
            this.dataProductGroupBox.Controls.Add(this.label1);
            this.dataProductGroupBox.Enabled = false;
            this.dataProductGroupBox.Location = new System.Drawing.Point(16, 124);
            this.dataProductGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.dataProductGroupBox.Name = "dataProductGroupBox";
            this.dataProductGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.dataProductGroupBox.Size = new System.Drawing.Size(403, 261);
            this.dataProductGroupBox.TabIndex = 1;
            this.dataProductGroupBox.TabStop = false;
            this.dataProductGroupBox.Text = "Datos de Producto";
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.Location = new System.Drawing.Point(162, 180);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(234, 26);
            this.categoriaTextBox.TabIndex = 12;
            // 
            // precioMayorTextBox
            // 
            this.precioMayorTextBox.Location = new System.Drawing.Point(161, 139);
            this.precioMayorTextBox.Name = "precioMayorTextBox";
            this.precioMayorTextBox.Size = new System.Drawing.Size(234, 26);
            this.precioMayorTextBox.TabIndex = 11;
            // 
            // precioDetalleTextBox
            // 
            this.precioDetalleTextBox.Location = new System.Drawing.Point(161, 101);
            this.precioDetalleTextBox.Name = "precioDetalleTextBox";
            this.precioDetalleTextBox.Size = new System.Drawing.Size(234, 26);
            this.precioDetalleTextBox.TabIndex = 10;
            // 
            // medidaTextBo
            // 
            this.medidaTextBo.Location = new System.Drawing.Point(161, 60);
            this.medidaTextBo.Name = "medidaTextBo";
            this.medidaTextBo.Size = new System.Drawing.Size(234, 26);
            this.medidaTextBo.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(162, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(234, 26);
            this.nameTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Categoria :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio al Mayor :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio al Detalle :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Medida :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ingresarProductoButton
            // 
            this.ingresarProductoButton.Location = new System.Drawing.Point(293, 392);
            this.ingresarProductoButton.Name = "ingresarProductoButton";
            this.ingresarProductoButton.Size = new System.Drawing.Size(127, 49);
            this.ingresarProductoButton.TabIndex = 2;
            this.ingresarProductoButton.Text = "Aceptar";
            this.ingresarProductoButton.UseVisualStyleBackColor = true;
            this.ingresarProductoButton.Click += new System.EventHandler(this.IngresarProductoButton_Click);
            // 
            // CancelarBoton
            // 
            this.CancelarBoton.Location = new System.Drawing.Point(16, 392);
            this.CancelarBoton.Name = "CancelarBoton";
            this.CancelarBoton.Size = new System.Drawing.Size(127, 49);
            this.CancelarBoton.TabIndex = 3;
            this.CancelarBoton.Text = "Cancelar";
            this.CancelarBoton.UseVisualStyleBackColor = true;
            this.CancelarBoton.Click += new System.EventHandler(this.CancelEvent);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stock Inicial :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockInicialTextBox
            // 
            this.stockInicialTextBox.Location = new System.Drawing.Point(161, 220);
            this.stockInicialTextBox.Name = "stockInicialTextBox";
            this.stockInicialTextBox.Size = new System.Drawing.Size(234, 26);
            this.stockInicialTextBox.TabIndex = 14;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.CancelarBoton);
            this.Controls.Add(this.ingresarProductoButton);
            this.Controls.Add(this.dataProductGroupBox);
            this.Controls.Add(this.codeGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Producto";
            this.codeGroupBox.ResumeLayout(false);
            this.codeGroupBox.PerformLayout();
            this.dataProductGroupBox.ResumeLayout(false);
            this.dataProductGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox codeGroupBox;
        private System.Windows.Forms.Button verificarButton;
        private System.Windows.Forms.TextBox codigoText;
        private System.Windows.Forms.Label codeIdLabel;
        private System.Windows.Forms.GroupBox dataProductGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.TextBox precioMayorTextBox;
        private System.Windows.Forms.TextBox precioDetalleTextBox;
        private System.Windows.Forms.TextBox medidaTextBo;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button ingresarProductoButton;
        private System.Windows.Forms.Button CancelarBoton;
        private System.Windows.Forms.TextBox stockInicialTextBox;
        private System.Windows.Forms.Label label6;
    }
}