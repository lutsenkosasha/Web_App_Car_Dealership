using System.ComponentModel.DataAnnotations;

namespace Car_Dealership.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public required string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        public int AccessLevel { get; set; }
    }
}
