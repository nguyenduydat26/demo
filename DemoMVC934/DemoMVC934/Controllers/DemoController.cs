using Microsoft.AspNetCore.Mvc;
using System.Text;

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
    }
}
