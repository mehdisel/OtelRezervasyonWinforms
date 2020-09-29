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
    public partial class frmOdaSecimi : Form
    {
        public frmOdaSecimi()
        {
            InitializeComponent();
            sonTiklananBtn = new Button();
        }

        public frmOdaSecimi(Musteri musteri)
        {
            InitializeComponent();
            sonTiklananBtn = new Button();
            _calisan = null;
            _musteri = musteri;
        }
        public frmOdaSecimi(Calisan calisan)
        {
            InitializeComponent();
            sonTiklananBtn = new Button();
            _calisan = calisan;
            _musteri = null;

        }
        RezervasyonController rezervasyonController = new RezervasyonController();
        RezervasyonTipiController rezervasyonTipiController = new RezervasyonTipiController();
        OdaController odaController = new OdaController();
        OdaDetayController odaDetayController = new OdaDetayController();
        Button btn;
        int sayac = 0;
        Calisan _calisan;
        Musteri _musteri;
        int tiklananOda = 0;
        private void frmOtelAramaListeleme_Load(object sender, EventArgs e)
        {
            dtpGiris.Value = DateTime.Now;
            dtpGiris.MinDate = DateTime.Now;
            OdaButonlariniOlustur();
            ButonRenkYenile();
            DoluOdalariİsaretle();
            comboBoxlariDoldur();
            lblSecilen.Text = "";
            lblToplamTutar.Text = "";
        }
        Button sonTiklananBtn;
        private void RezeravsyonClicki(object sender, EventArgs e)
        {
            sonTiklananBtn = sender as Button;
            ButonRenkYenile();
            DoluOdalariİsaretle();
            OdaIsaretleme();
            tiklananOda = Convert.ToInt32(sonTiklananBtn.Tag);
            FiyatHesapla();
        }
        public void OdaIsaretleme()
        {
            if (sonTiklananBtn.BackColor == Color.Orange)
            {
                lblSecilen.Text = "Sectiğiniz oda:";
                sonTiklananBtn.BackColor = Color.Gray;
                ButonRenkYenile();
                DoluOdalariİsaretle();
            }
            else
            {
                lblSecilen.Text = "Sectiğiniz oda: " + sonTiklananBtn.Text;
                sonTiklananBtn.BackColor = Color.Orange;

            }
        }
        decimal toplamTutar = 0;
        public void FiyatHesapla()
        {
            if (tiklananOda != 0)
            {
                toplamTutar = 0;
                decimal odaFiyati = odaDetayController.GetRoomPrice(tiklananOda);
                RezervasyonTipi secilenRezervasyontipi = cmbRezervasyonTipleri.SelectedItem as RezervasyonTipi;
                if (cmbOdaSecimi.SelectedIndex == 0)
                {
                    odaFiyati *= 0.70M;
                }
                else if (cmbOdaSecimi.SelectedIndex == 2)
                {
                    odaFiyati *= 1.2M;
                }
                for (DateTime i = dtpGiris.Value; i < dtpCikis.Value;)
                {
                    if (i.DayOfWeek == DayOfWeek.Friday || i.DayOfWeek == DayOfWeek.Saturday)
                    {
                        toplamTutar += (odaFiyati * 1.3M) + secilenRezervasyontipi.Fiyat;
                    }
                    else
                    {
                        toplamTutar += odaFiyati + secilenRezervasyontipi.Fiyat;
                    }
                    i = i.AddDays(1);
                }
                lblToplamTutar.Text = "Oda Fiyatı:" + Math.Round(toplamTutar, 2);
            }


        }
        public void OdaButonlariniOlustur()
        {
            List<Oda> odalar = odaController.GetAll();
            for (int i = 1; i <= Math.Ceiling((decimal)odaController.GetRoomCount() / 10); i++)
            {
                for (int n = 1; n <= 10; n++)
                {
                    sayac++;
                    btn = new Button();
                    btn.Location = new Point(n * 100 - 100, i * 62 - 10);
                    //btn.Location = new Point(i * 100 - 100, n * 40 - 20);
                    btn.Height = 40;
                    btn.Width = 100;
                    btn.Tag = sayac.ToString();
                    btn.Text = btn.Tag.ToString();
                    btn.Click += new EventHandler(RezeravsyonClicki);
                    groupBox1.Controls.Add(btn);
                    if (odaController.GetRoomCount() == sayac)
                    {
                        return;
                    }
                }
            }
        }

        private void CalisanRezeravsyonClicki(object sender, EventArgs e)
        {

        }

        public void DoluOdalariİsaretle()
        {
            List<int> doluOdalar = rezervasyonController.GetFullRooms(dtpGiris.Value);
            foreach (Control item in groupBox1.Controls)
            {
                if (item is Button)
                {
                    Button btn = item as Button;
                    foreach (int sayi in doluOdalar)
                    {
                        if (sayi == Convert.ToInt32(btn.Tag))
                        {
                            btn.BackColor = Color.Red;
                            btn.Enabled = false;
                        }
                    }

                }
            }
        }
        public void ButonRenkYenile()
        {
            List<int> doluOdalar = rezervasyonController.GetFullRooms(dtpGiris.Value);
            foreach (Control item in groupBox1.Controls)
            {
                if (item is Button)
                {
                    Button btn = item as Button;
                    btn.BackColor = Color.Gray;
                    btn.Enabled = true;
                }
            }
        }
        private void comboBoxlariDoldur()
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cmb = item as ComboBox;
                    if (cmb.Name == "cmbSuit")
                    {
                        cmb.Items.Add("Hayir");
                        cmb.Items.Add("Evet");
                        cmb.Items.Add("Fark etmez");
                        cmb.SelectedIndex = 2;
                        continue;
                    }
                    cmb.Items.Add("Yok");
                    cmb.Items.Add("Var");
                    cmb.Items.Add("Fark etmez");

                    cmb.SelectedIndex = 2;
                }
            }
            cmbOdaSecimi.Items.Add("1 kişi 1 oda 2 yatak");
            cmbOdaSecimi.Items.Add("2 kişi 1 oda 2 yatak");
            cmbOdaSecimi.Items.Add("3 kişi 1 oda 3 yatak");
            cmbOdaSecimi.SelectedIndex = 0;
            foreach (RezervasyonTipi item in rezervasyonTipiController.GetAll())
            {
                cmbRezervasyonTipleri.Items.Add(item);
            }
            cmbRezervasyonTipleri.SelectedIndex = 0;
        }
        private void dtpGiris_ValueChanged(object sender, EventArgs e)
        {
            ButonRenkYenile();
            DoluOdalariİsaretle();
            OdaIsaretleme();
            FiyatHesapla();
            dtpCikis.MinDate = dtpGiris.Value.AddDays(1);
        }

        void Filtrele(List<int> odalar)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is Button)
                {
                    Button btn = item as Button;
                    foreach (int sayi in odalar)
                    {
                        if (Convert.ToInt32(btn.Tag) == sayi)
                        {
                            btn.Visible = true;
                        }

                    }

                }
            }
        }
        void ButonlariKilitle()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is Button)
                {
                    Button btn = item as Button;
                    btn.Visible = false;

                }
            }
        }
        private void cmbWifi_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> wifiliOdalar = odaDetayController.GetWifiRooms(cmbWifi.SelectedIndex);
            List<int> klimaliOdalar = odaDetayController.GetAirConditionerRooms(cmbKlima.SelectedIndex);
            List<int> televizyonluOdalar = odaDetayController.GetTelevisionRooms(cmbTelevizyon.SelectedIndex);
            List<int> jakuziliOdalar = odaDetayController.GetJacuzziRooms(cmbJakuzi.SelectedIndex);
            List<int> suitOlanOdalar = odaDetayController.GetSuiteRooms(cmbSuit.SelectedIndex);
            List<int> manzaraliOdalar = odaDetayController.GetScenicRooms(cmbManzara.SelectedIndex);
            List<int> Birlesim = new List<int>();
            foreach (int item in wifiliOdalar.Intersect(klimaliOdalar.Intersect(televizyonluOdalar.Intersect(jakuziliOdalar.Intersect(suitOlanOdalar.Intersect(manzaraliOdalar))))))
            {
                Birlesim.Add(item);
            }
            ButonlariKilitle();
            Filtrele(Birlesim);
            ButonRenkYenile();
            DoluOdalariİsaretle();
            FiyatHesapla();

            lblSecilen.Text = "Sectiğiniz oda:";
            lblToplamTutar.Text = "Oda Fiyatı:";
            tiklananOda = 0;
        }

        private void cmbOdaSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiyatHesapla();
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
            FiyatHesapla();
        }


        //if (tiklananOda == 0)
        //    {
        //        MessageBox.Show("oda secmedin");
        //    }
        //    else
        //    {

        //        MessageBox.Show(tiklananOda.ToString());
        //    }
        private void btnSifirla_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cmb = item as ComboBox;
                    cmb.SelectedIndex = 2;
                }
            }
        }

        private void btnOdemeSayfasinaGec_Click(object sender, EventArgs e)
        {
            if (tiklananOda == 0)
            {
                MessageBox.Show("Oda Seciniz;");
            }
            else
            {
                Rezervasyon rezervasyon = new Rezervasyon()
                {
                    GirisTarihi = dtpGiris.Value,
                    CikisTarihi = dtpCikis.Value,
                    KisiSayisi = cmbOdaSecimi.SelectedIndex + 1,
                    MusteriId = _musteri.Id,
                    OdaId = tiklananOda,
                    OtelId = 1,//daha sonra değişecek
                    RezervasyonTipId = ((RezervasyonTipi)cmbRezervasyonTipleri.SelectedItem).Id
                };
                OdaDetay odaDetay = odaDetayController.GetRoomProperties(tiklananOda);
                frmOdadaKalacakOlanlar frm = new frmOdadaKalacakOlanlar(rezervasyon, _musteri, odaDetay, (RezervasyonTipi)cmbRezervasyonTipleri.SelectedItem, Math.Round(toplamTutar, 2));
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {           
            this.Hide();
        }

        private void btnGecmisRezervasyonlar_Click(object sender, EventArgs e)
        {
            frmGecmisRezervasyonGörüntülemeEkrani frm = new frmGecmisRezervasyonGörüntülemeEkrani(_musteri);
            frm.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
