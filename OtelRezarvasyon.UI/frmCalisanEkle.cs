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
    public partial class frmCalisanEkle : Form
    {
        public frmCalisanEkle()
        {
            InitializeComponent();
        }

        CalisanController calisanController = new CalisanController();
        public frmCalisanGirisi anaForm;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrEmpty(item.Text) || item.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Alanlar boş geçilemez!");
                        return;
                    }
                }

            }
            Calisan yeniCalisan = new Calisan();

            try
            {
                if (Helper.HarfKontrol(txtAd.Text))
                {
                    yeniCalisan.Ad = txtAd.Text;
                }
                else
                {
                    MessageBox.Show("Calisan isminde boşluk ve sayı olamaz!");
                    return;
                }
                if (Helper.HarfKontrol(txtSoyad.Text))
                {
                    yeniCalisan.Soyad = txtSoyad.Text;
                }
                else
                {
                    MessageBox.Show("Calisan Soyisminde boşluk ve sayı olamaz!");
                    return;
                }


                if (Helper.MailFormatKontrol(txtMail.Text))
                {
                    if (!calisanController.IsThereEmail(txtMail.Text))
                    {
                        yeniCalisan.Mail = txtMail.Text;
                    }
                    else
                    {
                        MessageBox.Show("Bu mail adresiyle eklenmiş çalışan mevcut!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Girilen Mail Standartlara uygun değil!");
                    return;

                }
                if (Helper.SifreKontrol(txtSifre.Text))
                {
                    yeniCalisan.Sifre = txtSifre.Text;
                }
                else
                {
                    MessageBox.Show("Sifre en az 6 haneli olmalı. Boşluk ve özel karakter içeremez!");
                    return;

                }

                yeniCalisan.AdminMi = (cbYetki.Checked ? true : false);
                yeniCalisan.OtelId = 1;

                if (calisanController.AddCalisan(yeniCalisan))
                {
                    MessageBox.Show("Ekleme Başarılı!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ekleme Başarısız!");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
            else if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblGeri_MouseHover(object sender, EventArgs e)
        {
            lblGeri.ForeColor = Color.White;
        }

        private void lblGeri_MouseLeave(object sender, EventArgs e)
        {
            lblGeri.ForeColor = Color.Coral;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
