using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiPageWebAppWertz.Models
{
    public class PhoneContext : DbContext
    {
        public PhoneContext(DbContextOptions<PhoneContext> options) : base(options)
        {

        }
        public DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Phone>().HasData(
                new Phone
                {
                    PhoneId = 1,
                    Name = "Isaiah Wertz",
                    PNumber = 5157770852,
                    Address = "708 26th St SE",
                    Note = "It's me"
                },
                new Phone
                {
                    PhoneId = 2,
                    Name = "Shannon Hodges",
                    PNumber = 5158224692,
                    Address = "708 26th St SE",
                    Note = "It's my mom"
                },
                new Phone
                {
                    PhoneId = 3,
                    Name = "John Doe",
                    PNumber = 5155555555,
                    Address = "Null",
                    Note = "It's a fake"
                }
            );
        }
    }
}
