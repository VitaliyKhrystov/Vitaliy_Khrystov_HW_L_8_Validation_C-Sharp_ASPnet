using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace Task2.Models
{
    public class PersonRegister
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Ім'я")]
        public string Name { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Фамілія")]
        public string Surname { get; set; }

        [Required]
        [Email]
        public string Email { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
