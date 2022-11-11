using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Index = Microsoft.EntityFrameworkCore.Metadata.Internal.Index;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Required, MaxLength(50)]
        public string UserName { get; set; }
        //public UserType UserType { get; set; }

        //public void AssignRole(UserType role)
        //{
        //    UserType |= role;
        //}

        //public bool HasRole(UserType role)
        //{
        //    return (UserType & role) == role;
        //}
    }
}
