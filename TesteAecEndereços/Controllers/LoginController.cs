using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using TesteAecEnderecos.Models;

namespace TesteAecEnderecos.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(string usuarioDigitado, string senhaDigitada)
        {
            // Verifique se o nome do seu banco é esse mesmo
            string conexao = "Server=RICHARD\\SQLEXPRESS;Database=AecEnderecosDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(conexao))
            {
                string sql = "SELECT * FROM Usuarios WHERE Login = @login AND Senha = @senha";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@login", usuarioDigitado);
                cmd.Parameters.AddWithValue("@senha", senhaDigitada);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["MensagemErro"] = "Usuário ou senha inválidos!";
                    return RedirectToAction("Index");
                }
            }
        }
    }
}


