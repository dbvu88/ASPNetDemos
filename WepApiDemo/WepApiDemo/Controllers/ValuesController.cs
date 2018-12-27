using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WepApiDemo.Models;

namespace WepApiDemo.Controllers
{
    public class ProductController : ApiController
    {

        private List<Product> Products = Product.Products;
        // GET api/values
        public IEnumerable<Product> Get()
        {
            return Products;
        }

        // GET api/values/5
        public Product Get(int id)
        {
            return Products.FirstOrDefault(p => p.ID == id);
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]Product value)
        {
            Product.Products.Add(value);
            var response = new HttpResponseMessage(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = value.ID}));
            return response;
        }

        // PUT api/values/5
        public HttpResponseMessage Put(int id, [FromBody]Product value)
        {
            var product = Products.FirstOrDefault(p => p.ID == id);
            if (product != null)
            {
                product.Name = value.Name;
                product.Price = value.Price;
            }

            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = value.ID }));
            return response;
        }

        // DELETE api/values/5
        public HttpResponseMessage Delete(int id)
        {
            var product = Products.FirstOrDefault(p => p.ID == id);
            Product.Products.Remove(product);

            var response = new HttpResponseMessage(HttpStatusCode.NoContent);
            //response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = value.ID }));
            return response;
        }
    }
}
