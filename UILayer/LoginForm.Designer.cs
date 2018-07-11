namespace UILayer
{
    partial class LoginForm
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
            this.rutLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.rutTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.placeholder = new System.Windows.Forms.Label();
            this.logoHide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoHide)).BeginInit();
            this.SuspendLayout();
            // 
            // rutLabel
            // 
            this.rutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rutLabel.Location = new System.Drawing.Point(415, 81);
            this.rutLabel.Name = "rutLabel";
            this.rutLabel.Size = new System.Drawing.Size(167, 32);
            this.rutLabel.TabIndex = 1;
            this.rutLabel.Text = "Usuario (R.U.T) :";
            this.rutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passLabel
            // 
            this.passLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passLabel.Location = new System.Drawing.Point(415, 150);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(167, 32);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Contraseña :";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rutTextBox
            // 
            this.rutTextBox.Location = new System.Drawing.Point(598, 84);
            this.rutTextBox.Name = "rutTextBox";
            this.rutTextBox.Size = new System.Drawing.Size(204, 26);
            this.rutTextBox.TabIndex = 3;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(598, 150);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(204, 26);
            this.passTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoginClose);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(633, 229);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(169, 43);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Ingresar";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.IngresarEvent);
            // 
            // placeholder
            // 
            this.placeholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder.Location = new System.Drawing.Point(494, 29);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(224, 29);
            this.placeholder.TabIndex = 7;
            this.placeholder.Text = "¡ Bienvenido !";
            this.placeholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoHide
            // 
            this.logoHide.Image = global::UILayer.Properties.Resources.Logo_Frutos_Elqui;
            this.logoHide.Location = new System.Drawing.Point(26, 29);
            this.logoHide.Name = "logoHide";
            this.logoHide.Size = new System.Drawing.Size(356, 277);
            this.logoHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoHide.TabIndex = 0;
            this.logoHide.TabStop = false;
            this.logoHide.Click += new System.EventHandler(this.LogoSetupHide);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 332);
            this.Controls.Add(this.placeholder);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.rutTextBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.rutLabel);
            this.Controls.Add(this.logoHide);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(848, 379);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(848, 379);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frutos de Elqui";
            ((System.ComponentModel.ISupportInitialize)(this.logoHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoHide;
        private System.Windows.Forms.Label rutLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox rutTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label placeholder;
    }
}

