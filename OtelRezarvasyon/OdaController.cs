using OtelRezervasyon.DAL;
using OtelRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon
{
    public class OdaController
    {
        OdaManagement odaManagement = new OdaManagement();
        public List<Oda> GetAll()
        {
            try
            {
                return odaManagement.SelectAll();
            }
            catch (Exception)
            {

                return null;
            }
        }
        public int GetRoomCount()
        {
            List<Oda> odalar = GetAll();
            return odalar.Count;

        }

    }
}
