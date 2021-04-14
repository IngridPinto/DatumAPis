using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DatumAPICalculaJuros.Controllers;
using DatumAPICalculaJuros.Model;
using DatumAPIs.test.Moq;
using System.Globalization;
using DatumAPICalculaJuros.Interface;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DatumAPIs.test.Testes
{    
    public class CalculaJurosControllerTest
    {
        private readonly IDatumAPITaxaJurosService _datumApiTaxaJuros = new DatumApiTaxaJurosServiceMoq();

        CalculaJurosController calculaJurosController;

        [Theory(DisplayName = "Calcula o valor final")]
        [InlineData(100, 5, "105.10")]
        public void CalculaJurosTest(decimal valorInicial, int tempo, string resultado)
        {
            calculaJurosController = new CalculaJurosController(_datumApiTaxaJuros);
            decimal expected = Convert.ToDecimal(resultado, CultureInfo.InvariantCulture);              
            var result = calculaJurosController.CalculaJuros(valorInicial, tempo);

            //Assert
            Assert.IsType<CalculaJurosModel>(result);
            Assert.Equal(expected, result.ValorFinal);

        }

    }
}
