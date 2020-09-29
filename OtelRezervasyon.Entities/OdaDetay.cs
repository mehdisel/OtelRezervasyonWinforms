using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.Entities
{
    public class OdaDetay
    {
        public int OdaId { get; set; }
        public bool WifiVarMi { get; set; }
        public bool KlimaVarMi { get; set; }
        public bool TelevizyonVarMi { get; set; }
        public bool JakuziVarMi { get; set; }
        public bool SuitMi { get; set; }
        public bool ManzaraVarMi { get; set; }
        public decimal OdaFiyati { get; set; }
    }
}
