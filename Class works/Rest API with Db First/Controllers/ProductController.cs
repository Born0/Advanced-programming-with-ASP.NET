using Rest_API_with_Db_First.Models;
using Rest_API_with_Db_First.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rest_API_with_Db_First.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductController : ApiController
    {
        private ProductRepository repository = new ProductRepository();
        [Route(""), HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(repository.GetAll());
        }
        [Route("{id}"), HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(repository.Get(id));
        }

        [Route("", Name = "ProductPath"), HttpPost]
        public IHttpActionResult Create(Product product)
        {
            repository.Insert(product);
            string url = Url.Link("ProductPath", new { id = product.CategoryId });
            return Created(url, product);
        }
        [Route("{id}"), HttpPut]
        public IHttpActionResult Edit([FromBody] Product product, [FromUri] int id)
        {
            product.CategoryId = id;
            repository.Update(product);
            return Ok(product);
        }
        [Route("{id}"), HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            repository.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
