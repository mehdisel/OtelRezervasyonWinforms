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
    public class OdaManagement
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OtelConn"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader rdr;

        public List<Oda> SelectAll()
        {

            List<Oda> odalar = new List<Oda>();
            cmd = new SqlCommand("select * from odalar", conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            Oda oda;
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    oda = new Oda()
                    {
                        Id = (int)rdr["Id"],
                        OtelId= (int)rdr["OtelId"],
                        OdaNumarasi = (int)rdr["OdaNumarasi"],
                        YatakSayisi = (int)rdr["YatakSayisi"]

                    };
                    odalar.Add(oda);
                }

            }
            conn.Close();
            return odalar;
        }

    }
}
