using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC934.Models
{
    [Table("Persons")]
    public class Person
    {
        

        [Key]
        public string? PersonId { get; set; }

        [Required]
        public string? FullName { get; set; }

        public string? Address { get; set; }
    }
}
