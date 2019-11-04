using System.ComponentModel.DataAnnotations;

namespace BikeRental_MVC.Models
{
    public class Bike
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public string Maker { get; set; }
        public string RegistrationNumber { get; set; }
        public decimal RentPerDay { get; set; }

    }
}
