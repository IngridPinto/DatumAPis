using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DatumAPICalculaJuros.Controllers;

namespace DatumAPIs.test.Testes
{
    
    public class ShowMeTheCodeControllerTest
    {
        private ShowMeTheCodeController showMeTheCodeController = new ShowMeTheCodeController();
        
        [Fact(DisplayName = "ShowMeTheCodeTest - retorna a url do github")]
        public void ShowMeTheCodeTest()
        {
            var resultado = showMeTheCodeController.ShowMeTheCode();

            Assert.Equal("https://github.com/IngridPinto/DatumAPis.git", resultado);
        }
    }
}
