using Microsoft.AspNetCore.Mvc;
using DemoMVC934.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoMVC934.Controllers
{
    public class StudentController : Controller
    {

        public static List<Student> Students = new List<Student>();

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                // Tạo ID tự động
                s.Id = Students.Count + 1;

                // Lưu vào danh sách
                Students.Add(s);

                // Hiển thị thành công
                ViewBag.Info = $"Đã thêm học sinh: {s.Name} ({s.Age} tuổi)";
            }

            return View(s);
        }

        public IActionResult Index()
        {
            return View(Students);
        }

               public IActionResult Details(int id)
        {
            var student = Students.FirstOrDefault(x => x.Id == id);

            if (student == null)
                return NotFound("Không tìm thấy học sinh");

            return View(student);
        }
    }
}

