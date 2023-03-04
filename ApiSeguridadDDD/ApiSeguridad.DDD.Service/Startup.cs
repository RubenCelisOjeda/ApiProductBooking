using ApiSeguridad.DDD.Service.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace ApiSeguridad.DDD.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        #region [Properties]
        private readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins"; 
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();


            #region [IoC]
            IoCGeneral.AddRegistration(services);
            #endregion

            #region [Log]
            services.AddLogging(l =>
                {
                    l.SetMinimumLevel(LogLevel.Information);
                    l.AddNLog("Log/NLog.config");

                });
            #endregion

            #region [Cors]
            services.AddCors(options =>
                {
                    options.AddPolicy(MyAllowSpecificOrigins,
                                      builder =>
                                      {
                                          builder.AllowAnyOrigin()
                                                 .AllowAnyHeader()
                                                 .AllowAnyMethod();


                                      });
                });
            #endregion

            #region [Swagger]
            services.AddSwaggerGen(options =>
                {
                    var groupName = "v1";

                    options.SwaggerDoc(groupName, new Microsoft.OpenApi.Models.OpenApiInfo
                    {
                        Title = $"API Seguridad {groupName}",
                        Version = groupName,
                        Description = "API Seguridad",
                        Contact = new Microsoft.OpenApi.Models.OpenApiContact
                        {
                            Name = "API Seguridad",
                            Email = string.Empty,
                            Url = new System.Uri("https://foo.com/"),
                        }
                    });
                }); 
            #endregion

        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Seguridad V1");
            });

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
