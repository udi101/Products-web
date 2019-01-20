using Products.DAL.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;
using Products.Common.Entities;
using System.Threading.Tasks;
using Products.DAL.Infrastructure;

namespace Products.DAL.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        public async Task<IEnumerable<Product>> GetProducts()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString))
            {
                //return await DbExecuter.Query<Product>("select * from dbo.products");
                conn.Open();
                return await conn.QueryAsync<Product>("select * from dbo.products");
            }
        }
    }
}
