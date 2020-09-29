using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.Entities
{
    public class Rezervasyon
    {
        public int Id { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public int MusteriId { get; set; }
        public int KisiSayisi { get; set; }
        public int OtelId { get; set; }
        public int OdaId { get; set; }
        public int RezervasyonTipId { get; set; }
    }
}
