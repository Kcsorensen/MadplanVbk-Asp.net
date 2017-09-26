using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MadplanVbkAsp.Data;
using MongoDB.Driver;
using SharedLib.Models;

namespace MadplanVbkAsp.Pages.Food
{
    public class FoodInfoModel : PageModel
    {
        private MongoDbContext _mongoDb;

        [BindProperty]
        public SharedLib.Models.Food Food { get; private set; }

        public FoodInfoModel(MongoDbContext mongoDb)
        {
            _mongoDb = mongoDb;
        }

        public async Task OnGet(Guid id)
        {
            Food = await _mongoDb.Foods.Find(a => a.Id == id).FirstAsync();
        }
    }
}