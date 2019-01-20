using Products.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.DAL.Interfaces
{
    interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
