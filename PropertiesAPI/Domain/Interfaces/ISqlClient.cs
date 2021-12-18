using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesAPI.Domain.Interfaces
{
    public interface ISqlClient<T> where T : class
    {
        IEnumerable<T> GetAllQueryString(string query, object parameters = null);
        IEnumerable<T> GetAllQueryString(string connectionString, string query, object parameters = null);
        IEnumerable<T> ExecuteStoreProcedure(string spName, object parameters = null);
    }
}
