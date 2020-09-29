namespace OtelRezarvasyon.UI
{
    partial class frmRezervasyonList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyonList));
            this.lstRezGoruntule = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRezSil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGeri = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lstRezGoruntule
            // 
            this.lstRezGoruntule.AllowColumnReorder = true;
            this.lstRezGoruntule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.lstRezGoruntule.GridLines = true;
            this.lstRezGoruntule.HideSelection = false;
            this.lstRezGoruntule.Location = new System.Drawing.Point(0, 0);
            this.lstRezGoruntule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstRezGoruntule.Name = "lstRezGoruntule";
            this.lstRezGoruntule.Size = new System.Drawing.Size(1210, 410);
            this.lstRezGoruntule.TabIndex = 2;
            this.lstRezGoruntule.UseCompatibleStateImageBehavior = false;
            this.lstRezGoruntule.View = System.Windows.Forms.View.Details;
            this.lstRezGoruntule.Click += new System.EventHandler(this.lstRezGoruntule_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Giriş Tarihi";
            this.columnHeader10.Width = 151;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Çıkış Tarihi";
            this.columnHeader11.Width = 139;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Müşteri Ad Soyad";
            this.columnHeader12.Width = 161;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Kişi Sayısı";
            this.columnHeader13.Width = 108;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Otel Adı";
            this.columnHeader14.Width = 111;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Oda Numarası";
            this.columnHeader15.Width = 158;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Rezervasyon Tipi";
            this.columnHeader16.Width = 394;
            // 
            // btnRezSil
            // 
            this.btnRezSil.ActiveBorderThickness = 1;
            this.btnRezSil.ActiveCornerRadius = 20;
            this.btnRezSil.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRezSil.ActiveForecolor = System.Drawing.Color.White;
            this.btnRezSil.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRezSil.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRezSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRezSil.BackgroundImage")));
            this.btnRezSil.ButtonText = "SIL";
            this.btnRezSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRezSil.IdleBorderThickness = 1;
            this.btnRezSil.IdleCornerRadius = 20;
            this.btnRezSil.IdleFillColor = System.Drawing.Color.White;
            this.btnRezSil.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnRezSil.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRezSil.Location = new System.Drawing.Point(1018, 437);
            this.btnRezSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnRezSil.Name = "btnRezSil";
            this.btnRezSil.Size = new System.Drawing.Size(181, 41);
            this.btnRezSil.TabIndex = 4;
            this.btnRezSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRezSil.Click += new System.EventHandler(this.btnRezSil_Click);
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
            this.btnGeri.TabIndex = 5;
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmRezervasyonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1213, 503);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnRezSil);
            this.Controls.Add(this.lstRezGoruntule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRezervasyonList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRezervasyonList";
            this.Load += new System.EventHandler(this.frmRezervasyonList_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstRezGoruntule;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRezSil;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGeri;
    }
}