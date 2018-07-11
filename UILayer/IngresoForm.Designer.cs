namespace UILayer
{
    partial class IngresoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoForm));
            this.ingresarLabel = new System.Windows.Forms.Label();
            this.montoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.motivoTextBox = new System.Windows.Forms.RichTextBox();
            this.aceptarIngreso = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ingresarLabel
            // 
            this.ingresarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarLabel.Location = new System.Drawing.Point(12, 23);
            this.ingresarLabel.Name = "ingresarLabel";
            this.ingresarLabel.Size = new System.Drawing.Size(167, 23);
            this.ingresarLabel.TabIndex = 0;
            this.ingresarLabel.Text = "Monto  A Ingresar :";
            this.ingresarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // montoBox
            // 
            this.montoBox.Location = new System.Drawing.Point(208, 23);
            this.montoBox.Name = "montoBox";
            this.montoBox.Size = new System.Drawing.Size(191, 22);
            this.montoBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Motivo de Ingreso :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motivoTextBox
            // 
            this.motivoTextBox.Location = new System.Drawing.Point(16, 113);
            this.motivoTextBox.Name = "motivoTextBox";
            this.motivoTextBox.Size = new System.Drawing.Size(408, 150);
            this.motivoTextBox.TabIndex = 3;
            this.motivoTextBox.Text = "";
            // 
            // aceptarIngreso
            // 
            this.aceptarIngreso.Location = new System.Drawing.Point(493, 32);
            this.aceptarIngreso.Name = "aceptarIngreso";
            this.aceptarIngreso.Size = new System.Drawing.Size(171, 40);
            this.aceptarIngreso.TabIndex = 4;
            this.aceptarIngreso.Text = "Aceptar";
            this.aceptarIngreso.UseVisualStyleBackColor = true;
            this.aceptarIngreso.Click += new System.EventHandler(this.AceptarEvent);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(493, 173);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(171, 40);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // IngresoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 275);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.aceptarIngreso);
            this.Controls.Add(this.motivoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.montoBox);
            this.Controls.Add(this.ingresarLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(716, 322);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(716, 322);
            this.Name = "IngresoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Dinero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ingresarLabel;
        private System.Windows.Forms.TextBox montoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox motivoTextBox;
        private System.Windows.Forms.Button aceptarIngreso;
        private System.Windows.Forms.Button cancelButton;
    }
}