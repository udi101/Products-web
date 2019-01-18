using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        public IEnumerable<string> GetProducts()
        {
            List<string> result = new List<string>() { "p1", "p2" };
            return result;
        }
    }
}
