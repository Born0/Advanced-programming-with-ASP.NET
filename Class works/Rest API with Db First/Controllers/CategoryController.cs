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
    [RoutePrefix("api/categories")]
    public class CategoryController : ApiController
    {
        private CategoryRepository repository = new CategoryRepository();

        [Route(""),HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(repository.GetAll());
        }
        [Route("{id}"), HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(repository.Get(id));
        }

        [Route("" , Name ="CategoryPath"), HttpPost]
        public IHttpActionResult Create(Category category)
        {
            repository.Insert(category);
            string url = Url.Link("CategoryPath", new { id = category.CategoryId });
            return Created(url, category);
        }
        [Route("{id}"), HttpPut]
        public IHttpActionResult Edit([FromBody]Category category, [FromUri]int id)
        {
            category.CategoryId = id;
            repository.Update(category);
            return Ok(category);
        }
        [Route("{id}"),HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            repository.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
