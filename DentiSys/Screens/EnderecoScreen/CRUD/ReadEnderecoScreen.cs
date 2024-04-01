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
    public static class ReadEnderecoScreen
    {

        static ReadEnderecoScreen()
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
            Console.WriteLine("-------------- Buscas de Enderecoss: ------------------\n ");
            Console.WriteLine("Buscar por:\n ");
            Console.WriteLine(" 1 - CEP\n");
            Console.WriteLine(" 2 - Nome da rua\n");
            Console.WriteLine(" 3 - Estado\n");
            Console.WriteLine(" 4 - Todos\n");
            Console.WriteLine(" 7 - Voltar\n\n");
            Console.WriteLine("Digite abaixo:");
            var opcaoBusca = short.Parse(Console.ReadLine());

            switch (opcaoBusca)
            {
                case 1:

                    var cepDigitado = TelaPesquisarPorCEP();

                    var enderecos = enderecoRepository.PesquisarEnderecosPorCep(cepDigitado); //Fazer o tratamento de caso seja nulo

                    if (enderecos == null)
                        Console.WriteLine("Endereço não encontrado com esse CEP");
                    else
                    {
                        Console.WriteLine();
                        foreach (var item in enderecos)
                        {
                            Console.WriteLine($"Estado:{item.Estado}, Cidade: {item.Cidade}, Rua: {item.Rua}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine();

                        Console.WriteLine("Deseja fazer outra operação?\n");
                        Console.WriteLine("1 - Sim");
                        Console.WriteLine("2 - Não\n");
                        Console.WriteLine("Digite abaixo:");
                        var opcaoOperacao = short.Parse(Console.ReadLine());
                        switch (opcaoOperacao)
                        {
                            case 1:
                                Console.WriteLine("-------------------------------------------");
                                TelaDeOpcoesDeBusca();
                                break;
                            case 2:
                                break;

                            default:
                                Console.WriteLine("-------------------------------------------");
                                TelaDeOpcoesDeBusca();
                                break;
                        }
                    }
                    break;

                case 7:
                    Console.Clear();
                    EnderecoMenuScreen.Load();
                    break;
            }
        }

        static string TelaPesquisarPorCEP()
        {
            Console.Clear();
            Console.WriteLine("Digite o CEP: ");
            var cep = Console.ReadLine();

            if (string.IsNullOrEmpty(cep) || cep.Length > 10)
            {
                Console.WriteLine("CEP nulo ou inválido...");
                Thread.Sleep(500);
                Console.WriteLine("CEP nulo ou inválido...");
                Thread.Sleep(500);
                for (int i = 3; i > 0; i--)
                {
                    Console.Clear();
                    Console.WriteLine($"Retornando ao menu de buscas em {i}");
                    Thread.Sleep(1000);
                }

                TelaDeOpcoesDeBusca();
                return "";
            }
            else return cep;
        }
    }
}
