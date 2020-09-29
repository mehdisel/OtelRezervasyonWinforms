using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyon.DAL;
using OtelRezervasyon.Entities;

namespace OtelRezarvasyon
{
    public class RezervasyonController
    {
        RezervasyonManagement rezervasyonManagement = new RezervasyonManagement();
        public List<Rezervasyon> GetAll()
        {
            try
            {
                return rezervasyonManagement.SelectAll();
            }
            catch (Exception)
            {

                return null;
            }
        }



        public List<int> GetFullRooms(DateTime value)
        {
            List<Rezervasyon> rezervasyonlar = GetAll(); 
            List<int> DoluOdalar = new List<int>();
            foreach (Rezervasyon item in rezervasyonlar)
            {
                if (item.GirisTarihi <= value && item.CikisTarihi >= value)
                {
                    DoluOdalar.Add(item.OdaId);
                }
            }
            return DoluOdalar;

        }
        public bool InsertRez(Rezervasyon rezervasyon)
        {
            try
            {
                rezervasyonManagement.InsertRezervasyon(rezervasyon);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool DeleteRezId(int id)
        {
            try
            {
                rezervasyonManagement.DeleteRezervasyon(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<Rezervasyon> GetRezervasyonlarByMusteriId(int musteriId)
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            try
            {
                foreach (Rezervasyon item in rezervasyonManagement.SelectAll())
                {
                    if (item.MusteriId == musteriId)
                    {
                        rezervasyonlar.Add(item);
                    }
                }
                return rezervasyonlar;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public int LastRezId()
        {
            
            try
            {
               return rezervasyonManagement.GetLastRezId();
                
            }
            catch (Exception)
            {

                return -1;
            }
        }
    }
}
