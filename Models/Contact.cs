using System.ComponentModel.DataAnnotations;

namespace WebTest.Models
{
    public class Contact
    {
        [Key]   
        public int TabN { get; set; }
        [Required(ErrorMessage = "Не указано ФИО!")] 
        public string FIO { get; set; }
        [Required(ErrorMessage = "Не указан внутренний номер!")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Длина номера должна быть 9 символов!")]
        public string InNmb { get; set; }
        [Required(ErrorMessage = "Не указан мобильный номер!")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Длина номера должна быть 11 символов!")]
        public string OutNmb { get; set; }
        [Required(ErrorMessage = "Поле не должно быть пустым!")]
        [StringLength(250, MinimumLength = 10, ErrorMessage = "Минимальная длина строки 10 символов!")]
        public string Adress { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Укажите дату рождения!")]
        public DateTime DateBoth { get; set; }
    }
}
