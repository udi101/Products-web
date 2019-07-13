using System.Collections.Generic;
using System.Web.Http;
using Products.Common.Entities;
using Products.BL.Main;
using System.Threading.Tasks;
using System.Net.Http;

namespace products.Controllers
{
    [RoutePrefix("Products")]
    public class ProductsController : ApiController
    {
        // GET: api/ProductsB
        [Route("")]
        [HttpGet]
        public async Task<HttpResponseMessage> GetProducts()
        {
            var bl = new ProductsBL();
            return Request.CreateResponse(System.Net.HttpStatusCode.Created, await bl.GetProducts());
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
