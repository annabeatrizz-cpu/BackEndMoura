using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Controllers
{
  
    public class Teste : Controller
    {
        private readonly ILogger<Teste> _logger;

        public Teste(ILogger<Teste> logger)
        {
            _logger = logger;
        }

        public IActionResult Listar()
        {
            return View();
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Excluir()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}