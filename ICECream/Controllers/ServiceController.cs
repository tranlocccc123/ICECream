using Microsoft.AspNetCore.Mvc;

namespace ICECream.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
