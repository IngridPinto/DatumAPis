using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatumApiTaxaJuros.Model
{
    public class TaxaJuros
    {
        decimal taxaJuros;

        public decimal ValorTaxaJuros { get { return taxaJuros; } }

        public TaxaJuros()
        {
            taxaJuros = 0.01m;
        }
    }
}
