namespace UILayer
{
    partial class AgregarStock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelarBoton = new System.Windows.Forms.Button();
            this.ingresarButton = new System.Windows.Forms.Button();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datosProducto = new System.Windows.Forms.GroupBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.disponibilidadTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.medidaTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codeListener = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.dataStockDisponible = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imprimirButton = new System.Windows.Forms.Button();
            this.comentLabel = new System.Windows.Forms.Label();
            this.personaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.motivoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.datosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStockDisponible)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.motivoTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.personaTextBox);
            this.groupBox1.Controls.Add(this.comentLabel);
            this.groupBox1.Controls.Add(this.cancelarBoton);
            this.groupBox1.Controls.Add(this.ingresarButton);
            this.groupBox1.Controls.Add(this.cantidadTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datosProducto);
            this.groupBox1.Controls.Add(this.codeListener);
            this.groupBox1.Controls.Add(this.codeLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 667);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo de Barra";
            // 
            // cancelarBoton
            // 
            this.cancelarBoton.Location = new System.Drawing.Point(404, 427);
            this.cancelarBoton.Name = "cancelarBoton";
            this.cancelarBoton.Size = new System.Drawing.Size(98, 36);
            this.cancelarBoton.TabIndex = 9;
            this.cancelarBoton.Text = "Cancelar";
            this.cancelarBoton.UseVisualStyleBackColor = true;
            this.cancelarBoton.Click += new System.EventHandler(this.CancelarEventClick);
            // 
            // ingresarButton
            // 
            this.ingresarButton.Location = new System.Drawing.Point(404, 385);
            this.ingresarButton.Name = "ingresarButton";
            this.ingresarButton.Size = new System.Drawing.Size(98, 36);
            this.ingresarButton.TabIndex = 8;
            this.ingresarButton.Text = "Ingresar";
            this.ingresarButton.UseVisualStyleBackColor = true;
            this.ingresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(140, 433);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(191, 26);
            this.cantidadTextBox.TabIndex = 7;
            this.cantidadTextBox.TextChanged += new System.EventHandler(this.cantidadTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ingreso",
            "Egreso"});
            this.comboBox1.Location = new System.Drawing.Point(140, 390);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Lote :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datosProducto
            // 
            this.datosProducto.Controls.Add(this.categoriaTextBox);
            this.datosProducto.Controls.Add(this.disponibilidadTextBox);
            this.datosProducto.Controls.Add(this.precioTextBox);
            this.datosProducto.Controls.Add(this.medidaTextBox);
            this.datosProducto.Controls.Add(this.label7);
            this.datosProducto.Controls.Add(this.label6);
            this.datosProducto.Controls.Add(this.label5);
            this.datosProducto.Controls.Add(this.label4);
            this.datosProducto.Controls.Add(this.nameTextBox);
            this.datosProducto.Controls.Add(this.label3);
            this.datosProducto.Location = new System.Drawing.Point(7, 77);
            this.datosProducto.Name = "datosProducto";
            this.datosProducto.Size = new System.Drawing.Size(511, 292);
            this.datosProducto.TabIndex = 3;
            this.datosProducto.TabStop = false;
            this.datosProducto.Text = "Datos de Producto";
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.Location = new System.Drawing.Point(167, 232);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.ReadOnly = true;
            this.categoriaTextBox.Size = new System.Drawing.Size(302, 26);
            this.categoriaTextBox.TabIndex = 18;
            // 
            // disponibilidadTextBox
            // 
            this.disponibilidadTextBox.Location = new System.Drawing.Point(167, 183);
            this.disponibilidadTextBox.Name = "disponibilidadTextBox";
            this.disponibilidadTextBox.ReadOnly = true;
            this.disponibilidadTextBox.Size = new System.Drawing.Size(302, 26);
            this.disponibilidadTextBox.TabIndex = 17;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(167, 135);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(302, 26);
            this.precioTextBox.TabIndex = 16;
            // 
            // medidaTextBox
            // 
            this.medidaTextBox.Location = new System.Drawing.Point(167, 86);
            this.medidaTextBox.Name = "medidaTextBox";
            this.medidaTextBox.ReadOnly = true;
            this.medidaTextBox.Size = new System.Drawing.Size(302, 26);
            this.medidaTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Categoria:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Disponibilidad :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Medida:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(167, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(302, 26);
            this.nameTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codeListener
            // 
            this.codeListener.Location = new System.Drawing.Point(174, 30);
            this.codeListener.Name = "codeListener";
            this.codeListener.Size = new System.Drawing.Size(169, 26);
            this.codeListener.TabIndex = 2;
            this.codeListener.TextChanged += new System.EventHandler(this.codeListener_TextChanged);
            this.codeListener.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterEventCode);
            // 
            // codeLabel
            // 
            this.codeLabel.Location = new System.Drawing.Point(14, 32);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(138, 23);
            this.codeLabel.TabIndex = 1;
            this.codeLabel.Text = "Código de Barra:";
            this.codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataStockDisponible
            // 
            this.dataStockDisponible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStockDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStockDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataStockDisponible.Location = new System.Drawing.Point(3, 18);
            this.dataStockDisponible.Name = "dataStockDisponible";
            this.dataStockDisponible.RowTemplate.Height = 24;
            this.dataStockDisponible.Size = new System.Drawing.Size(553, 587);
            this.dataStockDisponible.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataStockDisponible);
            this.groupBox2.Location = new System.Drawing.Point(557, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 608);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Producto";
            // 
            // imprimirButton
            // 
            this.imprimirButton.Location = new System.Drawing.Point(965, 626);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(148, 53);
            this.imprimirButton.TabIndex = 20;
            this.imprimirButton.Text = "Imprimir Inventario";
            this.imprimirButton.UseVisualStyleBackColor = true;
            this.imprimirButton.Click += new System.EventHandler(this.Imprimir_Inventario);
            // 
            // comentLabel
            // 
            this.comentLabel.Location = new System.Drawing.Point(6, 627);
            this.comentLabel.Name = "comentLabel";
            this.comentLabel.Size = new System.Drawing.Size(172, 24);
            this.comentLabel.TabIndex = 10;
            this.comentLabel.Text = "Persona que recibe :";
            this.comentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comentLabel.UseCompatibleTextRendering = true;
            // 
            // personaTextBox
            // 
            this.personaTextBox.Location = new System.Drawing.Point(184, 625);
            this.personaTextBox.Name = "personaTextBox";
            this.personaTextBox.Size = new System.Drawing.Size(292, 26);
            this.personaTextBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(14, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Motivo :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motivoTextBox
            // 
            this.motivoTextBox.Location = new System.Drawing.Point(140, 486);
            this.motivoTextBox.Multiline = true;
            this.motivoTextBox.Name = "motivoTextBox";
            this.motivoTextBox.Size = new System.Drawing.Size(364, 122);
            this.motivoTextBox.TabIndex = 13;
            // 
            // AgregarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 691);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Inventario";
            this.Load += new System.EventHandler(this.OnLoadFormEvent);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.datosProducto.ResumeLayout(false);
            this.datosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStockDisponible)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox codeListener;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Button cancelarBoton;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox datosProducto;
        private System.Windows.Forms.DataGridView dataStockDisponible;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.TextBox disponibilidadTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox medidaTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button imprimirButton;
        private System.Windows.Forms.TextBox motivoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox personaTextBox;
        private System.Windows.Forms.Label comentLabel;
    }
}