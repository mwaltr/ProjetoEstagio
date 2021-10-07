using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
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
           int texto = 11;

            return View(texto);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Conteudo()
        {
            ModelDep modeldep = new ModelDep();

            List<ControllerTeste> list = new List<ControllerTeste>();
            list.Add(new ControllerTeste { Id = 1, Name = "elet" });
            list.Add(new ControllerTeste { Id = 2, Name = "elestroma" });

            var r2 = list.Where( p => p.Name == "elet").Select(p => p.Name);

            ViewData["Title"] = modeldep.ModDep();
            ViewData["List"] = r2;

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
