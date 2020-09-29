using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyon.DAL;
using OtelRezervasyon.DTO;
using OtelRezervasyon.Entities;

namespace OtelRezarvasyon
{
    public class MusteriController
    {
        MusteriManagement musteri = new MusteriManagement();
        MusteriManagement musteriManagement = new MusteriManagement();

        public Musteri Login(LoginModel user)
        {
            List<Musteri> musteriler = musteriManagement.SelectAll();

            foreach (Musteri item in musteriler)
            {
                if (item.Mail == user.Mail && item.Sifre == user.Sifre)
                {
                    return item;
                }
            }

            return null;
        }
        public string GetMusteriById(int musteriId)
        {
            List<Musteri> musteriler = musteriManagement.SelectAll();

            foreach (Musteri item in musteriler)
            {
                if (item.Id == musteriId)
                {
                    return item.Ad + " " + item.Soyad;
                }
            }

            return null;
        }

        public bool AddMusteri(Musteri yeniMusteri)
        {
            bool eklendiMi = musteriManagement.InsertMusteri(yeniMusteri);

            if (eklendiMi)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public bool AddYanMusteri(Musteri yeniMusteri)
        {
            bool eklendiMi = musteriManagement.InsertYanMusteri(yeniMusteri);

            if (eklendiMi)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public bool IsThereMusteri(string text)
        {
            List<Musteri> musteriler = musteriManagement.SelectAll();
            foreach (Musteri item in musteriler)
            {
                if (item.TcNo == text)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsThereEmail(string Mail)
        {
            List<Musteri> musteriler = musteriManagement.SelectAll();
            foreach (Musteri item in musteriler)
            {
                if (item.Mail == Mail)
                {
                    return true;
                }
            }
            return false;
        }
        public string GetMusteriSifre(string Mail)
        {
            List<Musteri> musteriler = musteriManagement.SelectAll();
            if (IsThereEmail(Mail))
            {
                foreach (Musteri item in musteriler)
                {
                    if (item.Mail == Mail)
                    {
                        return item.Sifre;
                    }
                }
            }

            return null;
        }
        public Musteri GetMusteriByTc(string text)
        {
            List<Musteri> musteriler = musteriManagement.SelectAll();
            foreach (Musteri item in musteriler)
            {
                if (item.TcNo.Trim() == text)
                {
                    return item;
                }
            }
            return null;
        }
        public bool UpdateMusteriMailSifre(Musteri yeniMusteri)
        {
            return musteriManagement.UpdateMusteriMailSifre(yeniMusteri);
        }
    }
}
