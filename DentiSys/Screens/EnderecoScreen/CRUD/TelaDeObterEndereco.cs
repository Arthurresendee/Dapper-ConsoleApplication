using DentiSys.Models;
using DentiSys.Repositories;
using DentiSys.Screens.PacienteScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DentiSys.Screens.EnderecoScreen.CRUD
{
    public static class TelaDeObterEndereco
    {

        static TelaDeObterEndereco()
        {

        }

        public static void List()
        {
            var repository = new RepositoryBase<Endereco>(ConexaoComBanco.Connection);

            var enderecos = repository.Get();

            foreach (var item in enderecos)
            {
                Console.WriteLine($"Id: {item.Id} - {item.CEP}");
            }
        }

        public static void TelaDeOpcoesDeBusca()
        {
            var enderecoRepository = new EnderecoRepository(ConexaoComBanco.Connection);

            Console.Clear();
            Console.WriteLine("-------------- Buscas de Enderecoss: ------------------");
            Console.WriteLine();
            Console.WriteLine("Como deseja fazer sua busca?:");
            Console.WriteLine();
            Console.WriteLine(" 1 - Buscar por CEP?");
            Console.WriteLine();
            Console.WriteLine(" 2 - Buscar por nome da rua?");
            Console.WriteLine();
            Console.WriteLine(" 3 - Buscar por estados");
            Console.WriteLine();
            Console.WriteLine(" 4 - Voltar");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Digite abaixo:");
            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    var cepDigitado = TelaPesquisaPorCEP();

                    var enderecos = enderecoRepository.PesquisarEnderecosPorCep(cepDigitado); //Fazer o tratamento de caso seja nulo

                    if (enderecos == null)
                        Console.WriteLine("Endereco não encontrado com esse CEP");

                    break;

                case 4:
                    Console.Clear();
                    TelaDeMenuDoEndereco.Load();
                    break;
            }
        }

        static string TelaPesquisaPorCEP()
        {
            Console.Clear();
            Console.WriteLine("Digite o CEP: ");
            var cep = Console.ReadLine();

            if (string.IsNullOrEmpty(cep) || cep.Length > 10)
            {
                Console.WriteLine("CEP inválido...");
                Thread.Sleep(500);
                Console.WriteLine("CEP inválido...");
                Thread.Sleep(500);
                for (int i = 3; i > 0; i--)
                {
                    Console.Clear();
                    Console.WriteLine($"Retornando ao menu de bucas em {i}");
                    Thread.Sleep(1000);
                }

                TelaDeObterEndereco.TelaDeOpcoesDeBusca();
                return "";
            }
            else return cep;
        }
    }
}
