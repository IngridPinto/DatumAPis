using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatumApiTaxaJuros.Model
{
    public class TaxaJuros
    {
        private readonly decimal taxaJuros = 0.01m;

        public decimal ValorTaxaJuros { get { return taxaJuros; } }

    }
}
