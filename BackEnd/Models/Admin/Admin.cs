using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BackEnd.Models
{
    public class Admin
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public virtual User user { get; set; }
    }
}
