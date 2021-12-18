using Dapper;
using PropertiesAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesAPI.Infrastructure.Common
{
    public class SqlClient<T> : ISqlClient<T> where T : class
    {
        #region Members
        private readonly string connectionString;
        #endregion

        public SqlClient(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public SqlClient()
        {
        }

        public IEnumerable<T> GetAllQueryString(string query, object parameters = null)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                return connection.Query<T>(query, parameters);
            }
        }


        public IEnumerable<T> GetAllQueryString(string connectionString, string query, object parameters = null)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<T>(query, parameters, commandTimeout: 900);
            }
        }

        public IEnumerable<T> ExecuteStoreProcedure(string spName, object parameters = null)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                return connection.Query<T>(spName, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
