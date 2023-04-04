// Os controllers são usados para definir as ações nas páginas. 
// Este controller foi criado para definir a ação de abrir a página Home, que vai retornar uma View (página)


using GamingShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GamingShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}