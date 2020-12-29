using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestApiCourceTurorial.Services;

namespace RestApiCourceTurorial.Installers
{
    public class DbInstaller :IInstaller
    {
      
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IPostService, PostService>();
        }
    }
}
