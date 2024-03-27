using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;
using WebApiClientes.ModelConfig;

namespace PruebaTecnica.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Cliente>Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ClienteConfig());
            modelBuilder.Entity<Cliente>().HasData(ClienteConfig.SeedData());
        }
    }
}
