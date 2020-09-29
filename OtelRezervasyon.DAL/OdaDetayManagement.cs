using OtelRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.DAL
{
    public class OdaDetayManagement
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OtelConn"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader rdr;
        public List<OdaDetay> SelectAll()
        {

            List<OdaDetay> odalarinDetaylari = new List<OdaDetay>();
            cmd = new SqlCommand("select * from OdaDetaylari", conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            OdaDetay odaDetay;
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    odaDetay = new OdaDetay()
                    {
                        OdaId = (int)rdr["OdaId"],
                        WifiVarMi =Convert.ToBoolean(rdr["WifiVarMi"]),
                        KlimaVarMi = Convert.ToBoolean(rdr["KlimaVarMi"]),
                        TelevizyonVarMi = Convert.ToBoolean(rdr["TelevizyonVarMi"]),
                        JakuziVarMi = Convert.ToBoolean(rdr["JakuziVarMi"]),
                        SuitMi = Convert.ToBoolean(rdr["SuitMi"]),
                        ManzaraVarMi = Convert.ToBoolean(rdr["ManzaraVarMi"]),
                        OdaFiyati= (decimal)rdr["OdaFiyati"]
                    };
                    odalarinDetaylari.Add(odaDetay);
                }

            }
            conn.Close();
            return odalarinDetaylari;
        }
        public void UpdateOdaDetay(OdaDetay odaDetay)
        {
            cmd = new SqlCommand("update OdaDetaylari set WifiVarMi=@wifivarmi,KlimaVarMi=@klimavarmi,TelevizyonVarMi=@tvvarmi,JakuziVarMi=@jakuzivarmi,SuitMi=@suitmi,ManzaraVarMi=@manzaravarmi,OdaFiyati=@odafiyatlari where OdaId=@odaid", conn);
            cmd.Parameters.AddWithValue("@wifivarmi", odaDetay.WifiVarMi);
            cmd.Parameters.AddWithValue("@klimavarmi", odaDetay.KlimaVarMi);
            cmd.Parameters.AddWithValue("@tvvarmi", odaDetay.TelevizyonVarMi);
            cmd.Parameters.AddWithValue("@jakuzivarmi", odaDetay.JakuziVarMi);
            cmd.Parameters.AddWithValue("@suitmi", odaDetay.SuitMi);
            cmd.Parameters.AddWithValue("@manzaravarmi", odaDetay.ManzaraVarMi);
            cmd.Parameters.AddWithValue("@odafiyatlari", odaDetay.OdaFiyati);
            cmd.Parameters.AddWithValue("@odaid", odaDetay.OdaId);

            conn.Open();


            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
