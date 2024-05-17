using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySubject.Infrastructure.DBConection
{
     class ApplicationDBContextFactory : IDesignTimeDbContextFactory<ApplicationDBContext>
    {
        public ApplicationDBContext CreateDbContext(string[] args)
        {
            // Adjust the path to the root of your solution where appsettings.json is located
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "../UniversitySubject.Presentation");
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();

            var connectionString = configuration.GetConnectionString("LocalDb");

            optionsBuilder.UseSqlServer(connectionString);

            return new ApplicationDBContext(optionsBuilder.Options);
        }
    }
}

