namespace OtelRezarvasyon.UI
{
    partial class frmOdaİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdaİslemleri));
            this.lstOdalar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGeri = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lstOdalar
            // 
            this.lstOdalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstOdalar.FullRowSelect = true;
            this.lstOdalar.GridLines = true;
            this.lstOdalar.HideSelection = false;
            this.lstOdalar.Location = new System.Drawing.Point(0, 0);
            this.lstOdalar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstOdalar.MultiSelect = false;
            this.lstOdalar.Name = "lstOdalar";
            this.lstOdalar.Size = new System.Drawing.Size(1210, 410);
            this.lstOdalar.TabIndex = 1;
            this.lstOdalar.UseCompatibleStateImageBehavior = false;
            this.lstOdalar.View = System.Windows.Forms.View.Details;
            this.lstOdalar.DoubleClick += new System.EventHandler(this.lstOdalar_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Oda Id";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Wifi ";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Klima";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Televizyon";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Jakuzi";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Suit";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Manzara";
            this.columnHeader7.Width = 118;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Oda Fiyatı";
            this.columnHeader8.Width = 277;
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
            // frmOdaİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1213, 503);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lstOdalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmOdaİslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOdaİslemleri";
            this.Load += new System.EventHandler(this.frmOdaİslemleri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstOdalar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGeri;
    }
}