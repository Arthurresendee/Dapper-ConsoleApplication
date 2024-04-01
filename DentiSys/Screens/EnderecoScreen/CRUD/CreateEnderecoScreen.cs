using Dapper.Contrib.Extensions;
using DentiSys.Models;
using DentiSys.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentiSys.Screens.EnderecoScreen.CRUD
{
    internal class CreateEnderecoScreen
    {
        public static void Load()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-----------Inserção de um endereco----------");
            Console.WriteLine();
            Console.Write("CEP:");
            string cep = Console.ReadLine()!;

            Console.Write("Pais:");
            string pais = Console.ReadLine()!;

            Console.Write("Rua:");
            string rua = Console.ReadLine()!;

            Console.WriteLine();
            var novoEndereco = new Endereco()
            {
                CEP = cep,
                Pais = pais,
                Rua = rua
            };

            InserirEndereco(novoEndereco);
        }

        private static void InserirEndereco(Endereco endereco)
        {
            try
            {
                var repository = new RepositoryBase<Endereco>(ConexaoComBanco.Connection);

                repository.Create(endereco);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw;
            }
        }
    }
}
