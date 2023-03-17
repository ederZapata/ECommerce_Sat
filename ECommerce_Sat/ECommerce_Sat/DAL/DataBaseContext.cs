using ECommerce_Sat.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_Sat.DAL
{
    public class DataBaseContext : DbContext
    {
        
        public DataBaseContext (DbContextOptions<DataBaseContext>options) : base(options)
        {
        }
        //mapeo la identidad para convertirla en un DBSet (tabla)
        public DbSet<Country> Countries { get; set; }//la tabla se llama en plural Countries

        //crear un indice para la tabla Countries
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }


    }
}
