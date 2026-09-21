using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        // URL: /Home/Index
        public IActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC";
            return View();
        }

        // URL: /Home/About
        public IActionResult About()
        {
            ViewBag.StudentName = "Nguyễn Minh Duy";
            ViewBag.StudentId = "BIT240082";
            ViewBag.ClassName = "24IT4";
            ViewBag.Major = "Công nghệ thông tin";
            return View();
        }

        // URL: /Home/Contact
        public IActionResult Contact()
        {
            // Thay bằng email sinh viên thật trước khi nộp nếu giảng viên yêu cầu.
            ViewBag.Email = "BIT240082@st.cmcu.edu.vn";
            return View();
        }
    }
}
