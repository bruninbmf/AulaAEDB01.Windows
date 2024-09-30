using AulaAEDB01.Windows.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace AulaAEDB01.Windows.Helper
{
    public static class DataHelper
    {
        public static List<Genero> ListaGenero { get; set; }
        public static List<Autor> ListaAutor { get; set; }
        public static SqlConnection Conexao()
        {
            //pcarthur
            string strconnection = "Data Source=ARTHUR-PC\\SQLEXPRESS;Initial Catalog=Livraria;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;";
            //pcarthur
            //pcbruno
            //string strconnection = "Data Source=BRUNO\\SQLEXPRESS02;Integrated Security=True;Initial Catalog=Libraria;Connect Timeout=30;Trust Server Certificate=True;";
            //pcbruno
            SqlConnection oCn = new SqlConnection(strconnection);
            oCn.Open();
            return oCn;
        }

    }
}
