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
    public class RezervasyondakiMusteriManagement
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OtelConn"].ConnectionString);
        SqlCommand cmd;
        //SqlDataReader rdr;
        public bool InsertRezMusteriler(RezervasyondakiMusteri yeniMusteri) 
        {
            try
            {

                cmd = new SqlCommand("insert into RezervasyondakiMusteriler(RezervasyonId,MusteriId) values (@RezervasyonId,@MusteriId)", conn);

                cmd.Parameters.AddWithValue("@RezervasyonId", yeniMusteri.RezervasyonId);
                cmd.Parameters.AddWithValue("@MusteriId", yeniMusteri.MusteriId);

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
        public void DeleteById(int id)
        {
            cmd = new SqlCommand("delete from RezervasyondakiMusteriler where RezervasyonId=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
