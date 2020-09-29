using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyon.DAL;
using OtelRezervasyon.Entities;

namespace OtelRezarvasyon
{
    public class CalisanController
    {
        CalisanManagement calisanManagement = new CalisanManagement();

        public List<Calisan> GetAll()
        {
            return calisanManagement.SelectAll();
        }

  

        public bool AddCalisan(Calisan yeniCalisan)
        {
            return calisanManagement.InsertCalisan(yeniCalisan);

        }

        public string GetCalisanSifre(string Mail)
        {
            List<Calisan> calisanlar = calisanManagement.SelectAll();
            if (IsThereEmail(Mail))
            {
                foreach (Calisan item in calisanlar)
                {
                    if (item.Mail == Mail)
                    {
                        return item.Sifre;
                    }
                }
            }

            return null;
        }
        public Calisan Login(OtelRezervasyon.DTO.LoginModel user)
        {
            List<Calisan> calisanlar = calisanManagement.SelectAll();

            foreach (Calisan item in calisanlar)
            {
                if (item.Mail == user.Mail && item.Sifre == user.Sifre)
                {
                    return item;
                }
            }

            return null;
        }

        public bool IsThereEmail(string Mail)
        {
            List<Calisan> calisanlar = calisanManagement.SelectAll();
            foreach (Calisan item in calisanlar)
            {
                if (item.Mail == Mail)
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdateCalisan(Calisan calisan)
        {
            try
            {
                calisanManagement.UpdateCalisan(calisan);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteCalisanId(int id)
        {
            try
            {
                calisanManagement.DeleteProduct(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

