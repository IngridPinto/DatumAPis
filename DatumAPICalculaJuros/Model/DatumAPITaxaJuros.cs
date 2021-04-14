using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DatumAPICalculaJuros.Model
{
    /// <summary>
    /// Classe de acesso a API DatumAPITaxaJuros
    /// </summary>
    public class DatumAPITaxaJuros
    {
        /// <summary>
        /// Retorna a taxa a partir da consulta da API DatumAPITaxaJuros.
        /// </summary>
        /// <returns></returns>
        public static decimal getTaxa()
        {
            using var client = new HttpClient();
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = client.GetAsync(ConfiguracaoDatumSettings.BaseURL).Result;

                    response.EnsureSuccessStatusCode();

                    string conteudo = response.Content.ReadAsStringAsync().Result;

                    dynamic taxa = JsonConvert.DeserializeObject(conteudo);

                    decimal resultado = Convert.ToDecimal(taxa.valorTaxaJuros, CultureInfo.InvariantCulture);

                    return resultado;

                }
                catch (AggregateException ex)
                {
                    throw new Exception("DatumAPITaxaJuros recusou a conexão. Favor verificar com o Administrador. \n", ex);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}