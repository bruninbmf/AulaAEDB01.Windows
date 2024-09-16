using AulaAEDB01.Windows.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB01.Windows.Model
{
    public class Genero
    {
        private int _Codigo;

        private string _Nome;
        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public static List<Genero> ListarTodos()
        {
            return (from p in DataHelper.ListaGenero select p).ToList();
        }
        public static Genero? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaGenero where p.Codigo == Codigo select p).FirstOrDefault();
        }

        public static void IncluirGeneroStatico(Genero oGenero)
        {
            Genero? oGeneroSelecionado = Genero.Seleciona(oGenero.Codigo);
            if (oGeneroSelecionado != null)
            {
                throw new Exception($"O Código informado está sendo usado no gênero{oGeneroSelecionado.Nome}.");
            }
            else
            {
                DataHelper.ListaGenero.Add(oGenero);
            }
        }

        public void Incluir()
        {
            Genero? oGeneroSelecionado = Genero.Seleciona(this.Codigo);
            if (oGeneroSelecionado != null)
            {
                throw new Exception($"O Código informado está sendo usado no gênero{oGeneroSelecionado.Nome}.");
              
            }
            else
            {
                DataHelper.ListaGenero.Add(this);
                
            }
        }

        public static void Alterar(Genero oGenero)
        {
            Genero? GeneroColecao = Seleciona(oGenero.Codigo);
            if (GeneroColecao==null)
            {
                throw new Exception($"O Código informado não existe mais no contexto.");
            }
            else
            {
                GeneroColecao.Nome = oGenero.Nome;
            }
        }
        public void Excluir()
        {
            DataHelper.ListaGenero.Remove(this);
        }
    }
}
