// Os controllers são usados para definir as ações nas páginas. 
// Este controller foi criado para definir a ação de abrir a página Sistema, que vai retornar uma View (página)

using GamingShop.Data;
using GamingShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamingShop.Controllers
{
    public class SistemaController : Controller
    {

        // Criando um readonly para ajudar na conexão
        readonly private ApplicationDbContext _db;

        // Criando a conexão com o banco de dados usando um construtor
        public SistemaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            // Dizendo qual tabela que devemos entrar para buscar as informações
            IEnumerable<VideogamesModel> videogames = _db.Videogames;
            
            // Passando para a view todos os videogames
            return View(videogames);
        }
    }
}
