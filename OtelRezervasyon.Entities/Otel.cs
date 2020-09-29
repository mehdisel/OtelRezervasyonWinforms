using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.Entities
{
   public class Otel
    {
        public int Id { get; set; }
        public string OtelAdi { get; set; }
        public int SehirId { get; set; }
        public string Adres { get; set; }
        public int YıldızSayisi { get; set; }
        public string ResimYolu  { get; set; }
       
    }
}
