using System.ComponentModel.DataAnnotations;

namespace WebTest.Models
{
    public class Contact
    {
        [Key]   
        public int TabN { get; set; }
        public string FIO { get; set; }
        public string InNmb { get; set; }
        public string OutNmb { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public DateTime DateBoth { get; set; }
    }
}
