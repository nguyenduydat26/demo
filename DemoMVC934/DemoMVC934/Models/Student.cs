using System.ComponentModel.DataAnnotations;

namespace DemoMVC934.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên.")]
        public string Name { get; set; }

        [Range(1, 150, ErrorMessage = "Tuổi không hợp lệ.")]
        public int Age { get; set; }
    }
}