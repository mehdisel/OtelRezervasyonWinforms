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
    public partial class frmSifremiUnuttum : Form
    {
        Calisan _calisan;
        Musteri _musteri;
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }
        public frmSifremiUnuttum(Calisan calisan, Musteri musteri)
        {
            InitializeComponent();
            _calisan = calisan;
            _musteri = musteri;
        }


        CalisanController calisanController = new CalisanController();
        MusteriController musteriController = new MusteriController();
        public frmAnaSayfa anaForm;
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (_musteri == null && _calisan != null)
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        if (string.IsNullOrEmpty(item.Text))
                        {
                            MessageBox.Show("Alanlar boş geçilemez!");
                            return;
                        }
                    }
                }
                bool isEmail = Regex.IsMatch(txtMail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (!isEmail)
                {
                    MessageBox.Show("Girilen Mail Standartlara uygun değil!");
                    return;
                }
                else
                {
                    bool emailKayitliMi = calisanController.IsThereEmail(txtMail.Text);

                    if (emailKayitliMi)
                    {
                        string sifre = calisanController.GetCalisanSifre(txtMail.Text);
                        bool gonderdiMi = anaForm.Gonder("Otel şifre hatırlatma", string.Format($"Giriş Bilgileriniz:\n Email:{txtMail.Text} \n Şifreniz:{sifre}"), txtMail.Text);
                        if (gonderdiMi)
                        {
                            MessageBox.Show("Mail Gönderildi!");
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Gondermede sorun oluştu.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu mail sistemde kayıtlı değildir.");
                    }


                }
            }
            else
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        if (string.IsNullOrEmpty(item.Text))
                        {
                            MessageBox.Show("Alanlar boş geçilemez!");
                            return;
                        }
                    }
                }
                bool isEmail = Regex.IsMatch(txtMail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (!isEmail)
                {
                    MessageBox.Show("Girilen Mail Standartlara uygun değil!");
                    return;
                }
                else
                {
                    bool emailKayitliMi = musteriController.IsThereEmail(txtMail.Text);

                    if (emailKayitliMi)
                    {
                        string sifre = musteriController.GetMusteriSifre(txtMail.Text);
                        bool gonderdiMi = anaForm.Gonder("Otel şifre hatırlatma", string.Format($"Giriş Bilgileriniz:\n Email:{txtMail.Text} \n Şifreniz:{sifre}"), txtMail.Text);
                        if (gonderdiMi)
                        {
                            MessageBox.Show("Mail Gönderildi!");
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Gondermede sorun oluştu.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu mail sistemde kayıtlı değildir.");
                    }


                }

            }

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
