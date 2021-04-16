using DatumAPICalculaJuros.Interface;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DatumAPICalculaJuros.Service
{
    /// <summary>
    /// Classe de acesso a API DatumAPITaxaJuros
    /// </summary>
    public class DatumAPITaxaJurosService : IDatumAPITaxaJurosService
    {
        /// <summary>
        /// Retorna a taxa a partir da consulta da API DatumAPITaxaJuros.
        /// </summary>
        /// <returns></returns>
        public decimal GetTaxa()
        {
            using (HttpClient client = new())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    client.BaseAddress = new Uri(ConfiguracaoDatumSettings.BaseURL);

                    HttpResponseMessage response = client.GetAsync("/taxajuros").Result;

                    response.EnsureSuccessStatusCode();

                    string conteudo = response.Content.ReadAsStringAsync().Result;

                    dynamic taxa = JsonConvert.DeserializeObject(conteudo);

                    decimal resultado = Convert.ToDecimal(taxa.ValorTaxaJuros, CultureInfo.InvariantCulture);

                    return resultado;

                }
                catch (AggregateException ex)
                {
                    throw new Exception("DatumAPITaxaJuros recusou a conexão. Favor verificar com o Administrador. \n", ex);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}