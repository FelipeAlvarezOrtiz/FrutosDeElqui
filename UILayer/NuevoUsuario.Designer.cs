namespace UILayer
{
    partial class NuevoUsuario
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.rutTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.accessLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(178, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(321, 26);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Mail";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(178, 76);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(321, 26);
            this.mailTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Celular";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // celularTextBox
            // 
            this.celularTextBox.Location = new System.Drawing.Point(178, 127);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(321, 26);
            this.celularTextBox.TabIndex = 5;
            // 
            // rutTextBox
            // 
            this.rutTextBox.Location = new System.Drawing.Point(178, 177);
            this.rutTextBox.Name = "rutTextBox";
            this.rutTextBox.Size = new System.Drawing.Size(321, 26);
            this.rutTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "R.U.T.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contraseña";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(178, 227);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(321, 26);
            this.passTextBox.TabIndex = 9;
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(364, 307);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(135, 47);
            this.aceptarButton.TabIndex = 10;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(16, 307);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 47);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelClick);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nivel de Acceso";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accessLevel
            // 
            this.accessLevel.FormattingEnabled = true;
            this.accessLevel.Items.AddRange(new object[] {
            "Vendedor Normal",
            "Administrador"});
            this.accessLevel.Location = new System.Drawing.Point(179, 268);
            this.accessLevel.Name = "accessLevel";
            this.accessLevel.Size = new System.Drawing.Size(320, 28);
            this.accessLevel.TabIndex = 13;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 366);
            this.Controls.Add(this.accessLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rutTextBox);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(538, 413);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(538, 413);
            this.Name = "NuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox rutTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox accessLevel;
    }
}