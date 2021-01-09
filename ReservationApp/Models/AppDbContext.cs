using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.Entity<ContactType>()
                .HasData(
                new ContactType
                {   Id = 1,
                    Name = "Default", 
                    Description = "Default type" 
                }
            );

            modelBuilder.Entity<Contact>()
                .HasData(
                new Contact
                {
                    Id = 1,
                    Name = "Default",
                    Entity = "Default",
                    ContactTypeId = 1,
                    Birthday = new DateTime(2021,1,7),
                    PhoneNumber = "+549645897"
                    
                }
            );

            modelBuilder.Entity<Reservation>()
                .HasData(
                new Reservation
                {
                    Id = 1,
                    Title = "Default",
                    ContactId = 1,
                    CreationDate = new DateTime(2021,1,7),
                    Description = "Default",
                    IsFavorite = false,
                    Rating = 3.5,
                    TargetDate = new DateTime(2021,10,1)                                


                }
            );

        }

    }
}