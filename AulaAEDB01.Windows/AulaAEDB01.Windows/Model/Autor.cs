using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB01.Windows.Model
{
    public class Autor
    {
          
        private int _Codigo;

        private string _Nome;
        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public static List<Autor> ListarTodos()
        {
            // return (from p in DataHekper1.ListaAutor select p).ToList();
            using (var oCn = DataHelper.Conexao())
            {
                List<Autor> Retorno = new List<Autor>();
                string SQL = "select id, Nome from Autor";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while(oDr.Read())
                {
                    Autor oAutor = new Autor();
                    oAutor.Codigo = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oAutor.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oAutor);
                }
                oDr.Close();
                return Retorno;
            }
            //SqlConnection oCn = DataHelper.Conexao();

            //oCn.Close();
        }
        public static Autor? Seleciona(int Codigo)
        {
            var autor = DataHelper.ListaAutor.Where(x => x.Codigo == Codigo).FirstOrDefault();
            return autor;
        }

        public static void IncluirAutorStatico(Autor oAutor)
        {
           
            //Autor? oAutorSelecionado = Autor.Seleciona(oAutor.Codigo);
            //if (oAutorSelecionado != null)
            //{
            //    throw new Exception($"O Código informado está sendo usado no Autor {oAutorSelecionado.Nome}.");
            //}
            //else
            //{
            //    DataHekper1.ListaAutor.Add(oAutor);
            //}
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"Insert into Autor Values('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand( SQL, oCn );
                comando.ExecuteNonQuery();
            }
            //Autor? oAutorSelecionado = Autor.Seleciona(this.Codigo);
            //if (oAutorSelecionado != null)
            //{
            //    throw new Exception($"O Código informado está sendo usado no Autor {oAutorSelecionado.Nome}.");

            //}
            //else
            //{
            //    DataHekper1.ListaAutor.Add(this);

            //}
        }

        public static void Alterar(Autor oAutor)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Autor set Nome='{oAutor.Nome.Replace("'", "")}' where id={oAutor.Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Autor? AutorColecao = Seleciona(oAutor.Codigo);
            //if (AutorColecao == null)
            //{
            //    throw new Exception($"O Código informado não existe mais no contexto.");
            //}
            //else
            //{
            //    AutorColecao.Nome = oAutor.Nome;
            //}
        }
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"delete from Autor where id={this.Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //DataHekper1.ListaAutor.Remove(this);
        }
    }
}
    
