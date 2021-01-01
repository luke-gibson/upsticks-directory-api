using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using upsticks_directory_api.Data.Entities;

namespace upsticks_directory_api.Data
{
    public class DirectoryContext : DbContext
    {
        private readonly IConfiguration _config;

        public DirectoryContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        public DbSet<EstateAgent> EstateAgent { get; set; }
        public DbSet<Conveyancer> Conveyancer { get; set; }
        public DbSet<Removals> Removals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("UpsticksDirectory"));
        }
    }
}
