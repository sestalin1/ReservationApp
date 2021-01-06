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
            
            
            
        }

    }
}