using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BikeRental_MVC.Models;

namespace BikeRental_MVC.Models
{
    public class BikeRentalDBContext : DbContext
    {
        public BikeRentalDBContext (DbContextOptions<BikeRentalDBContext> options)
            : base(options)
        {
        }

        public DbSet<BikeRental_MVC.Models.Customer> Customer { get; set; }

        public DbSet<BikeRental_MVC.Models.Bike> Bike { get; set; }

        public DbSet<BikeRental_MVC.Models.Rental> Rental { get; set; }
    }
}
