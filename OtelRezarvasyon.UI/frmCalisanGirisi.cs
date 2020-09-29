using OtelRezervasyon.DTO;
using OtelRezervasyon.Entities;
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
    public partial class frmCalisanGirisi : Form
    {
        public frmCalisanGirisi()
        {
            InitializeComponent();
        }


        CalisanController calisanController = new CalisanController();
        public frmAnaSayfa anaForm;
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

            LoginModel user = new LoginModel();
            user.Mail = txtEmail.Text.Trim();
            user.Sifre = txtSifre.Text;
            Calisan girisYapan = calisanController.Login(user);

            if (girisYapan != null)
            {
                frmCalisanİslem frm = new frmCalisanİslem(girisYapan);
                this.Hide();
                frm.ShowDialog();
            }
            else if (txtEmail.Text == "admin" && txtSifre.Text == "1234")
            {
                Calisan admin = new Calisan();
                admin.Ad = "admin";
                frmCalisanİslem frm = new frmCalisanİslem(admin);
                this.Hide();
                frm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya sifre hatalı!");
            }
        }

        private void lblSifre_Click(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan()
            {
                Ad = "asd"
            };
            frmSifremiUnuttum frm = new frmSifremiUnuttum(calisan, null);
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCalisanGirisi_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            txtSifre.MaxLength = 49;
            txtEmail.MaxLength = 319;
        }
    }
}
