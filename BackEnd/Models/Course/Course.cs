using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models
{
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CrsId { get; set; }
        [MaxLength(50), Required]
        public string CrsTitle { get; set; }
        [MaxLength(200)]
        public string CrsDesc { get; set; }
        [ForeignKey("Instructor")]
        public int InsId { get; set; }
        [Required]
        public double Price { get; set; }
        [JsonIgnore]
        public virtual Instructor Instructor { get; set; }
        [JsonIgnore]
        public virtual ICollection<Video> Videos { get; set; }
    }
}
