using System.ComponentModel.DataAnnotations;

namespace WebTest.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? RoleId { get; set; }
        public Roles Role { get; set; }
    }
}
