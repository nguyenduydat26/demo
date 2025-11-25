using Microsoft.AspNetCore.Mvc;
using System.Text;
using System;
using DemoMVC934.Models;

namespace DemoMVC934.Controllers
{
    public class DemoController : Controller
    {
       


        public IActionResult Index()
        {
            // Trả về view tổng hợp (Index.cshtml)
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
            var student = new { Name = "Nguyen Duy Dat", Age = 22, };
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

        
        // ===========================================================
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
        
      
        // ===========================================================

        // 1️⃣ Nhập tên người dùng và hiển thị lời chào
        [HttpGet]
        public IActionResult HelloUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HelloUser(string userName)
        {
            ViewBag.Message = $"Xin chào {userName}!";
            return View();
        }

        // 2️⃣ Nhập tên + năm sinh => tính tuổi
        [HttpGet]
        public IActionResult Age()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Age(string userName, int yearOfBirth)
        {
            int age = DateTime.Now.Year - yearOfBirth;
            ViewBag.Message = $"Xin chào {userName}, bạn {age} tuổi.";
            return View();
        }

        // 3️⃣ Giải phương trình bậc 2
        [HttpGet]
        public IActionResult SolveEquation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SolveEquation(double a, double b, double c)
        {
            string result;

            if (a == 0)
            {
                if (b == 0)
                    result = (c == 0) ? "Phương trình vô số nghiệm." : "Phương trình vô nghiệm.";
                else
                {
                    double x = -c / b;
                    result = $"Phương trình bậc nhất có nghiệm: x = {x:F2}";
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    result = "Phương trình vô nghiệm.";
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    result = $"Phương trình có nghiệm kép: x₁ = x₂ = {x:F2}";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    result = $"Phương trình có 2 nghiệm phân biệt: x₁ = {x1:F2}, x₂ = {x2:F2}";
                }
            }

            ViewBag.Result = result;
            return View();
        }
    }
}
