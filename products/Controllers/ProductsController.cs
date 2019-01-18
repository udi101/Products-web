using System.Collections.Generic;
using System.Web.Http;
using Common.Models;
using BL.Main;

namespace products.Controllers
{
    [RoutePrefix("Products")]
    public class ProductsController : ApiController
    {
        // GET: api/ProductsB
        [Route("")]
        [HttpGet]
        public IEnumerable<string> GetProducts()
        {
            var bl = new ProductsBL();
            return bl.GetProducts();
        }

        // GET: api/Products/5
        public Product Get(int id)
        {
            var result = new Product() { ProductId = 3 };
            return result;
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
