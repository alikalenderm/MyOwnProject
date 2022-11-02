using Microsoft.AspNetCore.Mvc;

namespace MyOwnProject.WebUI.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
