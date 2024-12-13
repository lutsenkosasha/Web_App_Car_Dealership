using System.ComponentModel.DataAnnotations;

namespace Car_Dealership.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public required string Manufacturer { get; set; }

        [Required]
        public required string Model { get; set; }

        public int HorsePower { get; set; }
        public int ProductionYear { get; set; }
        public int Price { get; set; }
        public int AccessLevel { get; set; }
    }
}
