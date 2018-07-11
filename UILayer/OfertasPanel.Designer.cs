namespace UILayer
{
    partial class OfertasPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfertasPanel));
            this.CrearOfertasButton = new System.Windows.Forms.Button();
            this.ModificarOfertasForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrearOfertasButton
            // 
            this.CrearOfertasButton.Location = new System.Drawing.Point(30, 43);
            this.CrearOfertasButton.Name = "CrearOfertasButton";
            this.CrearOfertasButton.Size = new System.Drawing.Size(187, 60);
            this.CrearOfertasButton.TabIndex = 0;
            this.CrearOfertasButton.Text = "Crear Ofertas";
            this.CrearOfertasButton.UseVisualStyleBackColor = true;
            this.CrearOfertasButton.Click += new System.EventHandler(this.CrearOfertasForm);
            // 
            // ModificarOfertasForm
            // 
            this.ModificarOfertasForm.Location = new System.Drawing.Point(395, 43);
            this.ModificarOfertasForm.Name = "ModificarOfertasForm";
            this.ModificarOfertasForm.Size = new System.Drawing.Size(187, 60);
            this.ModificarOfertasForm.TabIndex = 1;
            this.ModificarOfertasForm.Text = "Modificar Ofertas";
            this.ModificarOfertasForm.UseVisualStyleBackColor = true;
            this.ModificarOfertasForm.Click += new System.EventHandler(this.ModificarShow);
            // 
            // OfertasPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 151);
            this.Controls.Add(this.ModificarOfertasForm);
            this.Controls.Add(this.CrearOfertasButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OfertasPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Ofertas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CrearOfertasButton;
        private System.Windows.Forms.Button ModificarOfertasForm;
    }
}