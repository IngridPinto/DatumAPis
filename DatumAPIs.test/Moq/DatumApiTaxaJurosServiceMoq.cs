using DatumAPICalculaJuros.Interface;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;

namespace DatumAPIs.test.Moq
{
    public class DatumApiTaxaJurosServiceMoq : IDatumAPITaxaJurosService
    {
        [Fact(DisplayName = "Mock getTaxa Moq")]
        public decimal GetTaxa()
        {
            //var datumApiTaxaJuros = new Mock<IDatumAPITaxaJurosService>();//cria objeto mock

            //datumApiTaxaJuros.Object.GetTaxa().Returns(0.01m);//efetua simulação de busca da taxa de juros na API
            //datumApiTaxaJuros.Verify(r => r.GetTaxa(), Times.Once);//confirma que método foi executado uma unica vez

            return 0.01m;
        }

    }
}
