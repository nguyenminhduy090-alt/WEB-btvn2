using Microsoft.AspNetCore.Mvc;

namespace Bai2_Routing.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(int id)
        {
            ViewBag.ProductID = id;
            return View();
        }

        public IActionResult Category(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                ViewBag.Error = "Bạn chưa nhập tên danh mục!";
            }
            else
            {
                ViewBag.CategoryName = name;
            }

            return View();
        }
    }
}
