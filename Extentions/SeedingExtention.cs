using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API1_EX.DB;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace API1_EX.Extentions
{
    public static class SeedingExtention
    {
        public static IWebHost SeedData(this IWebHost host)
    {
        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            PersonContext context = services.GetService<PersonContext>();
 
            // now we have the DbContext. Run migrations
            // context.Database;    

            // now that the database is up to date. Let's seed
            new PersonSeeder(context).SeedData();
        }
 
        return host;
    }
    }
}