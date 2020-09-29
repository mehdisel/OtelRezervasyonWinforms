namespace OtelRezarvasyon.UI
{
    partial class frmCalisanCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalisanCrud));
            this.listCalisanlar = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCalisanEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGeri = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // listCalisanlar
            // 
            this.listCalisanlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listCalisanlar.FullRowSelect = true;
            this.listCalisanlar.GridLines = true;
            this.listCalisanlar.HideSelection = false;
            this.listCalisanlar.Location = new System.Drawing.Point(0, 0);
            this.listCalisanlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listCalisanlar.Name = "listCalisanlar";
            this.listCalisanlar.Size = new System.Drawing.Size(1210, 410);
            this.listCalisanlar.TabIndex = 2;
            this.listCalisanlar.UseCompatibleStateImageBehavior = false;
            this.listCalisanlar.View = System.Windows.Forms.View.Details;
            this.listCalisanlar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listCalisanlar_MouseDoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            this.columnHeader6.Width = 72;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adı";
            this.columnHeader7.Width = 78;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Soyadı";
            this.columnHeader8.Width = 77;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mail";
            this.columnHeader9.Width = 105;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Sifre";
            this.columnHeader10.Width = 121;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "OtelId";
            this.columnHeader11.Width = 113;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Yetki Durumu";
            this.columnHeader12.Width = 122;
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.ActiveBorderThickness = 1;
            this.btnCalisanEkle.ActiveCornerRadius = 20;
            this.btnCalisanEkle.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCalisanEkle.ActiveForecolor = System.Drawing.Color.White;
            this.btnCalisanEkle.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCalisanEkle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCalisanEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalisanEkle.BackgroundImage")));
            this.btnCalisanEkle.ButtonText = "EKLE";
            this.btnCalisanEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalisanEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalisanEkle.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCalisanEkle.IdleBorderThickness = 1;
            this.btnCalisanEkle.IdleCornerRadius = 20;
            this.btnCalisanEkle.IdleFillColor = System.Drawing.Color.White;
            this.btnCalisanEkle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCalisanEkle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCalisanEkle.Location = new System.Drawing.Point(1027, 437);
            this.btnCalisanEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(181, 41);
            this.btnCalisanEkle.TabIndex = 3;
            this.btnCalisanEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.ActiveBorderThickness = 1;
            this.btnGeri.ActiveCornerRadius = 20;
            this.btnGeri.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGeri.ActiveForecolor = System.Drawing.Color.White;
            this.btnGeri.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGeri.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.ButtonText = "GERI";
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeri.IdleBorderThickness = 1;
            this.btnGeri.IdleCornerRadius = 20;
            this.btnGeri.IdleFillColor = System.Drawing.Color.White;
            this.btnGeri.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGeri.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGeri.Location = new System.Drawing.Point(5, 437);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(5);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(181, 41);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmCalisanCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1213, 503);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnCalisanEkle);
            this.Controls.Add(this.listCalisanlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCalisanCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalisanCrud";
            this.Load += new System.EventHandler(this.frmCalisanCrud_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listCalisanlar;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCalisanEkle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGeri;
    }
}