using System.ComponentModel.DataAnnotations;

namespace DemoMVC934.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string PersonId { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Address { get; set; }
    }
}
