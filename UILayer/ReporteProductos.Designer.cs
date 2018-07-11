namespace UILayer
{
    partial class ReporteProductos
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
            this.ingresarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.singularTextBox = new System.Windows.Forms.TextBox();
            this.ofertasTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridVentas = new System.Windows.Forms.DataGridView();
            this.cerrarButton = new System.Windows.Forms.Button();
            this.fechaInput = new System.Windows.Forms.MonthCalendar();
            this.codeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // codeGroupBox
            // 
            this.codeGroupBox.Controls.Add(this.ingresarButton);
            this.codeGroupBox.Controls.Add(this.label1);
            this.codeGroupBox.Controls.Add(this.codeTextBox);
            this.codeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeGroupBox.Location = new System.Drawing.Point(13, 13);
            this.codeGroupBox.Name = "codeGroupBox";
            this.codeGroupBox.Size = new System.Drawing.Size(662, 88);
            this.codeGroupBox.TabIndex = 0;
            this.codeGroupBox.TabStop = false;
            this.codeGroupBox.Text = "Codigo de Barra";
            // 
            // ingresarButton
            // 
            this.ingresarButton.Location = new System.Drawing.Point(455, 33);
            this.ingresarButton.Name = "ingresarButton";
            this.ingresarButton.Size = new System.Drawing.Size(154, 46);
            this.ingresarButton.TabIndex = 2;
            this.ingresarButton.Text = "Ingresar";
            this.ingresarButton.UseVisualStyleBackColor = true;
            this.ingresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(176, 37);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(203, 26);
            this.codeTextBox.TabIndex = 0;
            this.codeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.singularTextBox);
            this.groupBox1.Controls.Add(this.ofertasTextBox);
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridVentas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 371);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // singularTextBox
            // 
            this.singularTextBox.Location = new System.Drawing.Point(342, 114);
            this.singularTextBox.Name = "singularTextBox";
            this.singularTextBox.Size = new System.Drawing.Size(104, 26);
            this.singularTextBox.TabIndex = 6;
            // 
            // ofertasTextBox
            // 
            this.ofertasTextBox.Location = new System.Drawing.Point(342, 73);
            this.ofertasTextBox.Name = "ofertasTextBox";
            this.ofertasTextBox.Size = new System.Drawing.Size(103, 26);
            this.ofertasTextBox.TabIndex = 5;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(342, 34);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(103, 26);
            this.totalTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de Ventas en Singular :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de Ventas en Ofertas :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Ventas Totales :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridVentas
            // 
            this.dataGridVentas.AllowUserToAddRows = false;
            this.dataGridVentas.AllowUserToDeleteRows = false;
            this.dataGridVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentas.Location = new System.Drawing.Point(7, 158);
            this.dataGridVentas.Name = "dataGridVentas";
            this.dataGridVentas.RowTemplate.Height = 24;
            this.dataGridVentas.Size = new System.Drawing.Size(652, 191);
            this.dataGridVentas.TabIndex = 0;
            // 
            // cerrarButton
            // 
            this.cerrarButton.Location = new System.Drawing.Point(267, 699);
            this.cerrarButton.Name = "cerrarButton";
            this.cerrarButton.Size = new System.Drawing.Size(146, 53);
            this.cerrarButton.TabIndex = 2;
            this.cerrarButton.Text = "Cerrar";
            this.cerrarButton.UseVisualStyleBackColor = true;
            this.cerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // fechaInput
            // 
            this.fechaInput.Location = new System.Drawing.Point(189, 104);
            this.fechaInput.Name = "fechaInput";
            this.fechaInput.TabIndex = 3;
            // 
            // ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 764);
            this.Controls.Add(this.fechaInput);
            this.Controls.Add(this.cerrarButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.codeGroupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(702, 811);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(702, 811);
            this.Name = "ReporteProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteProductos";
            this.codeGroupBox.ResumeLayout(false);
            this.codeGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox codeGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cerrarButton;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridVentas;
        private System.Windows.Forms.MonthCalendar fechaInput;
        private System.Windows.Forms.TextBox singularTextBox;
        private System.Windows.Forms.TextBox ofertasTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
    }
}