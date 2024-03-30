using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using DentiSys.Repositories;
using DentiSys.Screens.EnderecoScreen.CRUD;

namespace DentiSys.Screens.PacienteScreen
{
    public static class TelaDeMenuDoEndereco
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("---------------- Gestão de endereço -------------------");
            Console.WriteLine();
            Console.WriteLine("O que deseja?:");
            Console.WriteLine();
            Console.WriteLine(" 1 - Cadastrar um endereco");
            Console.WriteLine();
            Console.WriteLine(" 2 - Buscar todos os enderecos");
            Console.WriteLine();
            Console.WriteLine(" 3 - Buscar um endereco específico");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Digite abaixo:");
            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    TelaDeInserirEndereco.Load();
                    break;
                case 2:
                    TelaDeObterEndereco.List();
                    break;
                case 3:
                    AbrirTelaDeOpcoesDeBusca();
                    break;
            }
        }

        static void AbrirTelaDeOpcoesDeBusca()
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
            Console.WriteLine();
            Console.WriteLine("Digite abaixo:");
            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Digite o CEP: ");
                    var cep = Console.ReadLine();
                    var enderecos = enderecoRepository.PesquisarEnderecosPorCep(cep);
                    break;
            }
        }

    }
}
