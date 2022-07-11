using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace API_Tutorial.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "API Tutorial", Version = "v1" });
            });
        }
    }
}
