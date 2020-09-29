using OtelRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezarvasyon.UI
{
    public partial class frmCalisanGüncellemeEkrani : Form
    {
        public frmCalisanGüncellemeEkrani()
        {
            InitializeComponent();
        }

        Calisan _calisan;
        public frmCalisanCrud anaForm;
        CalisanController calisanController = new CalisanController();
        public frmCalisanGüncellemeEkrani(Calisan calisan)
        {
            _calisan = calisan;
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
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
            if (Helper.HarfKontrol(txtAd.Text))
            {
                _calisan.Ad = txtAd.Text;
            }
            else
            {
                MessageBox.Show("Calisan isminde boşluk ve sayı olamaz!");
                return;
            }
            if (Helper.HarfKontrol(txtSoyad.Text))
            {
                _calisan.Soyad = txtSoyad.Text;
            }
            else
            {
                MessageBox.Show("Calisan soyisminde boşluk ve sayı olamaz!");
                return;
            }

            if (Helper.MailFormatKontrol(txtMail.Text))
            {
                _calisan.Mail = txtMail.Text;
            }
            else
            {
                MessageBox.Show("Girilen Mail Standartlara uygun değil!");
                return;

            }
            if (Helper.SifreKontrol(txtSifre.Text))
            {
                _calisan.Sifre = txtSifre.Text;
            }
            else
            {
                MessageBox.Show("Sifre en az 6 haneli olmalı. Boşluk ve özel karakter içeremez!");
                return;

            }
            _calisan.OtelId = 1;
            _calisan.AdminMi = cbYetki.Checked;

            bool guncellendiMi = calisanController.UpdateCalisan(_calisan);
            if (guncellendiMi)
            {
                MessageBox.Show("Güncellendi");
                anaForm.Listele();
                this.Close();
            }
            else
            {
                MessageBox.Show("Güncellenmedi");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bool silindiMi = calisanController.DeleteCalisanId(_calisan.Id);
            if (silindiMi)
            {
                MessageBox.Show("Silindi");
                anaForm.Listele();
                this.Close();
            }
            else
            {
                MessageBox.Show("Silinmedi");
            }

        }

        private void frmCalisanGüncellemeEkrani_Load(object sender, EventArgs e)
        {
            txtAd.MaxLength = 49;
            txtSoyad.MaxLength = 49;
            txtMail.MaxLength = 319;
            txtSifre.MaxLength = 49;
            txtSifre.UseSystemPasswordChar = true;
            txtAd.Text = _calisan.Ad;
            txtSoyad.Text = _calisan.Soyad;
            txtMail.Text = _calisan.Mail;
            txtSifre.Text = _calisan.Sifre;
            cbYetki.Checked = _calisan.AdminMi;

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


    }
}
