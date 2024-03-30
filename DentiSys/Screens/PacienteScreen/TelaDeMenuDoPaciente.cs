using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentiSys.Screens.EnderecoScreen.CRUD;

namespace DentiSys.Screens.PacienteScreen
{
    public static class TelaDeMenuDoPaciente
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de pacientes");
            Console.WriteLine();
            Console.WriteLine("O que deseja?:");
            Console.WriteLine();
            Console.WriteLine(" 1 - Cadastrar um paciente");
            Console.WriteLine();
            Console.WriteLine(" 2 - Buscar todos os pacientes");
            Console.WriteLine();
            Console.WriteLine(" 3 - Buscar um paciente específico");
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
                    TelaDeObterPaciente.List();
                    break;
            }
        }
    }
}
