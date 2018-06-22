using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega
{
    public class VegaDbContext : DbContext
    {
        
        public DbSet<Make> Makes { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=default.db");
        }

        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        { 
        }

        //  public DbSet<Model> Models { get; set; }
         
         //added to be able to ef add and remove
         //https://www.learnentityframeworkcore.com/configuration/fluent-api/ignore-method

    } 
}