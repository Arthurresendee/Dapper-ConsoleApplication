using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using DentiSys.Repositories;
using DentiSys.Screens.EnderecoScreen.CRUD;

namespace DentiSys.Screens.PacienteScreen
{
    public static class EnderecoMenuScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("---------------- Gestão de endereço -------------------");
            Console.WriteLine();
            Console.WriteLine("Opções disponíveis:");
            Console.WriteLine();
            Console.WriteLine(" 1 - Cadastrar um endereco");
            Console.WriteLine();
            Console.WriteLine(" 2 - Buscar Enderecos");
            Console.WriteLine();
            Console.WriteLine(" 6 - Voltar");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Digite abaixo:");
            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CreateEnderecoScreen.Load();
                    break;

                case 2:
                    ReadEnderecoScreen.TelaDeOpcoesDeBusca();
                    break;

                case 6:
                    MenuPrincipalScreen.Load();
                    break;

                default:
                    Load();
                    break;
            }
        }

        
    }
}
