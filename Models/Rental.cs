using System;
using System.ComponentModel.DataAnnotations;

namespace BikeRental_MVC.Models
{
    public class Rental
    {
        [Key]
        public int id { get; set; }
        public DateTime IssueDate { get; set; }

        public Bike bike_link { get; set; }
        public Customer Customer_link { get; set; }
    }
}
