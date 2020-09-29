using OtelRezervasyon.DAL;
using OtelRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon
{
    public class OtelController
    {
        public string GetOtelById(int otelId)
        {
            OtelManagement otelManagement = new OtelManagement();
            List<Otel> oteller = otelManagement.SelectAll();

            foreach (Otel item in oteller)
            {
                if (item.Id == otelId)
                {
                    return item.OtelAdi;
                }
            }

            return null;
        }
    }
}
