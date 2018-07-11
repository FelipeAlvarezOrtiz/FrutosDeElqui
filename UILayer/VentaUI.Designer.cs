namespace UILayer
{
    partial class VentaUI
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paymentBox = new System.Windows.Forms.ComboBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.codeListener = new System.Windows.Forms.TextBox();
            this.kindVentaBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelVentaButton = new System.Windows.Forms.Button();
            this.ingresarVenta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.fixProblem = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.borrarElementoButton = new System.Windows.Forms.Button();
            this.datosVentaGrid = new System.Windows.Forms.DataGridView();
            this.codeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosVentaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paymentBox);
            this.groupBox1.Controls.Add(this.paymentLabel);
            this.groupBox1.Controls.Add(this.codeListener);
            this.groupBox1.Controls.Add(this.kindVentaBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1054, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración de Venta";
            // 
            // paymentBox
            // 
            this.paymentBox.FormattingEnabled = true;
            this.paymentBox.Items.AddRange(new object[] {
            "Efectivo",
            "Debito",
            "Credito"});
            this.paymentBox.Location = new System.Drawing.Point(878, 37);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.Size = new System.Drawing.Size(125, 28);
            this.paymentBox.TabIndex = 5;
            this.paymentBox.Text = "Modifique";
            this.paymentBox.SelectedValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // paymentLabel
            // 
            this.paymentLabel.Location = new System.Drawing.Point(753, 37);
            this.paymentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(124, 25);
            this.paymentLabel.TabIndex = 4;
            this.paymentLabel.Text = "Tipo de Pago :";
            this.paymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codeListener
            // 
            this.codeListener.Location = new System.Drawing.Point(193, 36);
            this.codeListener.Name = "codeListener";
            this.codeListener.Size = new System.Drawing.Size(145, 26);
            this.codeListener.TabIndex = 3;
            this.codeListener.TextChanged += new System.EventHandler(this.codeListener_TextChanged);
            this.codeListener.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntroKey);
            // 
            // kindVentaBox
            // 
            this.kindVentaBox.FormattingEnabled = true;
            this.kindVentaBox.Items.AddRange(new object[] {
            "Venta al Detalle",
            "Venta al Por Mayor"});
            this.kindVentaBox.Location = new System.Drawing.Point(532, 36);
            this.kindVentaBox.Name = "kindVentaBox";
            this.kindVentaBox.Size = new System.Drawing.Size(165, 28);
            this.kindVentaBox.TabIndex = 2;
            this.kindVentaBox.Text = "Modifique";
            this.kindVentaBox.SelectedValueChanged += new System.EventHandler(this.ValueChangedVenta);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(396, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Venta :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Barra:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelVentaButton
            // 
            this.cancelVentaButton.Location = new System.Drawing.Point(27, 606);
            this.cancelVentaButton.Name = "cancelVentaButton";
            this.cancelVentaButton.Size = new System.Drawing.Size(137, 42);
            this.cancelVentaButton.TabIndex = 2;
            this.cancelVentaButton.Text = "Cancelar Venta";
            this.cancelVentaButton.UseVisualStyleBackColor = true;
            this.cancelVentaButton.Click += new System.EventHandler(this.CancelEvent);
            // 
            // ingresarVenta
            // 
            this.ingresarVenta.Location = new System.Drawing.Point(925, 613);
            this.ingresarVenta.Name = "ingresarVenta";
            this.ingresarVenta.Size = new System.Drawing.Size(137, 42);
            this.ingresarVenta.TabIndex = 3;
            this.ingresarVenta.Text = "Ingresar Venta";
            this.toolTipInfo.SetToolTip(this.ingresarVenta, "Ingresa la Venta al Sistema.");
            this.ingresarVenta.UseVisualStyleBackColor = true;
            this.ingresarVenta.Click += new System.EventHandler(this.IngresarVenta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalTextBox);
            this.groupBox2.Controls.Add(this.fixProblem);
            this.groupBox2.Controls.Add(this.totalLabel);
            this.groupBox2.Controls.Add(this.borrarElementoButton);
            this.groupBox2.Controls.Add(this.datosVentaGrid);
            this.groupBox2.Location = new System.Drawing.Point(13, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1069, 478);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carro de Compras";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(911, 435);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(145, 26);
            this.totalTextBox.TabIndex = 7;
            // 
            // fixProblem
            // 
            this.fixProblem.Location = new System.Drawing.Point(534, 427);
            this.fixProblem.Name = "fixProblem";
            this.fixProblem.Size = new System.Drawing.Size(153, 42);
            this.fixProblem.TabIndex = 11;
            this.fixProblem.Text = "Reset Listener";
            this.toolTipInfo.SetToolTip(this.fixProblem, "Presiona si por algún motivo la pistola de codigos deja de funcionar.");
            this.fixProblem.UseVisualStyleBackColor = true;
            this.fixProblem.Click += new System.EventHandler(this.ResetListenerEvent);
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(843, 436);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(61, 25);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borrarElementoButton
            // 
            this.borrarElementoButton.Location = new System.Drawing.Point(14, 427);
            this.borrarElementoButton.Name = "borrarElementoButton";
            this.borrarElementoButton.Size = new System.Drawing.Size(153, 42);
            this.borrarElementoButton.TabIndex = 10;
            this.borrarElementoButton.Text = "Borrar Producto";
            this.toolTipInfo.SetToolTip(this.borrarElementoButton, "Borra un producto seleccionado del carro de Compra.");
            this.borrarElementoButton.UseVisualStyleBackColor = true;
            this.borrarElementoButton.Click += new System.EventHandler(this.BorrarElementoButton_Click);
            // 
            // datosVentaGrid
            // 
            this.datosVentaGrid.AllowUserToDeleteRows = false;
            this.datosVentaGrid.AllowUserToResizeColumns = false;
            this.datosVentaGrid.AllowUserToResizeRows = false;
            this.datosVentaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosVentaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeID,
            this.name,
            this.count,
            this.price});
            this.datosVentaGrid.Location = new System.Drawing.Point(6, 25);
            this.datosVentaGrid.Name = "datosVentaGrid";
            this.datosVentaGrid.RowTemplate.Height = 24;
            this.datosVentaGrid.Size = new System.Drawing.Size(1056, 396);
            this.datosVentaGrid.TabIndex = 7;
            this.datosVentaGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CapturarIdCelda);
            this.datosVentaGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ValidadorCelda);
            // 
            // codeID
            // 
            this.codeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codeID.HeaderText = "Codigo de Barra";
            this.codeID.MinimumWidth = 200;
            this.codeID.Name = "codeID";
            this.codeID.ReadOnly = true;
            this.codeID.Width = 200;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Nombre de Producto";
            this.name.MinimumWidth = 560;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 560;
            // 
            // count
            // 
            this.count.HeaderText = "Cantidad";
            this.count.Name = "count";
            // 
            // price
            // 
            this.price.HeaderText = "Precio";
            this.price.MaxInputLength = 64000;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 150;
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo.ToolTipTitle = "Información";
            // 
            // VentaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 667);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ingresarVenta);
            this.Controls.Add(this.cancelVentaButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 714);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 714);
            this.Name = "VentaUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz de Ventas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosVentaGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox codeListener;
        private System.Windows.Forms.ComboBox kindVentaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelVentaButton;
        private System.Windows.Forms.Button ingresarVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button borrarElementoButton;
        private System.Windows.Forms.DataGridView datosVentaGrid;
        private System.Windows.Forms.Button fixProblem;
        private System.Windows.Forms.ComboBox paymentBox;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label totalLabel;
    }
}