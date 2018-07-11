namespace UILayer
{
    partial class InformeVentas
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
            this.userCalendar = new System.Windows.Forms.MonthCalendar();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.datosDineroGroupBox = new System.Windows.Forms.GroupBox();
            this.cajaBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ingresosBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.creditoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.egresosTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gananciaTotalTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ventasDetalleTextBox = new System.Windows.Forms.TextBox();
            this.ventasMayorTextBox = new System.Windows.Forms.TextBox();
            this.debitoTextBox = new System.Windows.Forms.TextBox();
            this.efectivoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.egresosDataView = new System.Windows.Forms.DataGridView();
            this.egresoGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.anularButton = new System.Windows.Forms.Button();
            this.detalleButton = new System.Windows.Forms.Button();
            this.ventasDataGrid = new System.Windows.Forms.DataGridView();
            this.ingresosGroupBox = new System.Windows.Forms.GroupBox();
            this.ingresoDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.datosDineroGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.egresosDataView)).BeginInit();
            this.egresoGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataGrid)).BeginInit();
            this.ingresosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingresoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userCalendar);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.cancelarButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha";
            // 
            // userCalendar
            // 
            this.userCalendar.Location = new System.Drawing.Point(12, 27);
            this.userCalendar.Name = "userCalendar";
            this.userCalendar.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(231, 277);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(108, 35);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(11, 277);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(108, 35);
            this.cancelarButton.TabIndex = 1;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CloseEVentClick);
            // 
            // datosDineroGroupBox
            // 
            this.datosDineroGroupBox.Controls.Add(this.cajaBox);
            this.datosDineroGroupBox.Controls.Add(this.label9);
            this.datosDineroGroupBox.Controls.Add(this.ingresosBox);
            this.datosDineroGroupBox.Controls.Add(this.label8);
            this.datosDineroGroupBox.Controls.Add(this.creditoTextBox);
            this.datosDineroGroupBox.Controls.Add(this.label7);
            this.datosDineroGroupBox.Controls.Add(this.egresosTextBox);
            this.datosDineroGroupBox.Controls.Add(this.label6);
            this.datosDineroGroupBox.Controls.Add(this.gananciaTotalTextBox);
            this.datosDineroGroupBox.Controls.Add(this.label5);
            this.datosDineroGroupBox.Controls.Add(this.ventasDetalleTextBox);
            this.datosDineroGroupBox.Controls.Add(this.ventasMayorTextBox);
            this.datosDineroGroupBox.Controls.Add(this.debitoTextBox);
            this.datosDineroGroupBox.Controls.Add(this.efectivoTextBox);
            this.datosDineroGroupBox.Controls.Add(this.label4);
            this.datosDineroGroupBox.Controls.Add(this.label3);
            this.datosDineroGroupBox.Controls.Add(this.label2);
            this.datosDineroGroupBox.Controls.Add(this.label1);
            this.datosDineroGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosDineroGroupBox.Location = new System.Drawing.Point(12, 363);
            this.datosDineroGroupBox.Name = "datosDineroGroupBox";
            this.datosDineroGroupBox.Size = new System.Drawing.Size(421, 367);
            this.datosDineroGroupBox.TabIndex = 1;
            this.datosDineroGroupBox.TabStop = false;
            this.datosDineroGroupBox.Text = "Datos de Dinero";
            // 
            // cajaBox
            // 
            this.cajaBox.Location = new System.Drawing.Point(269, 326);
            this.cajaBox.Name = "cajaBox";
            this.cajaBox.ReadOnly = true;
            this.cajaBox.Size = new System.Drawing.Size(124, 22);
            this.cajaBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(13, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total de Dinero en Caja :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ingresosBox
            // 
            this.ingresosBox.Location = new System.Drawing.Point(269, 259);
            this.ingresosBox.Name = "ingresosBox";
            this.ingresosBox.ReadOnly = true;
            this.ingresosBox.Size = new System.Drawing.Size(125, 22);
            this.ingresosBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(13, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ingresos de Dinero a Caja :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creditoTextBox
            // 
            this.creditoTextBox.Location = new System.Drawing.Point(270, 106);
            this.creditoTextBox.Name = "creditoTextBox";
            this.creditoTextBox.ReadOnly = true;
            this.creditoTextBox.Size = new System.Drawing.Size(125, 22);
            this.creditoTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ventas en Tarjeta Credito:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // egresosTextBox
            // 
            this.egresosTextBox.Location = new System.Drawing.Point(269, 223);
            this.egresosTextBox.Name = "egresosTextBox";
            this.egresosTextBox.ReadOnly = true;
            this.egresosTextBox.Size = new System.Drawing.Size(125, 22);
            this.egresosTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Egresos de Dinero desde Caja:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gananciaTotalTextBox
            // 
            this.gananciaTotalTextBox.Location = new System.Drawing.Point(271, 294);
            this.gananciaTotalTextBox.Name = "gananciaTotalTextBox";
            this.gananciaTotalTextBox.ReadOnly = true;
            this.gananciaTotalTextBox.Size = new System.Drawing.Size(124, 22);
            this.gananciaTotalTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ganancia Total de Ventas :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ventasDetalleTextBox
            // 
            this.ventasDetalleTextBox.Location = new System.Drawing.Point(269, 185);
            this.ventasDetalleTextBox.Name = "ventasDetalleTextBox";
            this.ventasDetalleTextBox.ReadOnly = true;
            this.ventasDetalleTextBox.Size = new System.Drawing.Size(124, 22);
            this.ventasDetalleTextBox.TabIndex = 9;
            // 
            // ventasMayorTextBox
            // 
            this.ventasMayorTextBox.Location = new System.Drawing.Point(271, 140);
            this.ventasMayorTextBox.Name = "ventasMayorTextBox";
            this.ventasMayorTextBox.ReadOnly = true;
            this.ventasMayorTextBox.Size = new System.Drawing.Size(125, 22);
            this.ventasMayorTextBox.TabIndex = 8;
            // 
            // debitoTextBox
            // 
            this.debitoTextBox.Location = new System.Drawing.Point(270, 66);
            this.debitoTextBox.Name = "debitoTextBox";
            this.debitoTextBox.ReadOnly = true;
            this.debitoTextBox.Size = new System.Drawing.Size(125, 22);
            this.debitoTextBox.TabIndex = 7;
            // 
            // efectivoTextBox
            // 
            this.efectivoTextBox.Location = new System.Drawing.Point(270, 30);
            this.efectivoTextBox.Name = "efectivoTextBox";
            this.efectivoTextBox.ReadOnly = true;
            this.efectivoTextBox.Size = new System.Drawing.Size(124, 22);
            this.efectivoTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ventas al Detalle :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ventas al Por Mayor :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ventas en Tarjeta Debito:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ventas en Efectivo :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // egresosDataView
            // 
            this.egresosDataView.AllowUserToAddRows = false;
            this.egresosDataView.AllowUserToDeleteRows = false;
            this.egresosDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.egresosDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.egresosDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.egresosDataView.Location = new System.Drawing.Point(3, 18);
            this.egresosDataView.Name = "egresosDataView";
            this.egresosDataView.ReadOnly = true;
            this.egresosDataView.RowTemplate.Height = 24;
            this.egresosDataView.Size = new System.Drawing.Size(1105, 153);
            this.egresosDataView.TabIndex = 2;
            // 
            // egresoGroupBox
            // 
            this.egresoGroupBox.Controls.Add(this.egresosDataView);
            this.egresoGroupBox.Location = new System.Drawing.Point(439, 353);
            this.egresoGroupBox.Name = "egresoGroupBox";
            this.egresoGroupBox.Size = new System.Drawing.Size(1111, 174);
            this.egresoGroupBox.TabIndex = 3;
            this.egresoGroupBox.TabStop = false;
            this.egresoGroupBox.Text = "Egresos de Caja";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.anularButton);
            this.groupBox3.Controls.Add(this.detalleButton);
            this.groupBox3.Controls.Add(this.ventasDataGrid);
            this.groupBox3.Location = new System.Drawing.Point(391, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1159, 335);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movimientos de Dinero";
            // 
            // anularButton
            // 
            this.anularButton.Location = new System.Drawing.Point(1022, 252);
            this.anularButton.Name = "anularButton";
            this.anularButton.Size = new System.Drawing.Size(101, 35);
            this.anularButton.TabIndex = 2;
            this.anularButton.Text = "Anular Venta";
            this.anularButton.UseVisualStyleBackColor = true;
            this.anularButton.Click += new System.EventHandler(this.AnularEventClick);
            // 
            // detalleButton
            // 
            this.detalleButton.Location = new System.Drawing.Point(1022, 57);
            this.detalleButton.Name = "detalleButton";
            this.detalleButton.Size = new System.Drawing.Size(101, 35);
            this.detalleButton.TabIndex = 1;
            this.detalleButton.Text = "Ver Detalle";
            this.detalleButton.UseVisualStyleBackColor = true;
            this.detalleButton.Click += new System.EventHandler(this.DetalleButton_Click);
            // 
            // ventasDataGrid
            // 
            this.ventasDataGrid.AllowUserToAddRows = false;
            this.ventasDataGrid.AllowUserToDeleteRows = false;
            this.ventasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventasDataGrid.Location = new System.Drawing.Point(3, 18);
            this.ventasDataGrid.Name = "ventasDataGrid";
            this.ventasDataGrid.ReadOnly = true;
            this.ventasDataGrid.RowTemplate.Height = 24;
            this.ventasDataGrid.Size = new System.Drawing.Size(982, 311);
            this.ventasDataGrid.TabIndex = 0;
            // 
            // ingresosGroupBox
            // 
            this.ingresosGroupBox.Controls.Add(this.ingresoDataGrid);
            this.ingresosGroupBox.Location = new System.Drawing.Point(442, 539);
            this.ingresosGroupBox.Name = "ingresosGroupBox";
            this.ingresosGroupBox.Size = new System.Drawing.Size(1111, 191);
            this.ingresosGroupBox.TabIndex = 4;
            this.ingresosGroupBox.TabStop = false;
            this.ingresosGroupBox.Text = "Ingresos a Caja";
            // 
            // ingresoDataGrid
            // 
            this.ingresoDataGrid.AllowUserToAddRows = false;
            this.ingresoDataGrid.AllowUserToDeleteRows = false;
            this.ingresoDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ingresoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingresoDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingresoDataGrid.Location = new System.Drawing.Point(3, 18);
            this.ingresoDataGrid.Name = "ingresoDataGrid";
            this.ingresoDataGrid.ReadOnly = true;
            this.ingresoDataGrid.RowTemplate.Height = 24;
            this.ingresoDataGrid.Size = new System.Drawing.Size(1105, 170);
            this.ingresoDataGrid.TabIndex = 2;
            // 
            // InformeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 743);
            this.Controls.Add(this.ingresosGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.egresoGroupBox);
            this.Controls.Add(this.datosDineroGroupBox);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 790);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1600, 790);
            this.Name = "InformeVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe Ventas";
            this.groupBox1.ResumeLayout(false);
            this.datosDineroGroupBox.ResumeLayout(false);
            this.datosDineroGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.egresosDataView)).EndInit();
            this.egresoGroupBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataGrid)).EndInit();
            this.ingresosGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ingresoDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar userCalendar;
        private System.Windows.Forms.GroupBox datosDineroGroupBox;
        private System.Windows.Forms.DataGridView egresosDataView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox ventasDetalleTextBox;
        private System.Windows.Forms.TextBox ventasMayorTextBox;
        private System.Windows.Forms.TextBox debitoTextBox;
        private System.Windows.Forms.TextBox efectivoTextBox;
        private System.Windows.Forms.TextBox gananciaTotalTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox egresosTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox egresoGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ventasDataGrid;
        private System.Windows.Forms.TextBox creditoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button anularButton;
        private System.Windows.Forms.Button detalleButton;
        private System.Windows.Forms.TextBox ingresosBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox ingresosGroupBox;
        private System.Windows.Forms.DataGridView ingresoDataGrid;
        private System.Windows.Forms.TextBox cajaBox;
        private System.Windows.Forms.Label label9;
    }
}