using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    //Acao padrao inicial 
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MinhaAcao()
    {
        return View();
    }

    public IActionResult ListaNomes()
    {
        string[] nomes = {"Eduardo", "Maria", "Joao", "Kaua"};
        ViewBag.nomes = nomes;
        ViewBag.Teste = "Ola, eu vim da Viewbag";
         return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
