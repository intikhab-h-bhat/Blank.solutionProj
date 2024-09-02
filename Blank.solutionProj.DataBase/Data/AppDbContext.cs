using Blank.solutionProj.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace Blank.solutionProj.DataBase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Currency> Currencys { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
            new Currency() { Id = 1, Title = "INR", Description = "Indian Currency" },
            new Currency() { Id = 2, Title = "SAR", Description = "Indian Currency" },
            new Currency() { Id = 3, Title = "AUS$", Description = "Indian Currency" },
            new Currency() { Id = 4, Title = "US$", Description = "Indian Currency" }
            );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = 1, Title = "English", Description = "English" },
                new Language() { Id = 2, Title = "Urdu", Description = "Urdu" },
                new Language() { Id = 3, Title = "French", Description = "French" },
                new Language() { Id = 4, Title = "Spanish", Description = "Spanish" }

                );



        }

    }
}
