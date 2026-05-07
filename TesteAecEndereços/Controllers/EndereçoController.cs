using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using TesteAecEnderecos.Models;

namespace TesteAecEnderecos.Controllers
{
    public class EnderecoController : Controller
    {

        string conexao = "Server=RICHARD\\SQLEXPRESS;Database=AecEnderecosDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public IActionResult Index()
        {
            List<Endereco> lista = new List<Endereco>();
            using (SqlConnection con = new SqlConnection(conexao))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Enderecos", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lista.Add(new Endereco
                    {
                        Id = (int)rdr["Id"],
                        Cep = rdr["Cep"].ToString(),
                        Logradouro = rdr["Logradouro"].ToString(),
                        Cidade = rdr["Cidade"].ToString()
                    });
                }
            }
            return View(lista);
        }

        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Salvar(Endereco e)
        {
            using (SqlConnection con = new SqlConnection(conexao))
            {
                string sql = "INSERT INTO Enderecos (Cep, Logradouro, Cidade, UsuarioId) VALUES (@cep, @log, @cid, 1)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cep", e.Cep ?? "");
                cmd.Parameters.AddWithValue("@log", e.Logradouro ?? "");
                cmd.Parameters.AddWithValue("@cid", e.Cidade ?? "");

                con.Open();
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Excluir(int id)
        {
            using (SqlConnection con = new SqlConnection(conexao))
            {
                string sql = "DELETE FROM Enderecos WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }
    }
} 