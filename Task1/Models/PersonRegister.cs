using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class PersonRegister
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        [Required]
        [StringLength(15)]
        public string Surname { get; set; }

        [Required]
        [Email]
        public string Email { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
