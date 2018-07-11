namespace UILayer
{
    partial class ReporteUsuarios
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
            this.userDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calendarioUser = new System.Windows.Forms.MonthCalendar();
            this.buscarButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userDataGrid
            // 
            this.userDataGrid.AllowUserToAddRows = false;
            this.userDataGrid.AllowUserToDeleteRows = false;
            this.userDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGrid.Location = new System.Drawing.Point(362, 16);
            this.userDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.userDataGrid.Name = "userDataGrid";
            this.userDataGrid.ReadOnly = true;
            this.userDataGrid.RowTemplate.Height = 24;
            this.userDataGrid.Size = new System.Drawing.Size(700, 591);
            this.userDataGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calendarioUser);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(320, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Búsqueda";
            // 
            // calendarioUser
            // 
            this.calendarioUser.Location = new System.Drawing.Point(15, 34);
            this.calendarioUser.Margin = new System.Windows.Forms.Padding(11);
            this.calendarioUser.Name = "calendarioUser";
            this.calendarioUser.TabIndex = 0;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(210, 295);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(111, 37);
            this.buscarButton.TabIndex = 2;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(16, 295);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(116, 37);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Cerrar";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseEvent);
            // 
            // ReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 617);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userDataGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReporteUsuarios";
            this.Text = "ReporteUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar calendarioUser;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button closeButton;
    }
}