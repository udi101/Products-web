﻿using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
