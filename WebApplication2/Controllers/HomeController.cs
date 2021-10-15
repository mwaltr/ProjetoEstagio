using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebApplication2.Models;
using MySql.Data.MySqlClient;

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
           

            return View();
        }
        public IActionResult Formulario()
        {
            string cs = @"server=127.0.0.1;userid=root;password=root;database=teste";
            using var con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand query= new MySqlCommand();
            query.Connection = con;
            query.CommandText = "INSERT INTO tabela1 (id , col) VALUES(3,10);";
            query.Prepare();
            query.ExecuteNonQuery();
            query.CommandText = "SELECT * FROM tabela1;";
            query.Prepare();
            

            ViewData["mysql"] = query.ExecuteNonQuery();



            ViewData["Formulario"] = Request.Form["Email"];

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Conteudo()
        {
          
            return View();
        }

        public IActionResult Login()
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
