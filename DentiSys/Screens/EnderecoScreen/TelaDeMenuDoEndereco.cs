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
    public static class TelaDeMenuDoEndereco
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
            Console.WriteLine(" 2 - Buscar todos os enderecos");
            Console.WriteLine();
            Console.WriteLine(" 3 - Buscar enderecos específicos");
            Console.WriteLine();
            Console.WriteLine(" 4 - Voltar");
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
                    TelaDeObterEndereco.TelaDeOpcoesDeBusca();
                    break;

                case 4:
                    MenuPrincipalScreen.Load();
                    break;
                
            }
        }

        
    }
}
