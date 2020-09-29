using OtelRezervasyon.DTO;
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
    public partial class frmKullaniciGiris : Form
    {

        MusteriController musteriController = new MusteriController();

        public frmKullaniciGiris()
        {
            InitializeComponent();
        }
        public frmAnaSayfa anaForm;
        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            frmKullaniciKayit frmKullaniciKayit = new frmKullaniciKayit();
            frmKullaniciKayit.ShowDialog();
        }
        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {

        }
        public static bool MailFormatKontrol(string Mail)
        {
            string RegexDesen = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Match Eslesme = Regex.Match(Mail, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success;
        }
        private void btnGiris_Click(object sender, EventArgs e)
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
            LoginModel girisYapan = new LoginModel();

            bool MailDogruMu = MailFormatKontrol(txtEmail.Text);

            if (MailDogruMu)
            {
                girisYapan.Mail = txtEmail.Text.Trim();
            }
            else
            {
                MessageBox.Show("Girilen Mail standartlara uygun değil!");
                return;

            }

            girisYapan.Sifre = txtSifre.Text;
            Musteri girisYapmis = musteriController.Login(girisYapan);

            if (girisYapmis != null)
            {
                frmOdaSecimi frmOdaSecimi = new frmOdaSecimi(girisYapmis);
                this.Hide();
                frmOdaSecimi.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }

        }

        private void lblSifre_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri()
            {
                Ad = "asd"
            };
            frmSifremiUnuttum frm = new frmSifremiUnuttum(null, musteri);
            frm.anaForm = anaForm;
            frm.ShowDialog();
        }

        private void lblGeri_Click(object sender, EventArgs e)
        {
            frmAnaSayfa frm = new frmAnaSayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void lblGeri_MouseHover(object sender, EventArgs e)
        {
            lblGeri.ForeColor = Color.White;
        }

        private void lblGeri_MouseLeave(object sender, EventArgs e)
        {
            lblGeri.ForeColor = Color.Coral;
        }

        private void lblSifremiUnuttum_MouseHover(object sender, EventArgs e)
        {
            lblSifremiUnuttum.ForeColor = Color.White;
        }

        private void lblSifremiUnuttum_MouseLeave(object sender, EventArgs e)
        {
            lblSifremiUnuttum.ForeColor = Color.Coral;
        }

        private void lblSifremiUnuttum_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri()
            {
                Ad = "asd"
            };
            frmSifremiUnuttum frm = new frmSifremiUnuttum(null, musteri);
            frm.anaForm = anaForm;
            frm.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
