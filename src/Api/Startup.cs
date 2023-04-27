using System.Reflection;
using MediatR;
using Project.Api.Helpers;
using Project.Api.Initialize.SwaggerConfigurations;
using Project.Modules.CreditHub.Application;

namespace Project.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment WebHostEnvironment { get; }

        public Startup(
            IConfiguration configuration, 
            IWebHostEnvironment env)
        {
            Configuration = configuration;
            WebHostEnvironment = env;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            AddMediatr(services);

            services.AddSwaggerConfigurations();

            services.AddMvcCore().AddApiExplorer();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Project API");
            });
        }

        public void AddMediatr(IServiceCollection services)
        {
            var credithubAssembly = Assembly.GetAssembly(typeof(CreditHubApplicationAssemblyRef));

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavoir<,>));

            services.AddMediatR(credithubAssembly);
        }
    }
}