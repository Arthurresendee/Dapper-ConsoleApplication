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
            Console.WriteLine("---------------- Gestão de endereço -------------------\n");
            Console.WriteLine("Opções disponíveis:\n");
            Console.WriteLine(" 1 - Cadastrar endereco\n");
            Console.WriteLine(" 2 - Buscar Enderecos\n");
            Console.WriteLine(" 6 - Voltar\n\n");
            Console.WriteLine("Digite abaixo:");
            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CreateEnderecoScreen.Load();
                    break;

                case 2:
                    ReadEnderecoScreen.BuscarEnderecosScreen();
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
