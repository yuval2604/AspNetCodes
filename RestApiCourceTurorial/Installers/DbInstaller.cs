using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestApiCourceTurorial.Data;
using RestApiCourceTurorial.Services;

namespace RestApiCourceTurorial.Installers
{
    public class DbInstaller :IInstaller
    {
      
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
           
            services.AddDbContext<DataContext>(opt =>
           {
               opt.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
           });

           
    
       services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<DataContext>();

            services.AddScoped<IPostService, PostService>();
        }
    }
}
