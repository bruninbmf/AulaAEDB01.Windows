using AulaAEDB01.Windows.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return (from p in DataHekper1.ListaAutor select p).ToList();
        }
        public static Autor? Seleciona(int Codigo)
        {
            return (from p in DataHekper1.ListaAutor where p.Codigo == Codigo select p).FirstOrDefault();
        }

        public static void IncluirAutorStatico(Autor oAutor)
        {
            Autor? oAutorSelecionado = Autor.Seleciona(oAutor.Codigo);
            if (oAutorSelecionado != null)
            {
                throw new Exception($"O Código informado está sendo usado no Autor {oAutorSelecionado.Nome}.");
            }
            else
            {
                DataHekper1.ListaAutor.Add(oAutor);
            }
        }

        public void Incluir()
        {
            Autor? oAutorSelecionado = Autor.Seleciona(this.Codigo);
            if (oAutorSelecionado != null)
            {
                throw new Exception($"O Código informado está sendo usado no Autor {oAutorSelecionado.Nome}.");

            }
            else
            {
                DataHekper1.ListaAutor.Add(this);

            }
        }

        public static void Alterar(Autor oAutor)
        {
            Autor? AutorColecao = Seleciona(oAutor.Codigo);
            if (AutorColecao == null)
            {
                throw new Exception($"O Código informado não existe mais no contexto.");
            }
            else
            {
                AutorColecao.Nome = oAutor.Nome;
            }
        }
        public void Excluir()
        {
            DataHekper1.ListaAutor.Remove(this);
        }
    }
}
    
