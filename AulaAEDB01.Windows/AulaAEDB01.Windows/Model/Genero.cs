﻿using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
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
        public int id { get; set; }
        public string? Nome { get; set; }

        public static List<Genero> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Genero> Retorno = new List<Genero>();
                string SQL = "select id,nome from genero";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Genero gen = new Genero();
                    gen.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    gen.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(gen);
                }
                oDr.Close();
                return Retorno;
            }            
        }


        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"Insert into Genero Values('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Genero oGenero)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Genero set Nome='{oGenero.Nome.Replace("'", "")}' where id={oGenero.id}";
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
                string SQL = $"delete from Genero where id={this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //DataHekper1.ListaAutor.Remove(this);
        }
    }
}
