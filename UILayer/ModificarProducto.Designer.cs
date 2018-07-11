namespace UILayer
{
    partial class ModificarProducto
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
            this.codeGroup = new System.Windows.Forms.GroupBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.groupProductData = new System.Windows.Forms.GroupBox();
            this.validezCheckBox = new System.Windows.Forms.CheckBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.priceMayorTextBox = new System.Windows.Forms.TextBox();
            this.priceMinorTextBox = new System.Windows.Forms.TextBox();
            this.medidaTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modifyAccept = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.codeGroup.SuspendLayout();
            this.groupProductData.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeGroup
            // 
            this.codeGroup.Controls.Add(this.codeTextBox);
            this.codeGroup.Controls.Add(this.codeLabel);
            this.codeGroup.Location = new System.Drawing.Point(13, 13);
            this.codeGroup.Name = "codeGroup";
            this.codeGroup.Size = new System.Drawing.Size(402, 87);
            this.codeGroup.TabIndex = 0;
            this.codeGroup.TabStop = false;
            this.codeGroup.Text = "Codigo de Barra";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(166, 34);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(150, 26);
            this.codeTextBox.TabIndex = 1;
            this.codeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKeyPressEvent);
            // 
            // codeLabel
            // 
            this.codeLabel.Location = new System.Drawing.Point(17, 34);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(143, 26);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "Codigo de Barra :";
            this.codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupProductData
            // 
            this.groupProductData.Controls.Add(this.stockTextBox);
            this.groupProductData.Controls.Add(this.label6);
            this.groupProductData.Controls.Add(this.validezCheckBox);
            this.groupProductData.Controls.Add(this.categoriaTextBox);
            this.groupProductData.Controls.Add(this.priceMayorTextBox);
            this.groupProductData.Controls.Add(this.priceMinorTextBox);
            this.groupProductData.Controls.Add(this.medidaTextBox);
            this.groupProductData.Controls.Add(this.nameTextBox);
            this.groupProductData.Controls.Add(this.label5);
            this.groupProductData.Controls.Add(this.label4);
            this.groupProductData.Controls.Add(this.label3);
            this.groupProductData.Controls.Add(this.label2);
            this.groupProductData.Controls.Add(this.label1);
            this.groupProductData.Location = new System.Drawing.Point(13, 107);
            this.groupProductData.Name = "groupProductData";
            this.groupProductData.Size = new System.Drawing.Size(402, 340);
            this.groupProductData.TabIndex = 1;
            this.groupProductData.TabStop = false;
            this.groupProductData.Text = "Datos de Producto";
            // 
            // validezCheckBox
            // 
            this.validezCheckBox.Location = new System.Drawing.Point(116, 302);
            this.validezCheckBox.Name = "validezCheckBox";
            this.validezCheckBox.Size = new System.Drawing.Size(188, 32);
            this.validezCheckBox.TabIndex = 11;
            this.validezCheckBox.Text = "Validez de Producto";
            this.validezCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.Location = new System.Drawing.Point(166, 225);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(215, 26);
            this.categoriaTextBox.TabIndex = 10;
            // 
            // priceMayorTextBox
            // 
            this.priceMayorTextBox.Location = new System.Drawing.Point(166, 179);
            this.priceMayorTextBox.Name = "priceMayorTextBox";
            this.priceMayorTextBox.Size = new System.Drawing.Size(215, 26);
            this.priceMayorTextBox.TabIndex = 9;
            // 
            // priceMinorTextBox
            // 
            this.priceMinorTextBox.Location = new System.Drawing.Point(166, 134);
            this.priceMinorTextBox.Name = "priceMinorTextBox";
            this.priceMinorTextBox.Size = new System.Drawing.Size(215, 26);
            this.priceMinorTextBox.TabIndex = 8;
            // 
            // medidaTextBox
            // 
            this.medidaTextBox.Location = new System.Drawing.Point(166, 86);
            this.medidaTextBox.Name = "medidaTextBox";
            this.medidaTextBox.Size = new System.Drawing.Size(215, 26);
            this.medidaTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(166, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(215, 26);
            this.nameTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Categoría :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio al mayor:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio al detalle:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medida :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modifyAccept
            // 
            this.modifyAccept.Location = new System.Drawing.Point(297, 453);
            this.modifyAccept.Name = "modifyAccept";
            this.modifyAccept.Size = new System.Drawing.Size(118, 38);
            this.modifyAccept.TabIndex = 2;
            this.modifyAccept.Text = "Aceptar";
            this.modifyAccept.UseVisualStyleBackColor = true;
            this.modifyAccept.Click += new System.EventHandler(this.ModifyAccept_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(13, 453);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(118, 38);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelEvent);
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(166, 264);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(215, 26);
            this.stockTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(-1, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock en Inventario:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 503);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.modifyAccept);
            this.Controls.Add(this.groupProductData);
            this.Controls.Add(this.codeGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 501);
            this.Name = "ModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Producto";
            this.codeGroup.ResumeLayout(false);
            this.codeGroup.PerformLayout();
            this.groupProductData.ResumeLayout(false);
            this.groupProductData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox codeGroup;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.GroupBox groupProductData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modifyAccept;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.TextBox priceMayorTextBox;
        private System.Windows.Forms.TextBox priceMinorTextBox;
        private System.Windows.Forms.TextBox medidaTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox validezCheckBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Label label6;
    }
}