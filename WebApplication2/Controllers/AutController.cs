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
            string[] post = new string[6] {
             Request.Form["login"] ,
             Request.Form["senha"] ,
             Request.Form["repetirsenha"] ,
             Request.Form["nome"] ,
             Request.Form["email"] ,
             Request.Form["repetiremail"]
                };
            if(  (post[1] == post[2]) && (post[4] == post[5])  )
            {
                string cs = @"server=127.0.0.1;userid=root;password=root;database=estagio";
                using var con = new MySqlConnection(cs);
                MySqlCommand query = new MySqlCommand();
                con.Open();
                query.Connection = con;
                query.CommandText = "INSERT INTO login (login , senha , email , nome ) VALUES( '"+ post[0] + "' , '"+ post[1] + "' , '"+ post[3]+ "' , '"+ post[4] +"' ) ";
                query.Prepare();
                query.ExecuteNonQuery();
                Response.Redirect("/home");

            }





            return View();

        }

        public IActionResult Registro()
        {

            return View();
        }
    }
}
