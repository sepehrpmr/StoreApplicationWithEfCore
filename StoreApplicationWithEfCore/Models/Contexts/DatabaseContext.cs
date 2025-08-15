using Microsoft.EntityFrameworkCore;
using StoreApplicationWithEfCore.Models.Entiteas;

namespace StoreApplicationWithEfCore.Models.Contexts
{
    public class Databasecontext : DbContext
    {
        public Databasecontext()
        {
             
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =DESKTOP-IJPV0IO; Initial Catalog=StoreEf; Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warranty>().HasKey(p => p.ProductId);
            modelBuilder.Entity<Product>().HasOne(p => p.Warranty).WithOne(p => p.Product).HasForeignKey<Warranty>(p=>p.ProductId);

            modelBuilder.Entity<Customer>().Property(e => e.Name).HasColumnName("FullName").HasColumnType("nvarchar(50)");
        }
    }
}
