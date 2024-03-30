using Dapper.Contrib.Extensions;
using DentiSys.Models;
using DentiSys.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentiSys.Screens.PacienteScreen
{
    internal class TelaDeInserirPaciente
    {
        public static void Load()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-----------Inserção de um Paciente----------");
            Console.WriteLine();
            Console.Write("Nome:");
            string nome = Console.ReadLine()!;

            Console.Write("SobreNome:");
            string sobreNome = Console.ReadLine()!;

            Console.Write("Idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Id Endereco:");
            var idEndereco = int.Parse(Console.ReadLine());

            Console.WriteLine();
            var novoPaciente = new Paciente()
            {
                Nome = nome,
                SobreNome = sobreNome,
                Idade = idade
            };

            InserirPaciente(novoPaciente, idEndereco);
        }

        public static void VerificarEndereco(int idEndereco)
        {

        }

        private static void InserirPaciente(Paciente paciente, int idEndereco)
        {
            try
            {
                paciente.IdEndereco = idEndereco;
                var repository = new RepositoryBase<Paciente>(ConexaoComBanco.Connection);

                repository.Create(paciente);
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
