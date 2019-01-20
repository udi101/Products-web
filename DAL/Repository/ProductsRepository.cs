using DAL.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;
using Common.Entities;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        public async Task<IEnumerable<Product>> GetProducts()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString))
            {
                conn.Open();
                return  await conn.QueryAsync<Product>("select * from dbo.products");
            }
        }
    }
}
