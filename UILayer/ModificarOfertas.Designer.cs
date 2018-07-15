namespace UILayer
{
    partial class ModificarOfertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarOfertas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.verificarButton = new System.Windows.Forms.Button();
            this.codeListener = new System.Windows.Forms.TextBox();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.precioOfertaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.modificarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productosAsociadosGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosAsociadosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.verificarButton);
            this.groupBox1.Controls.Add(this.codeListener);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo de Barra";
            // 
            // verificarButton
            // 
            this.verificarButton.Location = new System.Drawing.Point(40, 72);
            this.verificarButton.Name = "verificarButton";
            this.verificarButton.Size = new System.Drawing.Size(109, 37);
            this.verificarButton.TabIndex = 1;
            this.verificarButton.Text = "Ingresar";
            this.verificarButton.UseVisualStyleBackColor = true;
            this.verificarButton.Click += new System.EventHandler(this.IngresarClick);
            // 
            // codeListener
            // 
            this.codeListener.Location = new System.Drawing.Point(23, 34);
            this.codeListener.Name = "codeListener";
            this.codeListener.Size = new System.Drawing.Size(147, 22);
            this.codeListener.TabIndex = 0;
            this.codeListener.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPresionadoEvent);
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.precioOfertaText);
            this.dataGroupBox.Controls.Add(this.label1);
            this.dataGroupBox.Controls.Add(this.nombreBox);
            this.dataGroupBox.Controls.Add(this.labelName);
            this.dataGroupBox.Location = new System.Drawing.Point(236, 13);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(552, 134);
            this.dataGroupBox.TabIndex = 1;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Datos y Especificación";
            // 
            // precioOfertaText
            // 
            this.precioOfertaText.Location = new System.Drawing.Point(183, 79);
            this.precioOfertaText.Name = "precioOfertaText";
            this.precioOfertaText.Size = new System.Drawing.Size(256, 22);
            this.precioOfertaText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Precio de Oferta :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(183, 33);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(256, 22);
            this.nombreBox.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(7, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(158, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nombre :";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(584, 633);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(139, 41);
            this.modificarButton.TabIndex = 2;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.ModifyEvent);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(91, 633);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(139, 41);
            this.cancelarButton.TabIndex = 3;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelEvent);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productosAsociadosGridView);
            this.groupBox2.Location = new System.Drawing.Point(13, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 455);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos Asociados";
            // 
            // productosAsociadosGridView
            // 
            this.productosAsociadosGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productosAsociadosGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productosAsociadosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosAsociadosGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productosAsociadosGridView.Location = new System.Drawing.Point(3, 18);
            this.productosAsociadosGridView.MultiSelect = false;
            this.productosAsociadosGridView.Name = "productosAsociadosGridView";
            this.productosAsociadosGridView.RowHeadersWidth = 60;
            this.productosAsociadosGridView.RowTemplate.Height = 24;
            this.productosAsociadosGridView.Size = new System.Drawing.Size(769, 434);
            this.productosAsociadosGridView.TabIndex = 0;
            // 
            // ModificarOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 698);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(813, 745);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(813, 745);
            this.Name = "ModificarOfertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Ofertas";
            this.Load += new System.EventHandler(this.cargandoForm);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosAsociadosGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button verificarButton;
        private System.Windows.Forms.TextBox codeListener;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.TextBox precioOfertaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView productosAsociadosGridView;
    }
}