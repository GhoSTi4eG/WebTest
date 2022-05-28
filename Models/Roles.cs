using System.ComponentModel.DataAnnotations;

namespace WebTest.Models
{
    public class Roles
    {
        [Key]
        public int id { get; set; }
        public Boolean Role { get; set; }
    }
}
