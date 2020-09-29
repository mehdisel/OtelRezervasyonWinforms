using OtelRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.DAL
{
    public class OtelManagement
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OtelConn"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader rdr;

        public List<Otel> SelectAll()
        {
            List<Otel> oteller = new List<Otel>();

            cmd = new SqlCommand("Select * from Oteller", conn);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                rdr = cmd.ExecuteReader();

                Otel otel;
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        otel = new Otel()
                        {
                            Id = Convert.ToInt32(rdr["Id"]),
                            OtelAdi = rdr["OtelAdi"].ToString(),
                            SehirId = Convert.ToInt32(rdr["SehirId"]),
                            Adres = rdr["Adres"].ToString(),
                            YıldızSayisi = Convert.ToInt32(rdr["YildizSayisi"]),
                            ResimYolu = rdr["ResimYolu"].ToString(),

                        };
                        oteller.Add(otel);
                    }


                }
                return oteller;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                rdr.Close();
                conn.Close();
            }
        }
    }
}
