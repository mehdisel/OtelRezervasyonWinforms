namespace OtelRezarvasyon.UI
{
    partial class frmOdaDetaylandirma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdaDetaylandirma));
            this.numOdaNumarasi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numOdaFiyati = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbManzara = new System.Windows.Forms.CheckBox();
            this.cbSuit = new System.Windows.Forms.CheckBox();
            this.cbJakuzi = new System.Windows.Forms.CheckBox();
            this.cbTv = new System.Windows.Forms.CheckBox();
            this.cbKlima = new System.Windows.Forms.CheckBox();
            this.cbWifi = new System.Windows.Forms.CheckBox();
            this.btnOlustur = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.numOdaNumarasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOdaFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // numOdaNumarasi
            // 
            this.numOdaNumarasi.Location = new System.Drawing.Point(151, 36);
            this.numOdaNumarasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOdaNumarasi.Name = "numOdaNumarasi";
            this.numOdaNumarasi.Size = new System.Drawing.Size(120, 22);
            this.numOdaNumarasi.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(23, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Oda Numarası:";
            // 
            // numOdaFiyati
            // 
            this.numOdaFiyati.Location = new System.Drawing.Point(151, 391);
            this.numOdaFiyati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOdaFiyati.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numOdaFiyati.Name = "numOdaFiyati";
            this.numOdaFiyati.Size = new System.Drawing.Size(120, 22);
            this.numOdaFiyati.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(23, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Oda Fiyatı:";
            // 
            // cbManzara
            // 
            this.cbManzara.AutoSize = true;
            this.cbManzara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbManzara.ForeColor = System.Drawing.Color.Coral;
            this.cbManzara.Location = new System.Drawing.Point(23, 345);
            this.cbManzara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbManzara.Name = "cbManzara";
            this.cbManzara.Size = new System.Drawing.Size(136, 24);
            this.cbManzara.TabIndex = 53;
            this.cbManzara.Text = "Manzaralı Mı?";
            this.cbManzara.UseVisualStyleBackColor = true;
            // 
            // cbSuit
            // 
            this.cbSuit.AutoSize = true;
            this.cbSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSuit.ForeColor = System.Drawing.Color.Coral;
            this.cbSuit.Location = new System.Drawing.Point(23, 292);
            this.cbSuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSuit.Name = "cbSuit";
            this.cbSuit.Size = new System.Drawing.Size(92, 24);
            this.cbSuit.TabIndex = 52;
            this.cbSuit.Text = "Suit Mi?";
            this.cbSuit.UseVisualStyleBackColor = true;
            // 
            // cbJakuzi
            // 
            this.cbJakuzi.AutoSize = true;
            this.cbJakuzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbJakuzi.ForeColor = System.Drawing.Color.Coral;
            this.cbJakuzi.Location = new System.Drawing.Point(23, 241);
            this.cbJakuzi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbJakuzi.Name = "cbJakuzi";
            this.cbJakuzi.Size = new System.Drawing.Size(142, 24);
            this.cbJakuzi.TabIndex = 51;
            this.cbJakuzi.Text = "Jakuzi Var Mı?";
            this.cbJakuzi.UseVisualStyleBackColor = true;
            // 
            // cbTv
            // 
            this.cbTv.AutoSize = true;
            this.cbTv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTv.ForeColor = System.Drawing.Color.Coral;
            this.cbTv.Location = new System.Drawing.Point(23, 188);
            this.cbTv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTv.Name = "cbTv";
            this.cbTv.Size = new System.Drawing.Size(173, 24);
            this.cbTv.TabIndex = 50;
            this.cbTv.Text = "Televizyon Var Mı?";
            this.cbTv.UseVisualStyleBackColor = true;
            // 
            // cbKlima
            // 
            this.cbKlima.AutoSize = true;
            this.cbKlima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKlima.ForeColor = System.Drawing.Color.Coral;
            this.cbKlima.Location = new System.Drawing.Point(23, 135);
            this.cbKlima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKlima.Name = "cbKlima";
            this.cbKlima.Size = new System.Drawing.Size(136, 24);
            this.cbKlima.TabIndex = 49;
            this.cbKlima.Text = "Klima Var Mı?";
            this.cbKlima.UseVisualStyleBackColor = true;
            // 
            // cbWifi
            // 
            this.cbWifi.AutoSize = true;
            this.cbWifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbWifi.ForeColor = System.Drawing.Color.Coral;
            this.cbWifi.Location = new System.Drawing.Point(23, 87);
            this.cbWifi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWifi.Name = "cbWifi";
            this.cbWifi.Size = new System.Drawing.Size(123, 24);
            this.cbWifi.TabIndex = 48;
            this.cbWifi.Text = "Wifi Var Mı?";
            this.cbWifi.UseVisualStyleBackColor = true;
            // 
            // btnOlustur
            // 
            this.btnOlustur.ActiveBorderThickness = 1;
            this.btnOlustur.ActiveCornerRadius = 20;
            this.btnOlustur.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnOlustur.ActiveForecolor = System.Drawing.Color.White;
            this.btnOlustur.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnOlustur.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOlustur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOlustur.BackgroundImage")));
            this.btnOlustur.ButtonText = "OLUSTUR";
            this.btnOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlustur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlustur.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOlustur.IdleBorderThickness = 1;
            this.btnOlustur.IdleCornerRadius = 20;
            this.btnOlustur.IdleFillColor = System.Drawing.Color.White;
            this.btnOlustur.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnOlustur.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnOlustur.Location = new System.Drawing.Point(147, 448);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(5);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(181, 41);
            this.btnOlustur.TabIndex = 58;
            this.btnOlustur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // frmOdaDetaylandirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(342, 493);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.numOdaNumarasi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numOdaFiyati);
            this.Controls.Add(this.cbKlima);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbWifi);
            this.Controls.Add(this.cbManzara);
            this.Controls.Add(this.cbTv);
            this.Controls.Add(this.cbSuit);
            this.Controls.Add(this.cbJakuzi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmOdaDetaylandirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOdaDetaylandirma";
            this.Load += new System.EventHandler(this.frmOdaDetaylandirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOdaNumarasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOdaFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numOdaNumarasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numOdaFiyati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbManzara;
        private System.Windows.Forms.CheckBox cbSuit;
        private System.Windows.Forms.CheckBox cbJakuzi;
        private System.Windows.Forms.CheckBox cbTv;
        private System.Windows.Forms.CheckBox cbKlima;
        private System.Windows.Forms.CheckBox cbWifi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOlustur;
    }
}