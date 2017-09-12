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
    [Route("api/Recipe")]
    public class RecipeController : Controller
    {
        private IRecipeData _recipeData;

        public RecipeController(IRecipeData recipeData)
        {
            _recipeData = recipeData;
        }

        // GET: api/Recipe
        [HttpGet]
        public IEnumerable<Recipe> GetAll()
        {
            return _recipeData.GetAll();
        }

        //// GET: api/Recipe/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        
        //// POST: api/Recipe
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}
        
        //// PUT: api/Recipe/5
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
