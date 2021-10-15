using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace WebApplication2.Controllers
{
   
    public class AutController : Controller
    {
        string rlogin;


        public IActionResult Login()
        {
            

            ViewData["SQLLogin"] = rlogin;

            return View();
        }

        public IActionResult Autenticacao()
        {
            String login =Request.Form["login"];
            String senha = Request.Form["senha"];
            string cs = @"server=127.0.0.1;userid=root;password=root;database=estagio";
            using var con = new MySqlConnection(cs);
            MySqlCommand query = new MySqlCommand();
            con.Open();
            query.Connection = con;
            query.CommandText = "SELECT 1 FROM Login WHERE login='"+login+"' AND senha='"+senha+"'; ";
            query.Prepare();
            ViewData["SQLLogin"] = "Login Efetuado com sucesso";
            if (query.ExecuteScalar() == null || query.ExecuteScalar() == "")
            {
                rlogin = "Erro, Senha ou Usuario invalido";
                Response.Redirect("login");
            }
            else
                
            {
                rlogin = "Login Efetuado com sucesso";
                Response.Redirect("/home");
            }

            /*
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read() )
            {
                for (int i=0; i< count ; i++)
                {
                }
            }
            */




            return View();
        }
        public IActionResult AutenticacaoRegistro()
        {


            return View();

        }

        public IActionResult Registro()
        {

            return View();
        }
    }
}
