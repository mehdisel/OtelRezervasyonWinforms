using OtelRezervasyon.DAL;
using OtelRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon
{
    public class RezervasyondakiMusterilerController
    {
        RezervasyondakiMusteriManagement rezervasyondakiMusteriManagement = new RezervasyondakiMusteriManagement();

        public bool DeleteById(int id)
        {
            try
            {
                rezervasyondakiMusteriManagement.DeleteById(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool InsertRezMusteri(RezervasyondakiMusteri rezervasyondakiMusteri)
        {
            try
            {
                rezervasyondakiMusteriManagement.InsertRezMusteriler(rezervasyondakiMusteri);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
