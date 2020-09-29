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
    public partial class frmGecmisRezervasyonGörüntülemeEkrani : Form
    {
        Musteri _musteri;
        public frmGecmisRezervasyonGörüntülemeEkrani(Musteri musteri)
        {
            _musteri = musteri;
            InitializeComponent();
        }
        RezervasyonController rezervasyonController = new RezervasyonController();
        MusteriController musteriController = new MusteriController();
        OtelController otelController = new OtelController();
        RezervasyonTipiController rezervasyonTipiController = new RezervasyonTipiController();
        List<Rezervasyon> rezervasyonlar;
        private void frmGecmisRezervasyonGörüntülemeEkrani_Load(object sender, EventArgs e)
        {

            lstRezGoruntule.Items.Clear();
            rezervasyonlar = rezervasyonController.GetRezervasyonlarByMusteriId(_musteri.Id);
            label1.Text = "Hoşgeldin " + _musteri.Ad;
            RezervasyonTipi rezervasyonTipi = rezervasyonTipiController.GetRezervasyonTipiById(0);
            if (rezervasyonlar != null)
            {
                ListViewItem lvi;
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
                    lvi.SubItems.Add(rezervasyonTipiController.GetRezervasyonTipiById(item.RezervasyonTipId).TipAdi);
                    lstRezGoruntule.Items.Add(lvi);
                }
            }
        }
    }
}

