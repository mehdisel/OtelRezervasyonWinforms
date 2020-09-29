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
    public class FaturaManagement
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OtelConn"].ConnectionString);
        SqlCommand cmd;
        //SqlDataReader rdr;
        public bool InsertFatura(Fatura fatura)
        {

            try
            {
                cmd = new SqlCommand("insert into Faturalar(RezervasyonId,MusteriId,ToplamTutar,NakitMi) values (@RezervasyonId,@MusteriId,@ToplamTutar,@NakitMi) ", conn);
                cmd.Parameters.AddWithValue("@RezervasyonId",fatura.RezervasyonId);
                cmd.Parameters.AddWithValue("@MusteriId", fatura.MusteriId);
                cmd.Parameters.AddWithValue("@ToplamTutar", fatura.ToplamTutar);
                cmd.Parameters.AddWithValue("@NakitMi", fatura.NakitMi);
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
    }
}
