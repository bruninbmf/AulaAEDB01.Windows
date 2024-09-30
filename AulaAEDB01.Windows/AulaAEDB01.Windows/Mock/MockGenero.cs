using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaAEDB01.Windows.Mock;
using AulaAEDB01.Windows.Helper;
using AulaAEDB01.Windows.Model;

namespace AulaAEDB01.Windows.Mock
{
    public class MockGenero
    {
        public static void CarregaGenero()
        {
            List<Genero> oLista = new List<Genero>();

            for (int i = 1; i < 11; i++)
            {
                Genero oGenero = new Genero();
                oGenero.id = i;
                oGenero.Nome = $"Gênero {i}";
                oLista.Add(oGenero);
            }

            DataHelper.ListaGenero = oLista;
        }
    }
}
