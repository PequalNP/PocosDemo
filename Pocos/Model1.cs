namespace Pocos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Place>().Property(m => m.City).IsRequired();
            modelBuilder.Entity<Place>().Property(m => m.Country).IsRequired();
            modelBuilder.Entity<Broker>().HasMany(m => m.Broker_Stock_Ex);
            modelBuilder.Entity<Stock_Exchange>().HasMany(m => m.Broker_Stock_Ex);
            modelBuilder.Entity<Broker_Stock_Ex>().HasKey(m => new { m.Broker_Id, m.Stock_Ex_Id });
            modelBuilder.Entity<Broker>().Property(m => m.FirstName).HasMaxLength(25);
            modelBuilder.Entity<Broker>().Property(m => m.LastName).HasMaxLength(25);
            modelBuilder.Entity<Place>().Property(m => m.City).HasMaxLength(25);
            modelBuilder.Entity<Place>().Property(m => m.Country).HasMaxLength(25);
        }
        
        DbSet<Broker> brokers { get; set; }
        DbSet<Broker_Stock_Ex> broker_stock_ex { get; set; }
        DbSet<Place> places { get; set;}
        DbSet<Stock_Exchange> stock_exchanges { get; set; }
    }
}
