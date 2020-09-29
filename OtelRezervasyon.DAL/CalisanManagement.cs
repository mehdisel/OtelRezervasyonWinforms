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
    public class CalisanManagement
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OtelConn"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader rdr;

        public List<Calisan> SelectAll()
        {
            List<Calisan> calisanlar = new List<Calisan>();

            cmd = new SqlCommand("Select * from Calisanlar", conn);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                rdr = cmd.ExecuteReader();

                Calisan calisan;
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        calisan = new Calisan()
                        {
                            Id = Convert.ToInt32(rdr["Id"]),
                            Ad = rdr["CalisanAdi"].ToString(),
                            Soyad = rdr["CalisanSoyadi"].ToString(),
                            Mail = rdr["Mail"].ToString(),
                            Sifre = rdr["Sifre"].ToString(),
                            OtelId = Convert.ToInt32(rdr["OtelID"]),
                            AdminMi = Convert.ToBoolean(rdr["YetkiliMi"])


                        };
                        calisanlar.Add(calisan);
                    }


                }
                return calisanlar;
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

        public void DeleteProduct(int id)
        {
            cmd = new SqlCommand("delete from Calisanlar where Id=@id", conn);

            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateCalisan(Calisan calisan)
        {

            cmd = new SqlCommand("update Calisanlar set CalisanAdi=@CalisanAdi ,CalisanSoyadi=@CalisanSoyadi,Mail=@Mail,Sifre=@Sifre,OtelID=@OtelId,YetkiliMi=@YetkiliMi  where Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", calisan.Id);
            cmd.Parameters.AddWithValue("@CalisanAdi", calisan.Ad);
            cmd.Parameters.AddWithValue("@CalisanSoyadi", calisan.Soyad);
            cmd.Parameters.AddWithValue("@Mail", calisan.Mail);
            cmd.Parameters.AddWithValue("@Sifre", calisan.Sifre);
            cmd.Parameters.AddWithValue("@OtelId", calisan.OtelId);
            cmd.Parameters.AddWithValue("@YetkiliMi", calisan.AdminMi);

            conn.Open();


            cmd.ExecuteNonQuery();
            conn.Close();


        }

        public bool InsertCalisan(Calisan yeniCalisan)
        {
            try
            {

                cmd = new SqlCommand("insert into Calisanlar (CalisanAdi,CalisanSoyadi,Mail,Sifre,OtelID,YetkiliMi)  values (@CalisanAdi,@CalisanSoyadi,@Mail,@Sifre,@OtelId,@YetkiliMi)", conn);

                cmd.Parameters.AddWithValue("@CalisanAdi", yeniCalisan.Ad);
                cmd.Parameters.AddWithValue("@CalisanSoyadi", yeniCalisan.Soyad);
                cmd.Parameters.AddWithValue("@Mail", yeniCalisan.Mail);
                cmd.Parameters.AddWithValue("@Sifre", yeniCalisan.Sifre);
                cmd.Parameters.AddWithValue("@OtelId", yeniCalisan.OtelId);
                cmd.Parameters.AddWithValue("@YetkiliMi", yeniCalisan.AdminMi);

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

