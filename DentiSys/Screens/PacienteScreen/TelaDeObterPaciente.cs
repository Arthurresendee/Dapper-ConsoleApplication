using DentiSys.Models;
using DentiSys.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentiSys.Screens.PacienteScreen
{
    public static class TelaDeObterPaciente
    {

        static TelaDeObterPaciente()
        {
                
        }

        public static void List()
        {
            var repository = new Repository<Paciente>(ConexaoComBanco.Connection);

            var pacientes = repository.Get();

            foreach (var item in pacientes)
            {
                Console.WriteLine($"Id: {item.Id} - {item.Nome}");
            }
        }

    }
}
