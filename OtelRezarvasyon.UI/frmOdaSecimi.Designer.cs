namespace OtelRezarvasyon.UI
{
    partial class frmOdaSecimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdaSecimi));
            this.label2 = new System.Windows.Forms.Label();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSifirla = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbManzara = new System.Windows.Forms.ComboBox();
            this.cmbSuit = new System.Windows.Forms.ComboBox();
            this.cmbJakuzi = new System.Windows.Forms.ComboBox();
            this.cmbTelevizyon = new System.Windows.Forms.ComboBox();
            this.cmbKlima = new System.Windows.Forms.ComboBox();
            this.cmbWifi = new System.Windows.Forms.ComboBox();
            this.lblSecilen = new System.Windows.Forms.Label();
            this.cmbOdaSecimi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbRezervasyonTipleri = new System.Windows.Forms.ComboBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnOdemeSayfasinaGec = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGeri = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGecmisRezervasyonlar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(646, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giriş Tarihi:";
            // 
            // dtpGiris
            // 
            this.dtpGiris.Location = new System.Drawing.Point(751, 14);
            this.dtpGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpGiris.MinDate = new System.DateTime(2019, 10, 9, 0, 0, 0, 0);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(235, 22);
            this.dtpGiris.TabIndex = 3;
            this.dtpGiris.ValueChanged += new System.EventHandler(this.dtpGiris_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(995, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Çıkış Tarihi:";
            // 
            // dtpCikis
            // 
            this.dtpCikis.Location = new System.Drawing.Point(1098, 15);
            this.dtpCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(236, 22);
            this.dtpCikis.TabIndex = 5;
            this.dtpCikis.ValueChanged += new System.EventHandler(this.dtpCikis_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(23, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oda:";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(232, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1333, 545);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odalar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnSifirla);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbManzara);
            this.groupBox2.Controls.Add(this.cmbSuit);
            this.groupBox2.Controls.Add(this.cmbJakuzi);
            this.groupBox2.Controls.Add(this.cmbTelevizyon);
            this.groupBox2.Controls.Add(this.cmbKlima);
            this.groupBox2.Controls.Add(this.cmbWifi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Coral;
            this.groupBox2.Location = new System.Drawing.Point(16, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(208, 545);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oda Özellikleri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Wifi var mı?";
            // 
            // btnSifirla
            // 
            this.btnSifirla.ActiveBorderThickness = 1;
            this.btnSifirla.ActiveCornerRadius = 20;
            this.btnSifirla.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSifirla.ActiveForecolor = System.Drawing.Color.White;
            this.btnSifirla.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSifirla.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSifirla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSifirla.BackgroundImage")));
            this.btnSifirla.ButtonText = "SIFIRLA";
            this.btnSifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSifirla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifirla.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSifirla.IdleBorderThickness = 1;
            this.btnSifirla.IdleCornerRadius = 20;
            this.btnSifirla.IdleFillColor = System.Drawing.Color.White;
            this.btnSifirla.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSifirla.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSifirla.Location = new System.Drawing.Point(31, 495);
            this.btnSifirla.Margin = new System.Windows.Forms.Padding(5);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(137, 41);
            this.btnSifirla.TabIndex = 32;
            this.btnSifirla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Manzara var mı?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Suit mi?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Jakuzi var mı?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Televizyon var mı?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Klima var mı?";
            // 
            // cmbManzara
            // 
            this.cmbManzara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManzara.FormattingEnabled = true;
            this.cmbManzara.Location = new System.Drawing.Point(24, 452);
            this.cmbManzara.Margin = new System.Windows.Forms.Padding(4);
            this.cmbManzara.Name = "cmbManzara";
            this.cmbManzara.Size = new System.Drawing.Size(160, 28);
            this.cmbManzara.TabIndex = 31;
            this.cmbManzara.SelectedIndexChanged += new System.EventHandler(this.cmbWifi_SelectedIndexChanged);
            // 
            // cmbSuit
            // 
            this.cmbSuit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuit.FormattingEnabled = true;
            this.cmbSuit.Location = new System.Drawing.Point(24, 370);
            this.cmbSuit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSuit.Name = "cmbSuit";
            this.cmbSuit.Size = new System.Drawing.Size(160, 28);
            this.cmbSuit.TabIndex = 30;
            this.cmbSuit.SelectedIndexChanged += new System.EventHandler(this.cmbWifi_SelectedIndexChanged);
            // 
            // cmbJakuzi
            // 
            this.cmbJakuzi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJakuzi.FormattingEnabled = true;
            this.cmbJakuzi.Location = new System.Drawing.Point(24, 289);
            this.cmbJakuzi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbJakuzi.Name = "cmbJakuzi";
            this.cmbJakuzi.Size = new System.Drawing.Size(160, 28);
            this.cmbJakuzi.TabIndex = 29;
            this.cmbJakuzi.SelectedIndexChanged += new System.EventHandler(this.cmbWifi_SelectedIndexChanged);
            // 
            // cmbTelevizyon
            // 
            this.cmbTelevizyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTelevizyon.FormattingEnabled = true;
            this.cmbTelevizyon.Location = new System.Drawing.Point(24, 208);
            this.cmbTelevizyon.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTelevizyon.Name = "cmbTelevizyon";
            this.cmbTelevizyon.Size = new System.Drawing.Size(160, 28);
            this.cmbTelevizyon.TabIndex = 28;
            this.cmbTelevizyon.SelectedIndexChanged += new System.EventHandler(this.cmbWifi_SelectedIndexChanged);
            // 
            // cmbKlima
            // 
            this.cmbKlima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlima.FormattingEnabled = true;
            this.cmbKlima.Location = new System.Drawing.Point(24, 127);
            this.cmbKlima.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKlima.Name = "cmbKlima";
            this.cmbKlima.Size = new System.Drawing.Size(160, 28);
            this.cmbKlima.TabIndex = 27;
            this.cmbKlima.SelectedIndexChanged += new System.EventHandler(this.cmbWifi_SelectedIndexChanged);
            // 
            // cmbWifi
            // 
            this.cmbWifi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWifi.FormattingEnabled = true;
            this.cmbWifi.Location = new System.Drawing.Point(24, 46);
            this.cmbWifi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbWifi.Name = "cmbWifi";
            this.cmbWifi.Size = new System.Drawing.Size(160, 28);
            this.cmbWifi.TabIndex = 26;
            this.cmbWifi.SelectedIndexChanged += new System.EventHandler(this.cmbWifi_SelectedIndexChanged);
            // 
            // lblSecilen
            // 
            this.lblSecilen.AutoSize = true;
            this.lblSecilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilen.ForeColor = System.Drawing.Color.Coral;
            this.lblSecilen.Location = new System.Drawing.Point(1355, 9);
            this.lblSecilen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecilen.Name = "lblSecilen";
            this.lblSecilen.Size = new System.Drawing.Size(62, 20);
            this.lblSecilen.TabIndex = 27;
            this.lblSecilen.Text = "label11";
            // 
            // cmbOdaSecimi
            // 
            this.cmbOdaSecimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdaSecimi.FormattingEnabled = true;
            this.cmbOdaSecimi.Location = new System.Drawing.Point(75, 15);
            this.cmbOdaSecimi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOdaSecimi.Name = "cmbOdaSecimi";
            this.cmbOdaSecimi.Size = new System.Drawing.Size(187, 24);
            this.cmbOdaSecimi.TabIndex = 28;
            this.cmbOdaSecimi.SelectedIndexChanged += new System.EventHandler(this.cmbOdaSecimi_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Coral;
            this.label11.Location = new System.Drawing.Point(282, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Rezervasyon Tipi:";
            // 
            // cmbRezervasyonTipleri
            // 
            this.cmbRezervasyonTipleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRezervasyonTipleri.FormattingEnabled = true;
            this.cmbRezervasyonTipleri.Location = new System.Drawing.Point(439, 15);
            this.cmbRezervasyonTipleri.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRezervasyonTipleri.Name = "cmbRezervasyonTipleri";
            this.cmbRezervasyonTipleri.Size = new System.Drawing.Size(192, 24);
            this.cmbRezervasyonTipleri.TabIndex = 30;
            this.cmbRezervasyonTipleri.SelectedIndexChanged += new System.EventHandler(this.cmbOdaSecimi_SelectedIndexChanged);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Coral;
            this.lblToplamTutar.Location = new System.Drawing.Point(1355, 40);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(21, 20);
            this.lblToplamTutar.TabIndex = 31;
            this.lblToplamTutar.Text = "w";
            // 
            // btnOdemeSayfasinaGec
            // 
            this.btnOdemeSayfasinaGec.ActiveBorderThickness = 1;
            this.btnOdemeSayfasinaGec.ActiveCornerRadius = 20;
            this.btnOdemeSayfasinaGec.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnOdemeSayfasinaGec.ActiveForecolor = System.Drawing.Color.White;
            this.btnOdemeSayfasinaGec.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnOdemeSayfasinaGec.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOdemeSayfasinaGec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdemeSayfasinaGec.BackgroundImage")));
            this.btnOdemeSayfasinaGec.ButtonText = "ODEME SAYFASINA GEC";
            this.btnOdemeSayfasinaGec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdemeSayfasinaGec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdemeSayfasinaGec.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOdemeSayfasinaGec.IdleBorderThickness = 1;
            this.btnOdemeSayfasinaGec.IdleCornerRadius = 20;
            this.btnOdemeSayfasinaGec.IdleFillColor = System.Drawing.Color.White;
            this.btnOdemeSayfasinaGec.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnOdemeSayfasinaGec.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnOdemeSayfasinaGec.Location = new System.Drawing.Point(1264, 641);
            this.btnOdemeSayfasinaGec.Margin = new System.Windows.Forms.Padding(5);
            this.btnOdemeSayfasinaGec.Name = "btnOdemeSayfasinaGec";
            this.btnOdemeSayfasinaGec.Size = new System.Drawing.Size(301, 41);
            this.btnOdemeSayfasinaGec.TabIndex = 32;
            this.btnOdemeSayfasinaGec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOdemeSayfasinaGec.Click += new System.EventHandler(this.btnOdemeSayfasinaGec_Click);
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
            this.btnGeri.Location = new System.Drawing.Point(16, 641);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(5);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(181, 41);
            this.btnGeri.TabIndex = 33;
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnGecmisRezervasyonlar
            // 
            this.btnGecmisRezervasyonlar.ActiveBorderThickness = 1;
            this.btnGecmisRezervasyonlar.ActiveCornerRadius = 20;
            this.btnGecmisRezervasyonlar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGecmisRezervasyonlar.ActiveForecolor = System.Drawing.Color.White;
            this.btnGecmisRezervasyonlar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGecmisRezervasyonlar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGecmisRezervasyonlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGecmisRezervasyonlar.BackgroundImage")));
            this.btnGecmisRezervasyonlar.ButtonText = "GECMIS REZERVASYONLAR";
            this.btnGecmisRezervasyonlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGecmisRezervasyonlar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGecmisRezervasyonlar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGecmisRezervasyonlar.IdleBorderThickness = 1;
            this.btnGecmisRezervasyonlar.IdleCornerRadius = 20;
            this.btnGecmisRezervasyonlar.IdleFillColor = System.Drawing.Color.White;
            this.btnGecmisRezervasyonlar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGecmisRezervasyonlar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGecmisRezervasyonlar.Location = new System.Drawing.Point(923, 641);
            this.btnGecmisRezervasyonlar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGecmisRezervasyonlar.Name = "btnGecmisRezervasyonlar";
            this.btnGecmisRezervasyonlar.Size = new System.Drawing.Size(301, 41);
            this.btnGecmisRezervasyonlar.TabIndex = 34;
            this.btnGecmisRezervasyonlar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGecmisRezervasyonlar.Click += new System.EventHandler(this.btnGecmisRezervasyonlar_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.MidnightBlue;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1530, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 35;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // frmOdaSecimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1578, 711);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnGecmisRezervasyonlar);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnOdemeSayfasinaGec);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.cmbRezervasyonTipleri);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbOdaSecimi);
            this.Controls.Add(this.lblSecilen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpCikis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpGiris);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmOdaSecimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOdaSecimi";
            this.Load += new System.EventHandler(this.frmOtelAramaListeleme_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbManzara;
        private System.Windows.Forms.ComboBox cmbSuit;
        private System.Windows.Forms.ComboBox cmbJakuzi;
        private System.Windows.Forms.ComboBox cmbTelevizyon;
        private System.Windows.Forms.ComboBox cmbKlima;
        private System.Windows.Forms.ComboBox cmbWifi;
        private System.Windows.Forms.Label lblSecilen;
        private System.Windows.Forms.ComboBox cmbOdaSecimi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbRezervasyonTipleri;
        private System.Windows.Forms.Label lblToplamTutar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSifirla;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOdemeSayfasinaGec;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGeri;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGecmisRezervasyonlar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}