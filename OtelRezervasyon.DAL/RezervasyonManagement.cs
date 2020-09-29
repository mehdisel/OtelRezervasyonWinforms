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
    public class RezervasyonManagement
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OtelConn"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader rdr;
        public List<Rezervasyon> SelectAll()
        {

            List<Rezervasyon> rezerzasyonlar = new List<Rezervasyon>();
            cmd = new SqlCommand("select * from rezervasyonlar", conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            Rezervasyon rezervasyon;
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    rezervasyon = new Rezervasyon()
                    {
                        Id = (int)rdr["Id"],
                        GirisTarihi=Convert.ToDateTime(rdr["GirisTarihi"]),
                        CikisTarihi=Convert.ToDateTime(rdr["CikisTarihi"]),
                        MusteriId= (int)rdr["MusteriId"],
                        KisiSayisi = (int)rdr["KisiSayisi"],
                        OtelId=(int)rdr["OtelId"],
                        OdaId= (int)rdr["OdaId"],
                        RezervasyonTipId= (int)rdr["RezervastonTipId"]

                    };
                    rezerzasyonlar.Add(rezervasyon);
                }

            }
            conn.Close();
            return rezerzasyonlar;
        }
        public void DeleteRezervasyon(int id)
        {

            cmd = new SqlCommand("delete from Rezervasyonlar where Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public bool InsertRezervasyon(Rezervasyon yeniRezervasyon)
        {
            try
            {

                cmd = new SqlCommand("insert into Rezervasyonlar(GirisTarihi,CikisTarihi,MusteriId,KisiSayisi,OtelId,OdaId,RezervastonTipId) values (@GirisTarihi,@CikisTarihi,@MusteriId,@KisiSayisi,@OtelId,@Odaid,@RezervasyonTipId)", conn);

                cmd.Parameters.AddWithValue("@GirisTarihi", yeniRezervasyon.GirisTarihi);
                cmd.Parameters.AddWithValue("@CikisTarihi", yeniRezervasyon.CikisTarihi);
                cmd.Parameters.AddWithValue("@MusteriId", yeniRezervasyon.MusteriId);
                cmd.Parameters.AddWithValue("@KisiSayisi", yeniRezervasyon.KisiSayisi);
                cmd.Parameters.AddWithValue("@OtelId", yeniRezervasyon.OtelId);
                cmd.Parameters.AddWithValue("@Odaid", yeniRezervasyon.OdaId);
                cmd.Parameters.AddWithValue("@RezervasyonTipId", yeniRezervasyon.RezervasyonTipId);

                conn.Open();


                cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public int GetLastRezId()
        {

            cmd = new SqlCommand("Select IDENT_CURRENT('Rezervasyonlar')", conn);
            conn.Open();
            int sonEklenen = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return sonEklenen;
        }
    }
}
