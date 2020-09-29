using OtelRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezarvasyon.UI
{
    public partial class frmKullaniciKayit : Form
    {
        MusteriController musteriController = new MusteriController();
        public frmKullaniciKayit()
        {
            InitializeComponent();
            _calisan = null;
        }
        Calisan _calisan;
        public frmKullaniciKayit(Calisan calisan)
        {
            _calisan = calisan;
            InitializeComponent();
        }    

        private void btnEkle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    if (_calisan != null)
                    {
                        if (txt.Name == "txtMail" && txt.Name == "txtSifre")
                        {
                            continue;
                        }
                    }
                    else if (string.IsNullOrEmpty(item.Text) || item.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Alanlar boş geçilemez!");
                        return;
                    }
                }

            }

            Musteri yeniMusteri = new Musteri();

            try
            {
                if (Helper.HarfKontrol(txtAd.Text))
                {
                    yeniMusteri.Ad = txtAd.Text;

                }
                else
                {
                    MessageBox.Show("Adınızda sayı ve boşluk olamaz!");

                    return;
                }
                if (Helper.HarfKontrol(txtSoyad.Text))
                {
                    yeniMusteri.Soyad = txtSoyad.Text;

                }
                else
                {
                    MessageBox.Show("Soyadınızda sayı ve boşluk olamaz!");

                    return;
                }
                if (Helper.TcNoFormatKontrol(txtTc.Text))
                {
                    yeniMusteri.TcNo = txtTc.Text;
                }
                else
                {
                    MessageBox.Show("Tc KimlikNo hatalıdır. Lütfen kontrol ediniz.");
                    return;
                }
                if (Helper.TelefonFormatKontrol(txtTelefon.Text))
                {
                    yeniMusteri.Telefon = txtTelefon.Text;// kaydetme işlemlerlerinizi yapabilirsiniz.
                }
                else
                {
                    MessageBox.Show("Telefon numarası hatalıdır. Lütfen kontrol ediniz.");
                    return;
                }
                if (_calisan != null)
                {
                    if (musteriController.IsThereMusteri(txtTc.Text))
                    {

                        frmOdaSecimi frm = new frmOdaSecimi(musteriController.GetMusteriByTc(txtTc.Text));
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        bool yanMusteriEklendiMi = musteriController.AddYanMusteri(yeniMusteri);
                        if (yanMusteriEklendiMi)
                        {
                            MessageBox.Show("Musteri ekleme başarılı!");
                            frmOdaSecimi frm = new frmOdaSecimi(yeniMusteri);
                            this.Hide();
                            frm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Musteri ekleme başarısız!");
                        }

                    }

                }
                else
                {

                    if (Helper.MailFormatKontrol(txtMail.Text))
                    {

                        yeniMusteri.Mail = txtMail.Text;
                    }
                    else
                    {
                        MessageBox.Show("Girilen Mail Standartlara uygun değil!");
                        return;
                    }
                    if (Helper.SifreKontrol(txtSifre.Text))
                    {
                        yeniMusteri.Sifre = txtSifre.Text;
                    }
                    else
                    {
                        MessageBox.Show("Sifre en az 6 haneli olmalı. Boşluk ve özel karakter içeremez!");
                        return;

                    }
                    if (!musteriController.IsThereMusteri(txtTc.Text))
                    {
                        if (!musteriController.IsThereEmail(txtMail.Text))
                        {
                            bool eklendiMi = musteriController.AddMusteri(yeniMusteri);
                            if (eklendiMi)
                            {
                                MessageBox.Show("Ekleme Başarılı!");

                            }
                            else
                            {
                                MessageBox.Show("Eklenemedi!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bu mail başkası tarafından kullanılıyor.Lütfen başka mail giriniz.");
                            txtMail.Clear();
                            return;
                        }
                    }
                    else if (musteriController.IsThereMusteri(txtTc.Text) && musteriController.GetMusteriByTc(txtTc.Text).Mail == "")
                    {
                        bool guncellendiMi = musteriController.UpdateMusteriMailSifre(yeniMusteri);
                        MessageBox.Show("Sistemde kayıtlı isminize göre mail ve şifreniz eklenmiştir!");
                    }
                    else
                    {
                        DialogResult dlg = MessageBox.Show("Bu kişi sistemde kayıtlı mailinize şifre gönderilsin mi ?", "Hata Mesajı", MessageBoxButtons.YesNo);
                        if (dlg == DialogResult.Yes)
                        {
                            Musteri musteriSifreHatirlatma = musteriController.GetMusteriByTc(txtTc.Text);
                            string icerik = string.Format($"Sayın {musteriSifreHatirlatma.Ad} giriş bilgileriniz : \nMail:{musteriSifreHatirlatma.Mail}\nŞifre:{musteriSifreHatirlatma.Sifre}");
                            Helper.Gonder("Bilge Adam Otel Şifre Hatırlatma", icerik, musteriSifreHatirlatma.Mail);

                        }
                    }

                }

                this.DialogResult = DialogResult.OK;

                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

    

        private void lblGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblGeri_MouseHover(object sender, EventArgs e)
        {
            lblGeri.ForeColor = Color.White;
        }

        private void lblGeri_MouseLeave(object sender, EventArgs e)
        {
            lblGeri.ForeColor = Color.Coral;
        }
        private void frmKullaniciKayit_Load(object sender, EventArgs e)
        {
            if (_calisan != null)
            {
                txtMail.Visible = false;
                txtSifre.Visible = false;
                btnEkle.Top = 300;
            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
            else if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           if (_calisan != null)
            {
                txtMail.Visible = false;
                txtSifre.Visible = false;
                btnEkle.Top = 300;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
