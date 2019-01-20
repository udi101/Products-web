using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.DAL.Repository;
using Products.Common.Entities;

namespace Products.BL.Main
{
    public class ProductsBL
    {
        public async Task<IEnumerable<Product>> GetProducts() {
            var repository = new ProductsRepository();
            return await repository.GetProducts();
        }
    }
}
