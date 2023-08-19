using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TuiFly.FlySearchApi.Api.Common.Middlewares;
using TuiFly.FlySearchApi.Api.Controllers.Fligths.Validations;
using TuiFly.FlySearchApi.Api.Extensions;
using TuiFly.FlySearchApi.Domain.Common.configuration;

namespace TuiFly.FlySearchApi.Api
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
            services.AddControllers();
            services.AddTuiflySwaggerGen();
            services.AddValidatorsFromAssemblyContaining<FlightRequestValidator>();
            services.AddFluentValidationAutoValidation();
            //D.I
            services.AddAppServices();

            services.Configure<CacheConfiguration>(Configuration.GetSection(nameof(CacheConfiguration)));
            var optimization = Configuration.GetSection(nameof(CacheConfiguration)).Get<CacheConfiguration>();
            services.AddMemoryCache(options =>
            {
                options.CompactionPercentage = optimization?.CompactionPercentage ?? 0;
                options.SizeLimit = optimization?.SizeLimit ?? 0;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseServerErrorHandler();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
