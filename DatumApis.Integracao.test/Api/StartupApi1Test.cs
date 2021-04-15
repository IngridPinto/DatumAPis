//using System;
//using System.Collections.Generic;
//using System.Text;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Hosting;
//using DatumApiTaxaJuros.Interface;
//using DatumApiTaxaJuros.Model;

//namespace DatumApis.Integracao.test.Api
//{
//    public class StartupApi1Test
//    {
//        public StartupApi1Test(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }

//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddTransient<ITaxaJuros, TaxaJuros>();
//            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
//        }
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            app.UseMvc();
//        }

//    }
//}
