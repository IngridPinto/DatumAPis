using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using DatumAPICalculaJuros.Interface;
using DatumAPICalculaJuros.Service;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.Swagger;

namespace DatumAPICalculaJuros
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddJsonOptions(options =>
                options.JsonSerializerOptions.PropertyNamingPolicy = null);

            services.AddScoped<IDatumAPITaxaJurosService, DatumAPITaxaJurosService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "DatumAPI Calcula Juros" , Version = "v1" });
            });           

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //Ativa o Swagger
            app.UseSwagger();

            // Ativa o Swagger UI
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "DatumAPI Calcula Juros V1");
                c.RoutePrefix = string.Empty; //configura como pagina raiz
            });


            ConfiguracaoDatumSettings options = new();

            //usar essa configura��o
            Configuration.GetSection("DatumAPITaxaJurosSettings").Bind(options);

            //Para executar o teste de integra��o, adicionar a URL manual conforme abaixo:
            ConfiguracaoDatumSettings.BaseURL = "http://localhost:57409";

        }
    }
}
