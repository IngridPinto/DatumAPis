using DatumAPICalculaJuros.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DatumAPICalculaJuros.Model
{
    public class CalculaJurosModel
    {
        public decimal ValorInicial { get; set; }
        public decimal ValorFinal { get; set; }
        public int Tempo { get; set; }
        public decimal Taxa { get; set; }        
    }
}