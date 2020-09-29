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
    public class RezervasyonTipiManagement
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OtelConn"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader rdr;

        public List<RezervasyonTipi> SelectAll()
        {

            List<RezervasyonTipi> rezervasyonTipleri = new List<RezervasyonTipi>();
            cmd = new SqlCommand("select * from RezervasyonTipleri", conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            RezervasyonTipi rezervasyonTipi;
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    rezervasyonTipi = new RezervasyonTipi()
                    {
                        Id = (int)rdr["Id"],
                        TipAdi = rdr["TipAdi"].ToString(),
                        Aciklama = rdr["Aciklama"].ToString(),
                        Fiyat = (decimal)rdr["Fiyat"]

                    };
                    rezervasyonTipleri.Add(rezervasyonTipi);
                }
            }
            conn.Close();
            return rezervasyonTipleri;
        }

    }
}
