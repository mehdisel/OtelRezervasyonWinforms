using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.Entities
{
    public class Oda
    {
        public int Id { get; set; }
        public int OtelId { get; set; }
        public int OdaNumarasi { get; set; }
        public int YatakSayisi { get; set; }
    }
}
