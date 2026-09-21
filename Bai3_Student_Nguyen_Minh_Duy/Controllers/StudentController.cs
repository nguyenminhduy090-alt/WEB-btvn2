using Microsoft.AspNetCore.Mvc;
using Bai3_Student_Nguyen_Minh_Duy.Models;
namespace Bai3_Student_Nguyen_Minh_Duy.Controllers
{
 public class StudentController : Controller
 {
  public IActionResult Info()
  {
   ViewBag.Name = "Nguyễn Minh Duy";
   ViewData["Age"] = 20;
   Student student = new Student();
   student.Major = "CNTT";
   return View(student);
  }
 }
}