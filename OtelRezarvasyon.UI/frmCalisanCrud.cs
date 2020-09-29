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
    public partial class frmCalisanCrud : Form
    {
        public frmCalisanCrud()
        {
            InitializeComponent();
        }
        CalisanController calisanController = new CalisanController();
        List<Calisan> calisanlar;
        ListViewItem lvi;
        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            frmCalisanEkle frmCalisanEkle = new frmCalisanEkle();
            frmCalisanEkle.ShowDialog();

            if (frmCalisanEkle.DialogResult == DialogResult.OK)
            {
                Listele();
            }


        }


        private void frmCalisanCrud_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            listCalisanlar.Items.Clear();
            calisanlar = calisanController.GetAll();

            if (calisanlar != null)

            {

                foreach (Calisan item in calisanlar)
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.Id.ToString();
                    lvi.SubItems.Add(item.Ad);
                    lvi.SubItems.Add(item.Soyad);
                    lvi.SubItems.Add(item.Mail);
                    lvi.SubItems.Add(item.Sifre);
                    lvi.SubItems.Add(item.OtelId.ToString());
                    lvi.SubItems.Add(item.AdminMi.ToString());
                    listCalisanlar.Items.Add(lvi);
                }
            }
        }
        int index;
        private void listCalisanlar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lvi = listCalisanlar.SelectedItems[0] as ListViewItem;
            index = lvi.Index;
            frmCalisanGüncellemeEkrani frmCalisanGüncelleme = new frmCalisanGüncellemeEkrani(calisanlar[index]);
            frmCalisanGüncelleme.anaForm = this;
            frmCalisanGüncelleme.ShowDialog();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
