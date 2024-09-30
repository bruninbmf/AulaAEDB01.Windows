using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB01.Windows.Model
{
    public class Livro
    {
        public int id { get; set; }
        public string? Nome { get; set; }

        public static List<Livro> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Livro> Retorno = new List<Livro>();
                string SQL = "select id,nome from Livro";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Livro oLivro = new Livro();
                    oLivro.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oLivro.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oLivro);
                }
                oDr.Close();
                return Retorno;
            }

        }
        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"Insert into Livro Values('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Livro oLivro)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Livro set Nome='{oLivro.Nome.Replace("'", "")}' where id={oLivro.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"delete from Livro where id={this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}