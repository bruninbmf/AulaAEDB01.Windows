using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB01.Windows.Model
{
    public class Usuario
    {
        public int id { get; set; }
        public string? Nome { get; set; }

        public static List<Usuario> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Usuario> Retorno = new List<Usuario>();
                string SQL = "select id,nome from Pessoa";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Usuario oUsuario = new Usuario();
                    oUsuario.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oUsuario.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oUsuario);
                }
                oDr.Close();
                return Retorno;
            }

        }
        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"Insert into Pessoa Values('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Usuario oUsuario)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Pessoa set Nome='{oUsuario.Nome.Replace("'", "")}' where id={oUsuario.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"delete from Pessoa where id={this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}