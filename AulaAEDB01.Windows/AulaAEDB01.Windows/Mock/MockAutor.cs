using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaAEDB01.Windows.Mock;
using AulaAEDB01.Windows.Helper;
using AulaAEDB01.Windows.Model;
using AulaAEDB01.Windows.Helper;

namespace AulaAEDB01.Windows.Mock
{
    public class MockAutor
    {
        public static void CarregaAutor()
        {
            List<Autor> oLista = new List<Autor>();

            for (int i = 1; i < 11; i++)
            {
                Autor oAutor = new Autor();
                oAutor.Codigo = i;
                oAutor.Nome = $"Autor {i}";
                oLista.Add(oAutor);
            }

            DataHelper.ListaAutor = oLista;
        }
    }
}
