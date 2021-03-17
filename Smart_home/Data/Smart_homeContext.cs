using Smart_home.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Smart_home.Data
{
    public class Smart_homeContext : DbContext
    {
        public Smart_homeContext(DbContextOptions<Smart_homeContext> options)
            : base(options)
        {
        }

        public DbSet<Teploty> Teploty { get; set; }
        public DbSet<Termostat> Termostat { get; set; }

    }
}
