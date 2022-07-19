using API_Tutorial.Data;
using API_Tutorial.Services;
using Microsoft.EntityFrameworkCore;

namespace API_Tutorial.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IPostService, PostService>();
        }
    }
}
