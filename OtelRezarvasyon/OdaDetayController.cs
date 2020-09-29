using OtelRezervasyon.DAL;
using OtelRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon
{
    public class OdaDetayController
    {
        OdaDetayManagement odaDetayManagement = new OdaDetayManagement();
        public List<OdaDetay> GetAll()
        {
            try
            {
                return odaDetayManagement.SelectAll();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<int> GetWifiRooms(int selectedIndex)
        {
            List<OdaDetay> odaDetaylari = odaDetayManagement.SelectAll();
            List<int> wifiDurumunaGoreOdalar = new List<int>();
            foreach (OdaDetay item in odaDetaylari)
            {
                if (selectedIndex==0)
                {
                    if (item.WifiVarMi==false)
                    {
                        wifiDurumunaGoreOdalar.Add(item.OdaId);
                    }
                }
                else if (selectedIndex==1)
                {
                    if (item.WifiVarMi == true)
                    {
                        wifiDurumunaGoreOdalar.Add(item.OdaId);
                    }
                    
                }
                else
                {
                    wifiDurumunaGoreOdalar.Add(item.OdaId);
                }
            }
            return wifiDurumunaGoreOdalar;
        }

        public List<int> GetTelevisionRooms(int selectedIndex)
        {
            List<OdaDetay> odaDetaylari = odaDetayManagement.SelectAll();
            List<int> televizyonDurumunaGoreOdalar = new List<int>();
            foreach (OdaDetay item in odaDetaylari)
            {
                if (selectedIndex == 0)
                {
                    if (item.TelevizyonVarMi == false)
                    {
                        televizyonDurumunaGoreOdalar.Add(item.OdaId);
                    }
                }
                else if (selectedIndex == 1)
                {
                    if (item.TelevizyonVarMi == true)
                    {
                        televizyonDurumunaGoreOdalar.Add(item.OdaId);
                    }

                }
                else
                {
                    televizyonDurumunaGoreOdalar.Add(item.OdaId);
                }
            }
            return televizyonDurumunaGoreOdalar;
        }

        public decimal GetRoomPrice(int odaNumarasi)
        {
            List<OdaDetay> odaDetaylari = odaDetayManagement.SelectAll();
            foreach (OdaDetay item in odaDetaylari)
            {
                if (item.OdaId==odaNumarasi)
                {
                    return item.OdaFiyati;
                }
                
            }
            return -1;
        }

        public List<int> GetAirConditionerRooms(int selectedIndex)
        {
            List<OdaDetay> odaDetaylari = odaDetayManagement.SelectAll();
            List<int> klimaDurumunaGoreOdalar = new List<int>();
            foreach (OdaDetay item in odaDetaylari)
            {
                if (selectedIndex == 0)
                {
                    if (item.KlimaVarMi == false)
                    {
                        klimaDurumunaGoreOdalar.Add(item.OdaId);
                    }
                }
                else if (selectedIndex == 1)
                {
                    if (item.KlimaVarMi == true)
                    {
                        klimaDurumunaGoreOdalar.Add(item.OdaId);
                    }

                }
                else
                {
                    klimaDurumunaGoreOdalar.Add(item.OdaId);
                }
            }
            return klimaDurumunaGoreOdalar;
        }

        public List<int> GetJacuzziRooms(int selectedIndex)
        {
            List<OdaDetay> odaDetaylari = odaDetayManagement.SelectAll();
            List<int> jakuziDurumunaGoreOdalar = new List<int>();
            foreach (OdaDetay item in odaDetaylari)
            {
                if (selectedIndex == 0)
                {
                    if (item.JakuziVarMi == false)
                    {
                        jakuziDurumunaGoreOdalar.Add(item.OdaId);
                    }
                }
                else if (selectedIndex == 1)
                {
                    if (item.JakuziVarMi == true)
                    {
                        jakuziDurumunaGoreOdalar.Add(item.OdaId);
                    }

                }
                else
                {
                    jakuziDurumunaGoreOdalar.Add(item.OdaId);
                }
            }
            return jakuziDurumunaGoreOdalar;
        }

        public List<int> GetSuiteRooms(int selectedIndex)
        {
            List<OdaDetay> odaDetaylari = odaDetayManagement.SelectAll();
            List<int> suitOlanOdalar = new List<int>();
            foreach (OdaDetay item in odaDetaylari)
            {
                if (selectedIndex == 0)
                {
                    if (item.SuitMi == false)
                    {
                        suitOlanOdalar.Add(item.OdaId);
                    }
                }
                else if (selectedIndex == 1)
                {
                    if (item.SuitMi == true)
                    {
                        suitOlanOdalar.Add(item.OdaId);
                    }

                }
                else
                {
                    suitOlanOdalar.Add(item.OdaId);
                }
            }
            return suitOlanOdalar;
        }

        public List<int> GetScenicRooms(int selectedIndex)
        {
            List<OdaDetay> odaDetaylari = odaDetayManagement.SelectAll();
            List<int> manzaraDurumunaGoreOdalar = new List<int>();
            foreach (OdaDetay item in odaDetaylari)
            {
                if (selectedIndex == 0)
                {
                    if (item.ManzaraVarMi == false)
                    {
                        manzaraDurumunaGoreOdalar.Add(item.OdaId);
                    }
                }
                else if (selectedIndex == 1)
                {
                    if (item.ManzaraVarMi == true)
                    {
                        manzaraDurumunaGoreOdalar.Add(item.OdaId);
                    }

                }
                else
                {
                    manzaraDurumunaGoreOdalar.Add(item.OdaId);
                }
            }
            return manzaraDurumunaGoreOdalar;
        }
        public bool UpdateOdaDetay(OdaDetay odaDetay)
        {
            try
            {
                odaDetayManagement.UpdateOdaDetay(odaDetay);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public OdaDetay GetRoomProperties(int tiklananOda)
        {
            List<OdaDetay> odaDetaylari= odaDetayManagement.SelectAll();
            foreach (OdaDetay item in odaDetaylari)
            {
                if (item.OdaId==tiklananOda)
                {
                    return item;
                }

            }
            return null;
        }
    }
}
