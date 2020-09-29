using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.Entities
{
    public class RezervasyonTipi
    {
        public int Id { get; set; }
        public string TipAdi { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }
        public override string ToString()
        {
            return TipAdi;
        }
    }
}
