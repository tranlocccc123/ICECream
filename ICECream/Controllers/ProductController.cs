using Microsoft.AspNetCore.Mvc;

namespace ICECream.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
