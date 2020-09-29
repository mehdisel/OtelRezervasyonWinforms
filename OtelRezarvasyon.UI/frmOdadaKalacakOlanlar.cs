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
    public partial class frmOdadaKalacakOlanlar : Form
    {
        Rezervasyon _rezervasyon;
        Musteri _musteri;
        OdaDetay _odaDetay;
        RezervasyonTipi _rezervasyonTipi;
        List<Musteri> kalacakMusteriler;
        List<Musteri> sonEklenenMusteriler;
        decimal _topTutar;
        
        public frmOdadaKalacakOlanlar(Rezervasyon rezervasyon, Musteri musteri, OdaDetay odaDetay, RezervasyonTipi rezervasyonTipi, decimal topTutar)
        {
            _topTutar = topTutar;
            _rezervasyon = rezervasyon;
            _rezervasyonTipi = rezervasyonTipi;
            _musteri = musteri;
            _odaDetay = odaDetay;
            kalacakMusteriler = new List<Musteri>();
            sonEklenenMusteriler = new List<Musteri>();
            InitializeComponent();
        }

        public void FormuDuzenle(int kSayisi)
        {
            if (kSayisi == 1)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Left = 10;
                btnRezervasyonuTamamla.Left = 157;
                this.Width = 370;
            }
            else if (kSayisi == 2)
            {
                groupBox2.Visible = false;
                groupBox3.Left = 250;
                btnRezervasyonuTamamla.Left = 400;
                this.Width = 610;
            }
        }
        MusteriController musteriController = new MusteriController();
        RezervasyonController rezervasyonController = new RezervasyonController();
        RezervasyondakiMusterilerController rezervasyondakiMusterilerController = new RezervasyondakiMusterilerController();
        FaturaController faturaController = new FaturaController();
        private void btnIkinciyiEkle_Click(object sender, EventArgs e)
        {

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrEmpty(item.Text) || item.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Tüm alanları doldurunuz!");
                        return;
                    }
                }
            }
            if (Helper.TcNoFormatKontrol(txtTcKimlikIki.Text))
            {
                if (Helper.TelefonFormatKontrol(txtTelIki.Text))
                {
                    if (Helper.HarfKontrol(txtAdIki.Text) && Helper.HarfKontrol(txtSoyadIki.Text))
                    {
                        if (_musteri.TcNo != txtTcKimlikIki.Text)
                        {
                            if (!KalanlarinListesindeEklencekOlanVarMı(txtTcKimlikIki.Text))
                            {
                                bool kisiVarMi = musteriController.IsThereMusteri(txtTcKimlikIki.Text);
                                if (!kisiVarMi)
                                {
                                    Musteri musteri = new Musteri()
                                    {
                                        TcNo = txtTcKimlikIki.Text,
                                        Ad = txtAdIki.Text,
                                        Soyad = txtSoyadIki.Text,
                                        Telefon = txtTelIki.Text
                                    };
                                    kalacakMusteriler.Add(musteri);
                                    //foreach (Control item in groupBox1.Controls)
                                    //{
                                    //    if (item is TextBox)
                                    //    {
                                    //        item.Enabled = false;
                                    //    }
                                    //}

                                    txtTcKimlikIki.Enabled = false;
                                    txtAdIki.Enabled = false;
                                    txtSoyadIki.Enabled = false;
                                    txtTelIki.Enabled = false;

                                    btnIkinciyiEkle.Enabled = false;
                                    btnIptalIki.Enabled = true;
                                    BilgilerinTamamlanmaDurumuKontrol();
                                }
                                else
                                {
                                    DialogResult dlg = MessageBox.Show("Bu kişi zaten kayıtlı bilgileri getirilsin mi ?", "Hata mesajı", MessageBoxButtons.YesNo);
                                    if (dlg == DialogResult.Yes)
                                    {
                                        Musteri olanMusteri = musteriController.GetMusteriByTc(txtTcKimlikIki.Text);
                                        if (olanMusteri != null)
                                        {
                                            txtTcKimlikIki.Text = olanMusteri.TcNo;
                                            txtAdIki.Text = olanMusteri.Ad;
                                            txtSoyadIki.Text = olanMusteri.Soyad;
                                            txtTelIki.Text = olanMusteri.Telefon;
                                            kalacakMusteriler.Add(olanMusteri);
                                            //foreach (Control item in groupBox1.Controls)
                                            //{
                                            //    if (item is TextBox)
                                            //    {
                                            //        item.Enabled = false;
                                            //    }
                                            //}
                                            txtTcKimlikIki.Enabled = false;
                                            txtAdIki.Enabled = false;
                                            txtSoyadIki.Enabled = false;
                                            txtTelIki.Enabled = false;

                                            btnIkinciyiEkle.Enabled = false;
                                            btnIptalIki.Enabled = true;
                                            BilgilerinTamamlanmaDurumuKontrol();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Musteri bilgileri getirilmedi");
                                        }
                                    }

                                }
                            }
                            else
                            {
                                MessageBox.Show("Girilen ilk kişiyle aynı kişiyi girdiniz!");
                                //foreach (Control item in groupBox1.Controls)
                                //{
                                //    if (item is TextBox)
                                //    {
                                //        item.Text = "";
                                //    }
                                //}
                                txtTcKimlikIki.Text = "";
                                txtAdIki.Text = "";
                                txtSoyadIki.Text = "";
                                txtTelIki.Text = "";
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen yanınızda kalacak olan kişiyi giriniz!");
                            //foreach (Control item in groupBox1.Controls)
                            //{
                            //    if (item is TextBox)
                            //    {
                            //        item.Text = "";
                            //    }
                            //}
                            txtTcKimlikIki.Text = "";
                            txtAdIki.Text = "";
                            txtSoyadIki.Text = "";
                            txtTelIki.Text = "";
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ad ve Soyad sayı içeremez!");
                    }
                }
                else
                {
                    MessageBox.Show("Doğru formatta telefon numarası girilmedi!");
                }
            }
            else
            {
                MessageBox.Show("Girilen TC. Kimlik Numarası 11 Haneli olmalıdır.İlk rakamı 0 olamaz!");
            }


        }
        
        private bool KalanlarinListesindeEklencekOlanVarMı(string tc)
        {
            foreach (Musteri item in kalacakMusteriler)
            {
                if (item.TcNo == tc)
                {
                    return true;
                }
            }
            return false;
        }
        private void frmOdadaKalacakOlanlar_Load(object sender, EventArgs e)
        {
            FormuDuzenle(_rezervasyon.KisiSayisi);
            lblGirisTarihi.Text = "Giriş Tarihi:" + _rezervasyon.GirisTarihi.ToShortDateString();
            lblCikisTarihi.Text = "Çıkış Tarihi:" + _rezervasyon.CikisTarihi.ToShortDateString();
            lblMusteriAdi.Text = "Müşteri Adı:" + _musteri.Ad + " " + _musteri.Soyad;
            lblRezervasyonTipi.Text = "Rezervasyon Tipi:" + _rezervasyonTipi.TipAdi;
            lblToplamTutar.Text = "Toplam Tutar:" + _topTutar.ToString() + "₺";
            lblOdaNo.Text = "Oda Numarası:" + _odaDetay.OdaId;
            lblOdaTipi.Text = "Oda Tipi:" + (_odaDetay.SuitMi ? "Suit" : "Standart");
            lblWifiDurumu.Text = "Wifi Durumu:" + (_odaDetay.WifiVarMi ? "Var" : "Yok");
            lblKlimaDurumu.Text = "Klima Durumu:" + (_odaDetay.KlimaVarMi ? "Var" : "Yok");
            lblTelevizyonDurumu.Text = "Televizyon Durumu:" + (_odaDetay.TelevizyonVarMi ? "Var" : "Yok");
            lblJakuziDurumu.Text = "Jakuzi Durumu:" + (_odaDetay.JakuziVarMi ? "Var" : "Yok");
            lblManzaraDurumu.Text = "Manzara Durumu:" + (_odaDetay.ManzaraVarMi ? "Var" : "Yok");
            btnIptalIki.Enabled = false;
            btnIptalUc.Enabled = false;
            btnRezervasyonuTamamla.Enabled = false;
            BilgilerinTamamlanmaDurumuKontrol();

        }

        private void btnUcuncuyuEkle_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrEmpty(item.Text) || item.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Tüm alanları doldurunuz!");
                        return;
                    }
                }
            }
            if (Helper.TcNoFormatKontrol(txtTcKimlikUc.Text))
            {
                if (Helper.TelefonFormatKontrol(txtTelUc.Text))
                {
                    if (Helper.HarfKontrol(txtAdUc.Text) && Helper.HarfKontrol(txtSoyadUc.Text))
                    {
                        if (_musteri.TcNo != txtTcKimlikUc.Text)
                        {
                            if (!KalanlarinListesindeEklencekOlanVarMı(txtTcKimlikUc.Text))
                            {
                                bool kisiVarMi = musteriController.IsThereMusteri(txtTcKimlikUc.Text);
                                if (!kisiVarMi)
                                {
                                    Musteri musteri = new Musteri()
                                    {
                                        TcNo = txtTcKimlikUc.Text,
                                        Ad = txtAdUc.Text,
                                        Soyad = txtSoyadUc.Text,
                                        Telefon = txtTelUc.Text
                                    };
                                    kalacakMusteriler.Add(musteri);
                                    //foreach (Control item in groupBox2.Controls)
                                    //{
                                    //    if (item is TextBox)
                                    //    {
                                    //        item.Enabled = false;
                                    //    }
                                    //}
                                    txtTcKimlikUc.Enabled = false;
                                    txtAdUc.Enabled = false;
                                    txtSoyadUc.Enabled = false;
                                    txtTelUc.Enabled = false;

                                    btnUcuncuyuEkle.Enabled = false;
                                    btnIptalUc.Enabled = true;
                                    BilgilerinTamamlanmaDurumuKontrol();
                                }
                                else
                                {
                                    DialogResult dlg = MessageBox.Show("Bu kişi zaten kayıtlı bilgileri getirilsin mi ?", "Hata mesajı", MessageBoxButtons.YesNo);
                                    if (dlg == DialogResult.Yes)
                                    {
                                        Musteri olanMusteri = musteriController.GetMusteriByTc(txtTcKimlikUc.Text);
                                        if (olanMusteri != null)
                                        {
                                            txtTcKimlikUc.Text = olanMusteri.TcNo;
                                            txtAdUc.Text = olanMusteri.Ad;
                                            txtSoyadUc.Text = olanMusteri.Soyad;
                                            txtTelUc.Text = olanMusteri.Telefon;
                                            kalacakMusteriler.Add(olanMusteri);
                                            //foreach (Control item in groupBox2.Controls)
                                            //{
                                            //    if (item is TextBox)
                                            //    {
                                            //        item.Enabled = false;
                                            //    }
                                            //}
                                            txtTcKimlikUc.Enabled = false;
                                            txtAdUc.Enabled = false;
                                            txtSoyadUc.Enabled = false;
                                            txtTelUc.Enabled = false;
                                            btnUcuncuyuEkle.Enabled = false;
                                            btnIptalUc.Enabled = true;
                                            BilgilerinTamamlanmaDurumuKontrol();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Musteri bilgileri getirilmedi");
                                        }
                                    }

                                }
                            }
                            else
                            {
                                MessageBox.Show("Girilen ilk kişiyle aynı kişiyi girdiniz!");
                                txtTcKimlikUc.Text = "";
                                txtAdUc.Text = "";
                                txtSoyadUc.Text = "";
                                txtTelUc.Text = "";
                                return;
                                //foreach (Control item in groupBox2.Controls)
                                //{
                                //    if (item is TextBox)
                                //    {
                                //        item.Text = "";
                                //    }
                                //}
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen yanınızda kalacak olan kişiyi giriniz!");
                            //foreach (Control item in groupBox2.Controls)
                            //{
                            //    if (item is TextBox)
                            //    {
                            //        item.Text = "";
                            //    }
                            //}
                            txtTcKimlikUc.Text = "";
                            txtAdUc.Text = "";
                            txtSoyadUc.Text = "";
                            txtTelUc.Text = "";
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ad ve Soyad sayı içeremez!");
                    }
                }
                else
                {
                    MessageBox.Show("Doğru formatta telefon numarası girilmedi!");

                }
            }
            else
            {
                MessageBox.Show("Girilen TC. Kimlik Numarası 11 Haneli olmalıdır.İlk rakamı 0 olamaz!");


            }
        }
        private void BilgilerinTamamlanmaDurumuKontrol()
        {
            if (_rezervasyon.KisiSayisi == 1)
            {
                btnRezervasyonuTamamla.Enabled = true;
            }
            else if (_rezervasyon.KisiSayisi == 2)
            {
                if (btnIkinciyiEkle.Enabled == false)
                {
                    btnRezervasyonuTamamla.Enabled = true;

                }
                else
                {
                    btnRezervasyonuTamamla.Enabled = false;
                }
            }
            else if (_rezervasyon.KisiSayisi == 3)
            {
                if (btnIkinciyiEkle.Enabled == false && btnUcuncuyuEkle.Enabled == false)
                {
                    btnRezervasyonuTamamla.Enabled = true;

                }
                else
                {
                    btnRezervasyonuTamamla.Enabled = false;
                }
            }
        }
        private void btnIptalIki_Click(object sender, EventArgs e)
        {
            foreach (Musteri item in kalacakMusteriler.ToList())
            {
                if (item.TcNo == txtTcKimlikIki.Text)
                {
                    kalacakMusteriler.Remove(item);
                }
            }
            //foreach (Control item in groupBox1.Controls)
            //{
            //    if (item is TextBox)
            //    {
            //        item.Enabled = true;
            //        item.Text = "";
            //    }
            //}
            txtTcKimlikIki.Enabled = true;
            txtAdIki.Enabled = true;
            txtSoyadIki.Enabled = true;
            txtTelIki.Enabled = true;
            txtTcKimlikIki.Text = "";
            txtAdIki.Text = "";
            txtSoyadIki.Text = "";
            txtTelIki.Text = "";
            btnIkinciyiEkle.Enabled = true;
            btnIptalIki.Enabled = false;
            BilgilerinTamamlanmaDurumuKontrol();
        }

        private void btnIptalUc_Click(object sender, EventArgs e)
        {
            foreach (Musteri item in kalacakMusteriler.ToList())
            {
                if (item.TcNo == txtTcKimlikUc.Text)
                {
                    kalacakMusteriler.Remove(item);
                }
            }
            //foreach (Control item in groupBox2.Controls)
            //{
            //    if (item is TextBox)
            //    {
            //        item.Enabled = true;
            //        item.Text = "";
            //    }
            //}
            txtTcKimlikUc.Enabled = true;
            txtAdUc.Enabled = true;
            txtSoyadUc.Enabled = true;
            txtTelUc.Enabled = true;
            txtTcKimlikUc.Text = "";
            txtAdUc.Text = "";
            txtSoyadUc.Text = "";
            txtTelUc.Text = "";
            btnUcuncuyuEkle.Enabled = true;
            btnIptalUc.Enabled = false;
            BilgilerinTamamlanmaDurumuKontrol();
        }

        private void btnRezervasyonuTamamla_Click(object sender, EventArgs e)
        {
            foreach (Musteri item in kalacakMusteriler)
            {
                if (musteriController.IsThereMusteri(item.TcNo))
                {
                    Musteri sonEklenen = musteriController.GetMusteriByTc(item.TcNo);
                    sonEklenenMusteriler.Add(sonEklenen);
                    continue;
                }
                else
                {
                    bool musteriklendiMi = musteriController.AddYanMusteri(item);
                    if (musteriklendiMi)
                    {
                        Musteri sonEklenen = musteriController.GetMusteriByTc(item.TcNo);
                        sonEklenenMusteriler.Add(sonEklenen);
                    }
                    else
                    {
                        MessageBox.Show("mus eklenemedi!");
                        return;
                    }

                }

            }
            bool rezEklendiMi = rezervasyonController.InsertRez(_rezervasyon);
            if (!rezEklendiMi)
            {
                MessageBox.Show("rez eklenemedi!");
                return;
            }
            sonEklenenMusteriler.Add(_musteri);
            RezervasyondakiMusteri rezervasyondakiMusteri;
            foreach (Musteri item in sonEklenenMusteriler)
            {
                rezervasyondakiMusteri = new RezervasyondakiMusteri()
                {
                    RezervasyonId = rezervasyonController.LastRezId(),
                    MusteriId = item.Id

                };
                bool rzmsEklediMi = rezervasyondakiMusterilerController.InsertRezMusteri(rezervasyondakiMusteri);

            }
            if (_musteri.Mail != null)
            {
                string icerik = string.Format($"({_rezervasyon.GirisTarihi.ToShortDateString()}) Giriş tarihli ve({ _rezervasyon.CikisTarihi.ToShortDateString()}) Çıkış tarihli rezervasyonunuz tamamlanmıştır. \nRezervasyon numaranız:{rezervasyonController.LastRezId()}  \nÖdeme türü:{(rbNakit.Checked ? "Nakit" : "Kredi Kartı")} \nTutar:{_topTutar.ToString()}");
                Helper.Gonder("Bilge Adam Otel", icerik, _musteri.Mail);
            }
            Fatura fatura = new Fatura()
            {
                MusteriId = _musteri.Id,
                RezervasyonId = rezervasyonController.LastRezId(),
                ToplamTutar = _topTutar,
                NakitMi = (rbNakit.Checked ? true : false)
            };
            if (faturaController.InsertFatura(fatura))
            {
                MessageBox.Show("fatura ekleme başarılı");
            }
            else
            {
                MessageBox.Show("fatura ekleme başarısız");
            }

            frmOdaSecimi frm = new frmOdaSecimi(_musteri);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        private void txtTcKimlikIki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtAdIki_KeyPress(object sender, KeyPressEventArgs e)
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
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmOdaSecimi frm = new frmOdaSecimi(_musteri);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
