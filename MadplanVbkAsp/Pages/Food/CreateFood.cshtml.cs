using AutoMapper;
using MadplanVbkAsp.Data;
using MadplanVbkAsp.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MadplanVbkAsp.Pages.Food
{
    public class CreateFoodModel : PageModel
    {
        private MongoDbContext _mongoDb;

        [BindProperty]
        public FoodDto FoodDto { get; set; }

        public CreateFoodModel(MongoDbContext mongoDb)
        {
            _mongoDb = mongoDb;

            FoodDto = new FoodDto();
        }

        public void OnGet()
        {
        }

        public ActionResult OnPostSaveFood()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var food = Mapper.Map<FoodDto, SharedLib.Models.Food>(FoodDto);

            _mongoDb.Foods.InsertOne(food);

            return RedirectToPage("./Index");
        }

        public ActionResult OnPostClearFood()
        {
            FoodDto.Clear();

            return RedirectToPage("./CreateFood");
        }
        
    }
}