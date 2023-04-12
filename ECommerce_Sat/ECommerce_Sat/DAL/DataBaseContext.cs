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
        public DbSet<Category> Categories { get; set; }//la tabla se llama en plural Categories
        public DbSet<Category> States { get; set; }//la tabla se llama en plural states

        //crear un indice para la tabla Countries
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("Name","CountryId").IsUnique();//para estos casos creo un indice compuesto
        }


    }
}
