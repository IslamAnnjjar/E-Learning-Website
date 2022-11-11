using BackEnd.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BackEnd.Models
{
    public class Video
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        [ForeignKey("Course")]
        public int CrsId { get; set; }
        [JsonIgnore]
        public virtual Course Course { get; set; }
    }
}
