using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CityTowerServer.BLL.Services;
using CityTowerServer.DAL.Models;
using CityTowerServer.DAL.Repository;
using CityTowerServer.DAL.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CityTowerServer.API
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
            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddApplicationInsightsTelemetry(Configuration);
            services.AddDbContext<CityTowerDBContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<INewsCategoryListService, NewsCategoryListService>();
            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddDebug();
            loggerFactory.AddConsole();
            loggerFactory.AddConsole(includeScopes: true);
            loggerFactory.AddDebug(minLevel: LogLevel.Error);
            loggerFactory.AddConsole(minLevel: LogLevel.Warning);

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseExceptionHandler("/Home/Error");

            var supportedCultures = new[]
            {
                    new CultureInfo("en-US"),
            };

            var requestLocalizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-US"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            };
            app.UseRequestLocalization(requestLocalizationOptions);

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCookiePolicy();
            app.UseMvcWithDefaultRoute();

            app.UseMvc();
        }

        private string GetCustomersAPIUrl()
        {
            var endpoint = Configuration["CustomersAPIService:Url"];
            if (string.IsNullOrEmpty(endpoint))
            {
                throw new ArgumentNullException("CustomerAPIService",
                                                "Need to specify CustomerAPIService in appsettings.json");
            }

            return endpoint;
        }

        private HttpClient CreateHttpClient()
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri(GetCustomersAPIUrl())
            };

            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "AnalyzerStatusCheck");

            return client;
        }
    }
}
