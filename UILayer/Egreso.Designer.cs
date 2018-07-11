namespace UILayer
{
    partial class Egreso
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
            this.label1 = new System.Windows.Forms.Label();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.razonTextBox = new System.Windows.Forms.RichTextBox();
            this.acceptEgreso = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto a Egresar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // montoTextBox
            // 
            this.montoTextBox.Location = new System.Drawing.Point(189, 23);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(260, 26);
            this.montoTextBox.TabIndex = 1;
            this.montoTextBox.TextChanged += new System.EventHandler(this.CambioTextoEvent);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razón :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // razonTextBox
            // 
            this.razonTextBox.Location = new System.Drawing.Point(189, 80);
            this.razonTextBox.Name = "razonTextBox";
            this.razonTextBox.Size = new System.Drawing.Size(260, 73);
            this.razonTextBox.TabIndex = 3;
            this.razonTextBox.Text = "Escriba aquí el motivo del egreso";
            this.razonTextBox.Click += new System.EventHandler(this.firstClickEvent);
            // 
            // acceptEgreso
            // 
            this.acceptEgreso.Location = new System.Drawing.Point(508, 23);
            this.acceptEgreso.Name = "acceptEgreso";
            this.acceptEgreso.Size = new System.Drawing.Size(135, 39);
            this.acceptEgreso.TabIndex = 4;
            this.acceptEgreso.Text = "Aceptar";
            this.acceptEgreso.UseVisualStyleBackColor = true;
            this.acceptEgreso.Click += new System.EventHandler(this.acceptEgreso_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(508, 102);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 39);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelarEgresoEvent);
            // 
            // Egreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 165);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptEgreso);
            this.Controls.Add(this.razonTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.montoTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Egreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox razonTextBox;
        private System.Windows.Forms.Button acceptEgreso;
        private System.Windows.Forms.Button cancelButton;
    }
}