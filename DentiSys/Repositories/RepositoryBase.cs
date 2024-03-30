using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentiSys.Repositories
{
    public class RepositoryBase<TModel> where TModel : class
    {

        private readonly SqlConnection _connection;

        public RepositoryBase(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<TModel> Get() => _connection.GetAll<TModel>(); //ExpressionBody

        public TModel Get(int id) => _connection.Get<TModel>(id);

        public void Create(TModel tmodel) => _connection.Insert(tmodel);

        public bool Update(TModel tmodel)
        {
            if (tmodel == null)
            {
                return false;
            }
            else
            {
                _connection.Update<TModel>(tmodel);
                return true;
            }
        }

        public bool Delete(TModel tmodel)
        {
            if (tmodel == null)
            {
                return false;
            }
            else
            {
                _connection.Delete<TModel>(tmodel);
                return true;
            }
        }
    }
}
