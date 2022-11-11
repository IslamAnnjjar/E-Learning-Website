using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BackEnd.Models
{
    public class Feedback
    {
        public int ID { get; set; }
        public string Content { get; set; }
        [ForeignKey("Course")]
        public int CrsID { get; set; }
        [JsonIgnore]
        public virtual Course Course { get; set; }
    }
}
