using System.ComponentModel.DataAnnotations;

namespace WebTest.Models
{
    public class Roles
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public Roles()
        {
            Users = new List<User>();
        }
    }
}
