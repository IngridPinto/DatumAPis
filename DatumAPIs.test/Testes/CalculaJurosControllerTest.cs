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

        [Theory(DisplayName = "Calcula o valor final a partir do controller")]
        [InlineData("100", 5, "105.10")]
        [InlineData("150", 8, "162.43")]
        [InlineData("463.14", 8, "501.51")]
        public void CalculaJurosTest(string valorInicial, int tempo, string resultado)
        {
            decimal valorInicialDecimal = Convert.ToDecimal(valorInicial, CultureInfo.InvariantCulture);
            calculaJurosController = new CalculaJurosController(_datumApiTaxaJuros);
            decimal expected = Convert.ToDecimal(resultado, CultureInfo.InvariantCulture);
            var result = calculaJurosController.CalculaJuros(valorInicialDecimal, tempo);

            //Assert
            Assert.IsType<CalculaJurosModel>(result);
            Assert.Equal(expected, result.ValorFinal);

        }

    }
}
