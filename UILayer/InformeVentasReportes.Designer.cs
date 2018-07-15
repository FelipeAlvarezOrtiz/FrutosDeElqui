namespace UILayer
{
    partial class InformeVentasReportes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ingresosTabPane = new System.Windows.Forms.TabPage();
            this.egresosTabPane = new System.Windows.Forms.TabPage();
            this.ventasTabPane = new System.Windows.Forms.TabPage();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.filtrosGroupBox = new System.Windows.Forms.GroupBox();
            this.opcGroupBox = new System.Windows.Forms.GroupBox();
            this.busquedaAvanzada = new System.Windows.Forms.RadioButton();
            this.busquedaNormal = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.opcGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ingresosTabPane);
            this.tabControl1.Controls.Add(this.egresosTabPane);
            this.tabControl1.Controls.Add(this.ventasTabPane);
            this.tabControl1.Location = new System.Drawing.Point(12, 228);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1496, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // ingresosTabPane
            // 
            this.ingresosTabPane.Location = new System.Drawing.Point(4, 25);
            this.ingresosTabPane.Name = "ingresosTabPane";
            this.ingresosTabPane.Padding = new System.Windows.Forms.Padding(3);
            this.ingresosTabPane.Size = new System.Drawing.Size(1488, 467);
            this.ingresosTabPane.TabIndex = 0;
            this.ingresosTabPane.Text = "Ingresos";
            this.ingresosTabPane.UseVisualStyleBackColor = true;
            // 
            // egresosTabPane
            // 
            this.egresosTabPane.Location = new System.Drawing.Point(4, 25);
            this.egresosTabPane.Name = "egresosTabPane";
            this.egresosTabPane.Padding = new System.Windows.Forms.Padding(3);
            this.egresosTabPane.Size = new System.Drawing.Size(1488, 467);
            this.egresosTabPane.TabIndex = 1;
            this.egresosTabPane.Text = "Egresos";
            this.egresosTabPane.UseVisualStyleBackColor = true;
            // 
            // ventasTabPane
            // 
            this.ventasTabPane.Location = new System.Drawing.Point(4, 25);
            this.ventasTabPane.Name = "ventasTabPane";
            this.ventasTabPane.Size = new System.Drawing.Size(1488, 467);
            this.ventasTabPane.TabIndex = 2;
            this.ventasTabPane.Text = "Ventas";
            this.ventasTabPane.UseVisualStyleBackColor = true;
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(16, 13);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 1;
            // 
            // filtrosGroupBox
            // 
            this.filtrosGroupBox.Location = new System.Drawing.Point(554, 13);
            this.filtrosGroupBox.Name = "filtrosGroupBox";
            this.filtrosGroupBox.Size = new System.Drawing.Size(950, 209);
            this.filtrosGroupBox.TabIndex = 1;
            this.filtrosGroupBox.TabStop = false;
            this.filtrosGroupBox.Text = "Filtros Avanzados";
            // 
            // opcGroupBox
            // 
            this.opcGroupBox.Controls.Add(this.busquedaAvanzada);
            this.opcGroupBox.Controls.Add(this.busquedaNormal);
            this.opcGroupBox.Location = new System.Drawing.Point(318, 13);
            this.opcGroupBox.Name = "opcGroupBox";
            this.opcGroupBox.Size = new System.Drawing.Size(230, 209);
            this.opcGroupBox.TabIndex = 2;
            this.opcGroupBox.TabStop = false;
            this.opcGroupBox.Text = "Opciones";
            // 
            // busquedaAvanzada
            // 
            this.busquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaAvanzada.Location = new System.Drawing.Point(25, 134);
            this.busquedaAvanzada.Name = "busquedaAvanzada";
            this.busquedaAvanzada.Size = new System.Drawing.Size(197, 30);
            this.busquedaAvanzada.TabIndex = 1;
            this.busquedaAvanzada.Text = "Busqueda Avanzada";
            this.busquedaAvanzada.UseVisualStyleBackColor = true;
            // 
            // busquedaNormal
            // 
            this.busquedaNormal.Checked = true;
            this.busquedaNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaNormal.Location = new System.Drawing.Point(25, 63);
            this.busquedaNormal.Name = "busquedaNormal";
            this.busquedaNormal.Size = new System.Drawing.Size(197, 24);
            this.busquedaNormal.TabIndex = 0;
            this.busquedaNormal.TabStop = true;
            this.busquedaNormal.Text = "Busqueda Normal";
            this.busquedaNormal.UseVisualStyleBackColor = true;
            // 
            // InformeVentasReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 745);
            this.Controls.Add(this.opcGroupBox);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.filtrosGroupBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "InformeVentasReportes";
            this.Text = "InformeVentasReportes";
            this.tabControl1.ResumeLayout(false);
            this.opcGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ingresosTabPane;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.TabPage egresosTabPane;
        private System.Windows.Forms.TabPage ventasTabPane;
        private System.Windows.Forms.GroupBox filtrosGroupBox;
        private System.Windows.Forms.GroupBox opcGroupBox;
        private System.Windows.Forms.RadioButton busquedaAvanzada;
        private System.Windows.Forms.RadioButton busquedaNormal;
    }
}