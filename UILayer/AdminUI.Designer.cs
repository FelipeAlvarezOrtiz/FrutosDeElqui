namespace UILayer
{
    partial class AdminUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUi));
            this.layout = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sellGroupBox = new System.Windows.Forms.GroupBox();
            this.ingresoLabel = new System.Windows.Forms.Label();
            this.ingresoPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.soldLabel = new System.Windows.Forms.Label();
            this.ventaAccessPoint = new System.Windows.Forms.PictureBox();
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductoButton = new System.Windows.Forms.PictureBox();
            this.inventarioButton = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ventasReportButton = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.userReportButton = new System.Windows.Forms.PictureBox();
            this.newUserButton = new System.Windows.Forms.Button();
            this.closeSessionButton = new System.Windows.Forms.Button();
            this.userPlace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.horaPlaceHolder = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.horaActualLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sellGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingresoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaAccessPoint)).BeginInit();
            this.productsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioButton)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasReportButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userReportButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.layout.Location = new System.Drawing.Point(-3, -2);
            this.layout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(416, 675);
            this.layout.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nameLabel.Location = new System.Drawing.Point(13, 23);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(147, 32);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Usuario:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sellGroupBox
            // 
            this.sellGroupBox.Controls.Add(this.ingresoLabel);
            this.sellGroupBox.Controls.Add(this.ingresoPictureBox);
            this.sellGroupBox.Controls.Add(this.label4);
            this.sellGroupBox.Controls.Add(this.pictureBox1);
            this.sellGroupBox.Controls.Add(this.soldLabel);
            this.sellGroupBox.Controls.Add(this.ventaAccessPoint);
            this.sellGroupBox.Location = new System.Drawing.Point(420, 12);
            this.sellGroupBox.Name = "sellGroupBox";
            this.sellGroupBox.Size = new System.Drawing.Size(796, 207);
            this.sellGroupBox.TabIndex = 2;
            this.sellGroupBox.TabStop = false;
            this.sellGroupBox.Text = "Ventas y Dineros";
            // 
            // ingresoLabel
            // 
            this.ingresoLabel.Location = new System.Drawing.Point(580, 179);
            this.ingresoLabel.Name = "ingresoLabel";
            this.ingresoLabel.Size = new System.Drawing.Size(170, 25);
            this.ingresoLabel.TabIndex = 5;
            this.ingresoLabel.Text = "Ingresos de Dinero";
            this.ingresoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ingresoPictureBox
            // 
            this.ingresoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ingresoPictureBox.Image")));
            this.ingresoPictureBox.Location = new System.Drawing.Point(584, 25);
            this.ingresoPictureBox.Name = "ingresoPictureBox";
            this.ingresoPictureBox.Size = new System.Drawing.Size(166, 151);
            this.ingresoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ingresoPictureBox.TabIndex = 4;
            this.ingresoPictureBox.TabStop = false;
            this.ingresoPictureBox.Click += new System.EventHandler(this.IngresoClick);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(321, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Egreso de Dinero";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UILayer.Properties.Resources.Bid_01;
            this.pictureBox1.Location = new System.Drawing.Point(325, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ClickEgresoEvent);
            // 
            // soldLabel
            // 
            this.soldLabel.Location = new System.Drawing.Point(41, 179);
            this.soldLabel.Name = "soldLabel";
            this.soldLabel.Size = new System.Drawing.Size(170, 25);
            this.soldLabel.TabIndex = 1;
            this.soldLabel.Text = "Nueva Venta";
            this.soldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ventaAccessPoint
            // 
            this.ventaAccessPoint.Image = global::UILayer.Properties.Resources.Shopping_Basket_03;
            this.ventaAccessPoint.Location = new System.Drawing.Point(45, 25);
            this.ventaAccessPoint.Name = "ventaAccessPoint";
            this.ventaAccessPoint.Size = new System.Drawing.Size(166, 151);
            this.ventaAccessPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ventaAccessPoint.TabIndex = 0;
            this.ventaAccessPoint.TabStop = false;
            this.ventaAccessPoint.Click += new System.EventHandler(this.NuevaVentaClick);
            // 
            // productsGroupBox
            // 
            this.productsGroupBox.Controls.Add(this.label3);
            this.productsGroupBox.Controls.Add(this.pictureBox3);
            this.productsGroupBox.Controls.Add(this.label6);
            this.productsGroupBox.Controls.Add(this.label5);
            this.productsGroupBox.Controls.Add(this.ProductoButton);
            this.productsGroupBox.Controls.Add(this.inventarioButton);
            this.productsGroupBox.Location = new System.Drawing.Point(420, 234);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(796, 207);
            this.productsGroupBox.TabIndex = 3;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Text = "Productos y Ofertas";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(584, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ofertas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(584, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 151);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.ModifyOfertasClick);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(321, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Productos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(41, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Inventario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductoButton
            // 
            this.ProductoButton.Image = global::UILayer.Properties.Resources.Data_Add;
            this.ProductoButton.Location = new System.Drawing.Point(325, 25);
            this.ProductoButton.Name = "ProductoButton";
            this.ProductoButton.Size = new System.Drawing.Size(160, 151);
            this.ProductoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductoButton.TabIndex = 5;
            this.ProductoButton.TabStop = false;
            this.ProductoButton.Click += new System.EventHandler(this.ProductoEvent);
            // 
            // inventarioButton
            // 
            this.inventarioButton.Image = global::UILayer.Properties.Resources.Inventario;
            this.inventarioButton.Location = new System.Drawing.Point(45, 25);
            this.inventarioButton.Name = "inventarioButton";
            this.inventarioButton.Size = new System.Drawing.Size(166, 151);
            this.inventarioButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inventarioButton.TabIndex = 4;
            this.inventarioButton.TabStop = false;
            this.inventarioButton.Click += new System.EventHandler(this.InventarioClickEvent);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ventasReportButton);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.userReportButton);
            this.groupBox3.Location = new System.Drawing.Point(420, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(796, 207);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informes y Reportes";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(528, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Reportes de Movimientos Stock";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(584, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(166, 151);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.StockMovEvent);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(321, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reporte Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ventasReportButton
            // 
            this.ventasReportButton.Image = global::UILayer.Properties.Resources.Reporte01;
            this.ventasReportButton.Location = new System.Drawing.Point(45, 25);
            this.ventasReportButton.Name = "ventasReportButton";
            this.ventasReportButton.Size = new System.Drawing.Size(166, 151);
            this.ventasReportButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ventasReportButton.TabIndex = 8;
            this.ventasReportButton.TabStop = false;
            this.ventasReportButton.Click += new System.EventHandler(this.VentaClickEvent);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(41, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Reportes e Informes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userReportButton
            // 
            this.userReportButton.Image = global::UILayer.Properties.Resources.Reporte02;
            this.userReportButton.Location = new System.Drawing.Point(325, 25);
            this.userReportButton.Name = "userReportButton";
            this.userReportButton.Size = new System.Drawing.Size(160, 151);
            this.userReportButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userReportButton.TabIndex = 9;
            this.userReportButton.TabStop = false;
            this.userReportButton.Click += new System.EventHandler(this.UserReportButton_Click);
            // 
            // newUserButton
            // 
            this.newUserButton.Location = new System.Drawing.Point(230, 585);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(156, 64);
            this.newUserButton.TabIndex = 5;
            this.newUserButton.Text = "Crear Nuevo Usuario";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.NewUserEvent);
            // 
            // closeSessionButton
            // 
            this.closeSessionButton.Location = new System.Drawing.Point(17, 585);
            this.closeSessionButton.Name = "closeSessionButton";
            this.closeSessionButton.Size = new System.Drawing.Size(156, 64);
            this.closeSessionButton.TabIndex = 6;
            this.closeSessionButton.Text = "Cerrar Sesión";
            this.closeSessionButton.UseVisualStyleBackColor = true;
            this.closeSessionButton.Click += new System.EventHandler(this.CloseSessionButton_Click);
            // 
            // userPlace
            // 
            this.userPlace.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userPlace.Location = new System.Drawing.Point(168, 23);
            this.userPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPlace.Name = "userPlace";
            this.userPlace.Size = new System.Drawing.Size(232, 32);
            this.userPlace.TabIndex = 7;
            this.userPlace.Text = "UserPlaceHolder";
            this.userPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hora de Ingreso :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // horaPlaceHolder
            // 
            this.horaPlaceHolder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.horaPlaceHolder.Location = new System.Drawing.Point(168, 79);
            this.horaPlaceHolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.horaPlaceHolder.Name = "horaPlaceHolder";
            this.horaPlaceHolder.Size = new System.Drawing.Size(232, 32);
            this.horaPlaceHolder.TabIndex = 10;
            this.horaPlaceHolder.Text = "HoraAccessPlaceHolder";
            this.horaPlaceHolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.TickEvent);
            // 
            // horaActualLabel
            // 
            this.horaActualLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.horaActualLabel.Location = new System.Drawing.Point(168, 490);
            this.horaActualLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.horaActualLabel.Name = "horaActualLabel";
            this.horaActualLabel.Size = new System.Drawing.Size(232, 32);
            this.horaActualLabel.TabIndex = 12;
            this.horaActualLabel.Text = "HoraAccessPlaceHolder";
            this.horaActualLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Location = new System.Drawing.Point(13, 490);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hora del Servidor";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UILayer.Properties.Resources.Logo_Frutos_Elqui;
            this.pictureBox2.Location = new System.Drawing.Point(17, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 332);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // AdminUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 676);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.horaActualLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.horaPlaceHolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userPlace);
            this.Controls.Add(this.closeSessionButton);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.productsGroupBox);
            this.Controls.Add(this.sellGroupBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.layout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1246, 723);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1246, 723);
            this.Name = "AdminUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frutos de Elqui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CerrandoForm);
            this.sellGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ingresoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaAccessPoint)).EndInit();
            this.productsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioButton)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasReportButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userReportButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label layout;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox sellGroupBox;
        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.Button closeSessionButton;
        private System.Windows.Forms.Label userPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label horaPlaceHolder;
        private System.Windows.Forms.PictureBox ventaAccessPoint;
        private System.Windows.Forms.Label soldLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ProductoButton;
        private System.Windows.Forms.PictureBox inventarioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ventasReportButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox userReportButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Label horaActualLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ingresoLabel;
        private System.Windows.Forms.PictureBox ingresoPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}