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
    public partial class frmOdaDetaylandirma : Form
    {

        OdaDetayController odaDetayController = new OdaDetayController();
        public frmOdaİslemleri anaform;

        public frmOdaDetaylandirma()
        {
            InitializeComponent();
        }
        OdaDetay _odaDetay;
        public frmOdaDetaylandirma(OdaDetay odaDetay)
        {
            _odaDetay = odaDetay;
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
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
            if (numOdaFiyati.Value<=0 || numOdaFiyati.Value >= 100000)
            {
                MessageBox.Show("Girilen değer 0'dan küçük ve 100000'den büyük olamaz");
                return;
            }
            _odaDetay.OdaId = (int)numOdaNumarasi.Value;
            _odaDetay.KlimaVarMi = cbKlima.Checked;
            _odaDetay.WifiVarMi = cbWifi.Checked;
            _odaDetay.JakuziVarMi = cbJakuzi.Checked;
            _odaDetay.ManzaraVarMi = cbManzara.Checked;
            _odaDetay.SuitMi = cbSuit.Checked;
            _odaDetay.TelevizyonVarMi = cbTv.Checked;
            _odaDetay.OdaFiyati = numOdaFiyati.Value;


            bool guncellendiMi = odaDetayController.UpdateOdaDetay(_odaDetay);
            if (guncellendiMi)
            {
                MessageBox.Show("Güncellendi");
                anaform.OdalariListele();
                this.Close();
            }
            else
            {
                MessageBox.Show("Güncellenmedi");
            }
        }

        private void frmOdaDetaylandirma_Load(object sender, EventArgs e)
        {
            numOdaNumarasi.Value = _odaDetay.OdaId;
            numOdaNumarasi.Enabled = false;
            cbKlima.Checked = _odaDetay.KlimaVarMi;
            cbWifi.Checked = _odaDetay.WifiVarMi;
            cbJakuzi.Checked = _odaDetay.JakuziVarMi;
            cbManzara.Checked = _odaDetay.ManzaraVarMi;
            cbSuit.Checked = _odaDetay.SuitMi;
            cbTv.Checked = _odaDetay.TelevizyonVarMi;
            numOdaFiyati.Value = _odaDetay.OdaFiyati;


        }
    }
}
