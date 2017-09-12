using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MadplanVbkAsp.Interfaces;
using SharedLib.Models;

namespace MadplanVbkAsp.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Food")]
    public class FoodController : Controller
    {
        private IFoodData _foodData;

        public FoodController(IFoodData foodData)
        {
            _foodData = foodData;
        }

        // GET: api/Food
        [HttpGet]
        public IEnumerable<Food> GetAll()
        {
            return _foodData.GetAll();
        }

        //// GET: api/Food/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        
        //// POST: api/Food
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}
        
        //// PUT: api/Food/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}
        
        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
