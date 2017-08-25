using MadplanVbkAsp.Interface;
using Microsoft.AspNetCore.Mvc;
using SharedLib.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MadplanVbkAsp.Controllers
{
    [Route("api/[controller]")]
    public class FoodController : Controller
    {
        private IFoodData _foodData;

        public FoodController(IFoodData foodData)
        {
            _foodData = foodData;
        }

        // GET: api/values
        [HttpGet]
        public List<Food> GetAll()
        {
            return _foodData.GetAll().ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
