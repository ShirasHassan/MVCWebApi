using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test_Neudesic.Services;

namespace Test_Neudesic.Controllers
{
    [RoutePrefix("apps")]
    public class ValuesController : ApiController
    {
        private readonly IProductService _productService;
        public ValuesController(IProductService productService)
        {
            _productService = productService;
        }

        // GET api/values
        [Route("items")]
        [HttpGet]
        public IEnumerable<KeyValuePair<int,string>> Get()
        {
           return _productService.GetItems();
        }

        // GET api/values/5
        [Route("item/{id}")]
        [HttpGet]
        public string Get(int id)
        {
            return _productService.GetItem(id);
        }

        // POST api/values
        [Route("item")]
        [HttpPost]
        public void Post([FromBody] string value)
        {
             _productService.InsertItem(value);
        }

        // PUT api/values/5
        [Route("item/{id}")]
        [HttpPut()]
        public void Put(int id, [FromBody] string value)
        {
            _productService.UpdateItem(id,value);
        }

        // DELETE api/values/5
        [Route("item/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _productService.DeleteItem(id);
        }
    }
}
