using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projekt1.Models;


namespace Projekt1.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }


        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Book_Author> Book_Authors { get; set; }
        public DbSet<Rental_Customer> Rental_Customers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder) // Måste säga åt entity Framework hur vi vill att denna many-tomany-ralation ska vara. 
        {
            modelBuilder.Entity<Book_Author>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });

            modelBuilder.Entity<Book_Author>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.Book_Authors)
                .HasForeignKey(ba => ba.BookId);

            modelBuilder.Entity<Book_Author>()
                .HasOne(ba => ba.Author)
                .WithMany(a => a.Book_Authors)
                .HasForeignKey(ba => ba.AuthorId);

            //Lånedatum och Returdatum (DateTime)
            modelBuilder.Entity<Rental>()
            .Property(l => l.RentalDate)
            .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Rental_Customer>()
               .HasKey(rc => new { rc.RentalId, rc.CustomerId });

            modelBuilder.Entity<Rental_Customer>()
                .HasOne(rc => rc.Rental)
                .WithMany(r => r.Rental_Customers)
                .HasForeignKey(rc => rc.RentalId);

            modelBuilder.Entity<Rental_Customer>()
                .HasOne(rc => rc.Customer)
                .WithMany(c => c.Rental_Customers)
                .HasForeignKey(rc => rc.CustomerId);

            ///////////////////////////////////////////////   Vårra rentals är en kopplingstabell
            ///modelBuilder.Entity<Rental>()
            //    .HasKey(sc => new { sc.InventoryId, sc.CustomerId });

            //modelBuilder.Entity<Rental>()
            //    .HasOne(sc => sc.Inventory)
            //    .WithMany(s => s.Rentals)
            //    .HasForeignKey(sc => sc.InventoryId);

            //modelBuilder.Entity<Rental>()
            //    .HasOne(sc => sc.Customer)
            //    .WithMany(c => c.Rentals)
            //    .HasForeignKey(sc => sc.CustomerId);
        }
    }
}
