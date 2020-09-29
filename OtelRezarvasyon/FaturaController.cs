using OtelRezervasyon.DAL;
using OtelRezervasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon
{
    public class FaturaController
    {
        FaturaManagement faturaManagement = new FaturaManagement();
        public bool InsertFatura(Fatura fatura)
        {
            return faturaManagement.InsertFatura(fatura);
        }
    }
}
