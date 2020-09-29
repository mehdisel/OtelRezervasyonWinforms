using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezarvasyon.UI
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }       
        public bool Gonder(string konu, string icerik, string mailAdress)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("hasankamil2355@gmail.com");
            ePosta.To.Add(mailAdress);
            ePosta.Subject = konu;
            ePosta.Body = icerik;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("hasankamil2355@gmail.com", "123123haskam");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
        }

        private void btnAdminGiris_Click_1(object sender, EventArgs e)
        {
            frmCalisanGirisi frm = new frmCalisanGirisi();
            frm.anaForm = this;
            this.Hide();
            frm.Show();
        }

        private void btnKullaniciGiris_Click_1(object sender, EventArgs e)
        {
            frmKullaniciGiris frm = new frmKullaniciGiris();
            frm.anaForm = this;
            this.Hide();
            frm.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
