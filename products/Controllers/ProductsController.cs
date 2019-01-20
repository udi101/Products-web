using System.Collections.Generic;
using System.Web.Http;
using Common.Entities;
using BL.Main;
using System.Threading.Tasks;

namespace products.Controllers
{
    [RoutePrefix("Products")]
    public class ProductsController : ApiController
    {
        // GET: api/ProductsB
        [Route("")]
        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            var bl = new ProductsBL();
            return await bl.GetProducts();
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
