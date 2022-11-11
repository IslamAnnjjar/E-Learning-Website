using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class InstructorDTO
    {
        [MaxLength(50), Required]
        public string FirstName { get; set; }
        [MaxLength(50), Required]
        public string LastName { get; set; }
        [MaxLength(50), Required]
        public string UserName { get; set; }
        [MaxLength(50), Required]
        public string Password { get; set; }
    }
}
