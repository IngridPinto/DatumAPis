using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatumAPICalculaJuros
{
    /// <summary>
    /// Classe que recupera as informações da sessão DatumAPITaxaJurosSetting do arquivo de configuração appsettings.json
    /// </summary>
    public class ConfiguracaoDatumSettings
    {
        /// <summary>
        /// Propriedade URL da DatumAPITaxaJuros
        /// </summary>
        public static string BaseURL { get; set; }

    }
}
