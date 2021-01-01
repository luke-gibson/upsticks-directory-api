using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace upsticks_directory_api.Data
{
    public class DirectoryContextFactory : IDesignTimeDbContextFactory<DirectoryContext>
    {
        public DirectoryContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return new DirectoryContext(new DbContextOptionsBuilder<DirectoryContext>().Options, config);
        }
    }
}
