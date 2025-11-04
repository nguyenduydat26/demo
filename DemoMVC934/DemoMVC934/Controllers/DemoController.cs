using Microsoft.AspNetCore.Mvc;
using System.Text;
using DemoMVC934.Models;

namespace DemoMVC934.Controllers
{
    public class DemoController : Controller
    {
    

        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult ViewExample()
        {
            ViewData["Message"] = "Đây là ví dụ về ViewResult – trả về giao diện View.";
            return View();
        }

        public IActionResult RedirectExample()
        {
            return Redirect("https://www.google.com");
        }

        public IActionResult RedirectToActionExample()
        {
            return RedirectToAction("ViewExample");
        }

        public IActionResult JsonExample()
        {
            var student = new { Name = "Nguyen Duy Dat", Age = 22 };
            return Json(student);
        }

        public IActionResult FileExample()
        {
            var fileContent = "Đây là nội dung file text ví dụ trong FileResult.";
            var bytes = Encoding.UTF8.GetBytes(fileContent);
            return File(bytes, "text/plain", "example.txt");
        }

        public IActionResult StatusCodeExample()
        {
            return StatusCode(404, "Trang không tồn tại (Not Found)");
        }

        public IActionResult DataExample()
        {
            ViewBag.Message = "Xin chào từ ViewBag!";
            ViewData["Note"] = "Đây là ViewData truyền từ Controller sang View.";
            TempData["TempMsg"] = "Đây là TempData – tồn tại qua 1 request tiếp theo.";
            return View();
        }

        public IActionResult ShowTempData()
        {
            var temp = TempData["TempMsg"];
            return Content($"Giá trị TempData nhận được: {temp}");
        }

        [HttpGet]
        public IActionResult InputData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InputData(string name, int age)
        {
            ViewBag.Result = $"Họ tên: {name} - Tuổi: {age}";
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Student s )
        {
            if (ModelState.IsValid)
            {
                ViewBag.Info = $"Học sinh: {s.Name} ({s.Age} tuổi)";
            }
            return View(s);
        }
    }
}
