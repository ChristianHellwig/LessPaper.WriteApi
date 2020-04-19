using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LessPaper.Shared.Interfaces.Bucket;
using LessPaper.Shared.Interfaces.GuardApi;
using LessPaper.Shared.Interfaces.Queuing;
using LessPaper.Shared.MinIO.Interfaces;
using LessPaper.Shared.MinIO.Models;
using LessPaper.Shared.Queueing.Interfaces.RabbitMq;
using LessPaper.Shared.Queueing.Models.RabbitMq;
using LessPaper.WriteService.Models;
using LessPaper.WriteService.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LessPaper.WriteService
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
            services.AddOptions();
            services.Configure<AppSettings>(Configuration.GetSection("CustomSettings"));

            services.AddScoped<IMinioSettings, Models.MinioSettings>();
            services.AddScoped<IWriteableBucket, MinioBucket>();
            services.AddScoped<IGuardApi, GuardApi>();

            services.AddScoped<IRabbitMqSettings, Models.RabbitMqSettings>();
            services.AddScoped<IQueueBuilder, RabbitMqBuilder> ();
            
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
