using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        { 
        }
        public DbSet<Make> Makes { get; set; }
         
         //added to be able to ef add and remove
         //https://www.learnentityframeworkcore.com/configuration/fluent-api/ignore-method
         protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<Make>();
    }
    } 
}