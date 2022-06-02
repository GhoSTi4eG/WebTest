using System.ComponentModel.DataAnnotations;

namespace WebTest.Models
{
    public class Roles
    {
        [Key]
        public string Name { get; set; }
        public Roles(string name) => Name = name;
    }
}
