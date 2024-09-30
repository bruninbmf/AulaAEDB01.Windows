using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB01.Windows.Model
{
    public class Idioma
    {
        public int id { get; set; }
        public string? Nome { get; set; }

        public static List<Idioma> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Idioma> Retorno = new List<Idioma>();
                string SQL = "select id,nome from Idioma";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Idioma oIdioma = new Idioma();
                    oIdioma.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oIdioma.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oIdioma);
                }
                oDr.Close();
                return Retorno;
            }

        }
        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"Insert into Idioma Values('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Idioma oIdioma)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Idioma set Nome='{oIdioma.Nome.Replace("'", "")}' where id={oIdioma.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"delete from Idioma where id={this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}