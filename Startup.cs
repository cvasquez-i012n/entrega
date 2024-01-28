using System.Net;
using Kalumproject.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Kalumproject
{
    public class Startup
    {
        private readonly IConfiguration Configurations;

        public Startup(IConfiguration _Configurations)
        {
            this.Configurations = _Configurations;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<KalumprojectContext>(options => {
#pragma warning disable CS8602
                options.UseSqlServer(this.Configurations.GetConnectionString("KalumprojectConnection"));
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            });

            

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseDeveloperExceptionPage();
            }
            //app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors();
            app.UseAuthentication();
            app.UseEndpoints(EndPoints =>{
                EndPoints.MapControllers();
            });

            
        }
    }
}