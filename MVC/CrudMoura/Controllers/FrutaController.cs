using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers
{
    public class FrutaController : Controller
    {
        private readonly ILogger<FrutaController> _logger;

       public List<Fruta> ListaDeFrutas = new List<Fruta>
       {
            new Fruta{Id = 1, Nome = "Morango", Preco = 5.99f, Quantidade = 10, Categoria = "Tropical"},
            new Fruta{Id = 2, Nome = "Abacate", Preco = 5.90f, Quantidade = 12, Categoria = "Tropical"},
            new Fruta{Id = 3, Nome = "Limao", Preco = 2.95f, Quantidade = 100, Categoria = "Citrica"},
       };
        


        public FrutaController(ILogger<FrutaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ListarFrutas()
        {
            ViewBag.sacolinha = ListaDeFrutas;
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult SalvarFruta(Fruta frutaCadastrada)
        {

            frutaCadastrada.Id = ListaDeFrutas.Max(f => f.Id) + 1;

            ListaDeFrutas.Add(frutaCadastrada);
            return RedirectToAction( nameof (ListarFrutas));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}