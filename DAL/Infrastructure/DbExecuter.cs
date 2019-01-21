using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;

namespace Products.DAL.Infrastructure
{
    public static class DbExecuter
    {
        public static async Task<IEnumerable<T>> Query<T>(string sqlQuery)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString))
            {
                conn.Open();
                return await conn.QueryAsync<T>(sqlQuery);
            }
        }
    }
}
