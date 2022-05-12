using Microsoft.AspNetCore.Mvc;
using projetao.Models;
using System.Diagnostics;

namespace projetao.Controllers
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
            
            [HttpGet]
            [HttpPost]

            carregarListaDados();
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

        public void carregarListaDados()
        {
            HomeModel objHomeModel = new HomeModel();
            ViewBag.lista = objHomeModel.GetAll();
        }
    }
}