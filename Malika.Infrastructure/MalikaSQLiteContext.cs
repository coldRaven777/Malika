using Malika.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Malika.Infrastructure
{
    public class MalikaSQLiteContext : DbContext
    {
       public MalikaSQLiteContext(DbContextOptions<MalikaSQLiteContext> options) : base(options)
        { 

        } 


        public DbSet<Settings> Settings { get; set; }
        public DbSet<User> Users { get; set; }  
        public DbSet<Person> Persons { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public DbSet<PersonPhotos> PersonPhotos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=malika.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Settings>().HasNoKey();
        }
    }
}
