using DentiSys.Screens.PacienteScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentiSys.Screens
{
    public static class MenuPrincipalScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("-----------------DentiSys---------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("O que deseja fazer?:");
            Console.WriteLine();
            Console.WriteLine(" 1 - Gerenciar pacientes");
            Console.WriteLine();
            Console.WriteLine(" 2 - Gerenciar endereços");
            Console.WriteLine();
            //Console.WriteLine(" 3 - Gerenciar planos");
            //Console.WriteLine();
            //Console.WriteLine(" 4 - Gerenciar Consultas");
            //Console.WriteLine();
            //Console.WriteLine(" 5 - Gerenciar dentistas");
            //Console.WriteLine();
            //Console.WriteLine(" 6 - Relatórios");
            //Console.WriteLine();
            //Console.WriteLine(" 7 - sair");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite a opção: ");
            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    TelaDeMenuDoPaciente.Load();
                    break;
                case 2:
                    EnderecoMenuScreen.Load();
                    break;
            }
        }
    }
}
