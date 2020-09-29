using OtelRezervasyon.DAL;
using OtelRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon
{
    public class RezervasyonTipiController
    {
        RezervasyonTipiManagement rezervasyonTipiManagement = new RezervasyonTipiManagement();
        public List<RezervasyonTipi> GetAll()
        {
            try
            {
                return rezervasyonTipiManagement.SelectAll();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public RezervasyonTipi GetRezervasyonTipiById(int RezervasyonTipId)
        {
            foreach (RezervasyonTipi item in rezervasyonTipiManagement.SelectAll())
            {
                if (item.Id == RezervasyonTipId)
                {
                    return item;
                }
            }
            return null;

        }
    }
}
