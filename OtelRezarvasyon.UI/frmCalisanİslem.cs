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
    public partial class frmCalisanİslem : Form
    {
        Calisan _calisan;
        public frmCalisanİslem(Calisan calisan)
        {
            _calisan = calisan;
            InitializeComponent();
        }


        private void btnCalisanİslem_Click_1(object sender, EventArgs e)
        {
            frmCalisanCrud frmCalisanCrud = new frmCalisanCrud();
            frmCalisanCrud.Show();

        }

        private void btnRezGoruntule_Click(object sender, EventArgs e)
        {            
            frmRezervasyonList frmRezervasyonList = new frmRezervasyonList();
            frmRezervasyonList.Show();
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            frmKullaniciKayit frm = new frmKullaniciKayit(_calisan);
            this.Hide();
            frm.ShowDialog();
            this.Show();
      

        }
        private void btnOdaİslemleri_Click(object sender, EventArgs e)
        {
            frmOdaİslemleri frm = new frmOdaİslemleri();
            frm.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
