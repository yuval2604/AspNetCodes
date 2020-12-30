using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RestApiCourceTurorial.Data;

namespace RestApiCourceTurorial
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

                using (var scope = host.Services.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();

                    await dbContext.Database.MigrateAsync();

                    // var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                    // if (!await roleManager.RoleExistsAsync("Admin"))
                    // {
                    //     var adminRole = new IdentityRole("Admin");
                    //     await roleManager.CreateAsync(adminRole);
                    // }
                    
                    // if (!await roleManager.RoleExistsAsync("Poster"))
                    // {
                    //     var posterRole = new IdentityRole("Poster");
                    //     await roleManager.CreateAsync(posterRole);
                    // }
                }

                await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
