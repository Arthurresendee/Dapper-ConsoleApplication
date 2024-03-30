using Dapper;
using DentiSys.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentiSys.Repositories
{
    public class EnderecoRepository : RepositoryBase<Endereco>
    {
        private readonly SqlConnection _connection;
        public EnderecoRepository(SqlConnection connection) : base(connection)
        {
            _connection = connection;
        }

        public IEnumerable<Endereco> PesquisarEnderecosPorCep(string buscaCep)
        {
            string sql = "Select * from Endereco Where CEP = @CEP";

            var enderecos = _connection.Query<Endereco>(sql);

            foreach (var item in enderecos)
            {
                Console.WriteLine(item.Rua);
            }

            return enderecos;
        }

        public void PesquisarenderecosPorRua(string nomeRua)
        {

        }

        public void PesquisarEnderecosPorEstados(string nomeEstado)
        {

        }
    }
}
