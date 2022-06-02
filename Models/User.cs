using System.ComponentModel.DataAnnotations;

namespace WebTest.Models
{
    public class Users
    {
        [Key]//ключ
        public string Name { get; set; }
        public Roles Role { get; set; }
    }
}
