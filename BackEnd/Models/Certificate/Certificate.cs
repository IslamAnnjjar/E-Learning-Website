using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BackEnd.Models
{
    public class Certificate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime date { get; set; }
        [ForeignKey("course")]
        public int CrsID { get; set; }
        [JsonIgnore]
        public Course course { get; set; }
        [JsonIgnore]
        public ICollection<Student> Students { get; set; }
        
    }
}
