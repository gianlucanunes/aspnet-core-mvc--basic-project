using Microsoft.AspNetCore.Mvc;

namespace GamingShop.Controllers
{
    public class ResumoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
