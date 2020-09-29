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
    public partial class frmOdaİslemleri : Form
    {
        OdaController odaController = new OdaController();
        OtelController otelController = new OtelController();
        OdaDetayController odaDetayController = new OdaDetayController();
        List<OdaDetay> odaDetaylari;
        ListViewItem lvi;

        public frmOdaİslemleri()
        {
            InitializeComponent();
        }

        public void OdalariListele()
        {

            lstOdalar.Items.Clear();
            odaDetaylari = odaDetayController.GetAll();

            if (odaDetaylari != null)

            {

                foreach (OdaDetay item in odaDetaylari)
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.OdaId.ToString();
                    lvi.SubItems.Add(item.WifiVarMi ? "Var" : "Yok");
                    lvi.SubItems.Add(item.KlimaVarMi ? "Var" : "Yok");
                    lvi.SubItems.Add(item.TelevizyonVarMi ? "Var" : "Yok");
                    lvi.SubItems.Add(item.JakuziVarMi ? "Var" : "Yok");
                    lvi.SubItems.Add(item.SuitMi ? "Evet" : "Değil");
                    lvi.SubItems.Add(item.ManzaraVarMi ? "Var" : "Yok");
                    lvi.SubItems.Add(item.OdaFiyati.ToString());
                    lstOdalar.Items.Add(lvi);
                }
            }

        }

        private void frmOdaİslemleri_Load(object sender, EventArgs e)
        {

            OdalariListele();
        }

        int index = 0;
        private void lstOdalar_DoubleClick(object sender, EventArgs e)
        {

            lvi = lstOdalar.SelectedItems[0] as ListViewItem;
            index = lvi.Index;

            frmOdaDetaylandirma frmOdaDetaylandirma = new frmOdaDetaylandirma(odaDetaylari[index]);
            frmOdaDetaylandirma.anaform = this;
            frmOdaDetaylandirma.ShowDialog();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

