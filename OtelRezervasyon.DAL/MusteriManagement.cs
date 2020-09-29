using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyon.Entities;

namespace OtelRezervasyon.DAL
{
    public class MusteriManagement
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OtelConn"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader rdr;


        public List<Musteri> SelectAll()
        {
            List<Musteri> musteriler = new List<Musteri>();

            cmd = new SqlCommand("Select * from Musteriler", conn);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                rdr = cmd.ExecuteReader();

                Musteri musteri;
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        musteri = new Musteri()
                        {
                            Id = Convert.ToInt32(rdr["Id"]),
                            TcNo = rdr["TcKimlikNo"].ToString(),
                            Ad = rdr["MusteriAdi"].ToString(),
                            Telefon = rdr["Telefon"].ToString(),
                            Soyad = rdr["MusteriSoyadi"].ToString(),
                            Mail = rdr["Email"].ToString(),
                            Sifre = rdr["Sifre"].ToString(),



                        };
                        musteriler.Add(musteri);
                    }


                }
                return musteriler;
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

        public bool InsertMusteri(Musteri yeniMusteri)
        {
            try
            {

                cmd = new SqlCommand("insert into Musteriler (TcKimlikNo,MusteriAdi,MusteriSoyadi,Telefon,Email,Sifre)  values (@TcKimlikNo,@MusteriAdi,@MusteriSoyadi,@Telefon,@Email,@Sifre)", conn);

                cmd.Parameters.AddWithValue("@TcKimlikNo", yeniMusteri.TcNo);
                cmd.Parameters.AddWithValue("@MusteriAdi", yeniMusteri.Ad);
                cmd.Parameters.AddWithValue("@MusteriSoyadi", yeniMusteri.Soyad);
                cmd.Parameters.AddWithValue("@Telefon", yeniMusteri.Telefon);
                cmd.Parameters.AddWithValue("@Email", yeniMusteri.Mail);
                cmd.Parameters.AddWithValue("@Sifre", yeniMusteri.Sifre);


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
        public bool InsertYanMusteri(Musteri yeniMusteri)
        {
            try
            {

                cmd = new SqlCommand("insert into Musteriler (TcKimlikNo,MusteriAdi,MusteriSoyadi,Telefon)  values (@TcKimlikNo,@MusteriAdi,@MusteriSoyadi,@Telefon)", conn);

                cmd.Parameters.AddWithValue("@TcKimlikNo", yeniMusteri.TcNo);
                cmd.Parameters.AddWithValue("@MusteriAdi", yeniMusteri.Ad);
                cmd.Parameters.AddWithValue("@MusteriSoyadi", yeniMusteri.Soyad);
                cmd.Parameters.AddWithValue("@Telefon", yeniMusteri.Telefon);


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
        public bool UpdateMusteriMailSifre(Musteri yeniMusteri)
        {

            try
            {
                cmd = new SqlCommand("update musteriler set Email=@Email,Sifre=@Sifre where TcKimlikNo=@TcKimlikNo", conn);
                cmd.Parameters.AddWithValue("@TcKimlikNo", yeniMusteri.TcNo);
                cmd.Parameters.AddWithValue("@Email", yeniMusteri.Mail);
                cmd.Parameters.AddWithValue("@Sifre", yeniMusteri.Sifre);
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
