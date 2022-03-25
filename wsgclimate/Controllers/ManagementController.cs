using Microsoft.AspNetCore.Mvc;

namespace wsgclimate.Controllers
{
    public class ManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
