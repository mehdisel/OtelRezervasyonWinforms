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
    public partial class frmRezervasyonList : Form
    {
        RezervasyonController rezervasyonController = new RezervasyonController();
        MusteriController musteriController = new MusteriController();
        OtelController otelController = new OtelController();
        RezervasyondakiMusterilerController rezervasyondakiMusterilerController = new RezervasyondakiMusterilerController();
        List<Rezervasyon> rezervasyonlar;
        ListViewItem lvi;
        public frmRezervasyonList()
        {
            InitializeComponent();
        }

        private void RezervasyonlarıListele()
        {
            int MusteriId = 0;
            int OtelId = 0;
            string musteriAdSoyad = musteriController.GetMusteriById(MusteriId);
            string OtelAdi = otelController.GetOtelById(OtelId);

            lstRezGoruntule.Items.Clear();
            rezervasyonlar = rezervasyonController.GetAll();

            if (rezervasyonlar != null)

            {

                foreach (Rezervasyon item in rezervasyonlar)
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.Id.ToString();
                    lvi.SubItems.Add(item.GirisTarihi.ToLongDateString());
                    lvi.SubItems.Add(item.CikisTarihi.ToLongDateString());
                    lvi.SubItems.Add(musteriController.GetMusteriById(item.MusteriId));
                    lvi.SubItems.Add(item.KisiSayisi.ToString());
                    lvi.SubItems.Add(otelController.GetOtelById(item.OtelId));
                    lvi.SubItems.Add(item.OdaId.ToString());
                    lvi.SubItems.Add(item.RezervasyonTipId.ToString());
                    lstRezGoruntule.Items.Add(lvi);
                }
            }
        }

        private void frmRezervasyonList_Load(object sender, EventArgs e)
        {
            btnRezSil.Enabled = false;
            lstRezGoruntule.FullRowSelect = true;
            lstRezGoruntule.MultiSelect = false;
            RezervasyonlarıListele();
        }

        private void lstRezGoruntule_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRezSil.Enabled = true;
            lvi = lstRezGoruntule.SelectedItems[0] as ListViewItem;
        }

        private void btnRezSil_Click(object sender, EventArgs e)
        {


            bool silindiMi = rezervasyondakiMusterilerController.DeleteById(Convert.ToInt32(lvi.Text));
            if (silindiMi)
            {
                if (rezervasyonController.DeleteRezId(Convert.ToInt32(lvi.Text)))
                {
                    MessageBox.Show("silindi");
                    RezervasyonlarıListele();

                }
            }
            else
            {
                MessageBox.Show("hata");
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
