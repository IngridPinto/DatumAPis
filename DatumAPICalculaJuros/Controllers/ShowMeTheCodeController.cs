using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatumAPICalculaJuros.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public string ShowMeTheCode()
        {
            //string arquivo = (@"C:\Users\ingpc\source\repos\DatumAPIs\DatumAPis\.git\config");

            //try
            //{
            //    using (StreamReader sr = new StreamReader(arquivo))
            //    {
            //        String t = sr.ReadToEnd();



            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            return "https://github.com/IngridPinto/DatumAPis.git";
        }

        [HttpGet("error")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetError()
        {
            return Problem("Erro no acesso ao Sistema. Favor entrar em contato com o Administrador.");
        }
    }
}
