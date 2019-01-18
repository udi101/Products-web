using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;

namespace BL.Main
{
    public class ProductsBL
    {
        public IEnumerable<string> GetProducts() {
            var repository = new ProductsRepository();
            return repository.GetProducts();
        }
    }
}
