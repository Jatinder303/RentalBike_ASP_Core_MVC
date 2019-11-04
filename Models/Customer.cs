using System.ComponentModel.DataAnnotations;

namespace BikeRental_MVC.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string LicenseNo { get; set; }

    }
}
