using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Common.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime IntroductionDate { get; set; }
        public int Price { get; set; }
        public string Url { get; set; }
        public int CategoryId { get; set; }
    }
}
