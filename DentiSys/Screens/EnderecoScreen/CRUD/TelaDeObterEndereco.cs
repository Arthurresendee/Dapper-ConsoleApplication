using DentiSys.Models;
using DentiSys.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
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



    }
}
