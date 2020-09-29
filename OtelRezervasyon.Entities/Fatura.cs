using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.Entities
{
    public class Fatura
    {
        public int Id { get; set; }
        public int RezervasyonId { get; set; }
        public int MusteriId { get; set; }
        public decimal ToplamTutar { get; set; }
        public bool NakitMi { get; set; }
    }
}
