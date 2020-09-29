namespace OtelRezarvasyon.UI
{
    partial class frmSifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifremiUnuttum));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties33 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties34 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties35 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties36 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnGonder = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnIptal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "E-MAIL:";
            // 
            // txtMail
            // 
            this.txtMail.AcceptsReturn = false;
            this.txtMail.AcceptsTab = false;
            this.txtMail.AnimationSpeed = 200;
            this.txtMail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMail.BackColor = System.Drawing.Color.Transparent;
            this.txtMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMail.BackgroundImage")));
            this.txtMail.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtMail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtMail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtMail.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMail.BorderRadius = 30;
            this.txtMail.BorderThickness = 1;
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtMail.DefaultText = "";
            this.txtMail.FillColor = System.Drawing.Color.White;
            this.txtMail.HideSelection = true;
            this.txtMail.IconLeft = null;
            this.txtMail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.IconPadding = 10;
            this.txtMail.IconRight = null;
            this.txtMail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Lines = new string[0];
            this.txtMail.Location = new System.Drawing.Point(106, 33);
            this.txtMail.MaxLength = 32767;
            this.txtMail.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMail.Modified = false;
            this.txtMail.Multiline = false;
            this.txtMail.Name = "txtMail";
            stateProperties33.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties33.FillColor = System.Drawing.Color.Empty;
            stateProperties33.ForeColor = System.Drawing.Color.Empty;
            stateProperties33.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMail.OnActiveState = stateProperties33;
            stateProperties34.BorderColor = System.Drawing.Color.Empty;
            stateProperties34.FillColor = System.Drawing.Color.White;
            stateProperties34.ForeColor = System.Drawing.Color.Empty;
            stateProperties34.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMail.OnDisabledState = stateProperties34;
            stateProperties35.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties35.FillColor = System.Drawing.Color.Empty;
            stateProperties35.ForeColor = System.Drawing.Color.Empty;
            stateProperties35.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMail.OnHoverState = stateProperties35;
            stateProperties36.BorderColor = System.Drawing.Color.Silver;
            stateProperties36.FillColor = System.Drawing.Color.White;
            stateProperties36.ForeColor = System.Drawing.Color.Empty;
            stateProperties36.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMail.OnIdleState = stateProperties36;
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMail.PlaceholderText = "E-MAIL";
            this.txtMail.ReadOnly = false;
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(204, 35);
            this.txtMail.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtMail.TabIndex = 7;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMail.TextMarginBottom = 0;
            this.txtMail.TextMarginLeft = 5;
            this.txtMail.TextMarginTop = 0;
            this.txtMail.TextPlaceholder = "E-MAIL";
            this.txtMail.UseSystemPasswordChar = false;
            this.txtMail.WordWrap = true;
            // 
            // btnGonder
            // 
            this.btnGonder.ActiveBorderThickness = 1;
            this.btnGonder.ActiveCornerRadius = 20;
            this.btnGonder.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGonder.ActiveForecolor = System.Drawing.Color.White;
            this.btnGonder.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGonder.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGonder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.BackgroundImage")));
            this.btnGonder.ButtonText = "GONDER";
            this.btnGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGonder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGonder.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGonder.IdleBorderThickness = 1;
            this.btnGonder.IdleCornerRadius = 20;
            this.btnGonder.IdleFillColor = System.Drawing.Color.White;
            this.btnGonder.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGonder.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGonder.Location = new System.Drawing.Point(192, 76);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(5);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(118, 41);
            this.btnGonder.TabIndex = 8;
            this.btnGonder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.ActiveBorderThickness = 1;
            this.btnIptal.ActiveCornerRadius = 20;
            this.btnIptal.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnIptal.ActiveForecolor = System.Drawing.Color.White;
            this.btnIptal.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnIptal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnIptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIptal.BackgroundImage")));
            this.btnIptal.ButtonText = "IPTAL";
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIptal.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnIptal.IdleBorderThickness = 1;
            this.btnIptal.IdleCornerRadius = 20;
            this.btnIptal.IdleFillColor = System.Drawing.Color.White;
            this.btnIptal.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnIptal.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnIptal.Location = new System.Drawing.Point(192, 127);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(5);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(118, 41);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // frmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(350, 199);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSifremiUnuttum";
            this.Text = "frmSifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtMail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGonder;
        private Bunifu.Framework.UI.BunifuThinButton2 btnIptal;
    }
}