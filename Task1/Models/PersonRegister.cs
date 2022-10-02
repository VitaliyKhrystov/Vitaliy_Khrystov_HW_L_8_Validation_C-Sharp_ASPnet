using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class PersonRegister
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Ім'я")]
#pragma warning disable CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Name { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

        [Required]
        [StringLength(15)]
        [Display(Name = "Фамілія")]
#pragma warning disable CS8618 // Non-nullable property 'Surname' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Surname { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Surname' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

        [Required]
        [Email]
#pragma warning disable CS8618 // Non-nullable property 'Email' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Email { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Email' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

        [Required]
        public DateTime Date { get; set; }
    }
}
