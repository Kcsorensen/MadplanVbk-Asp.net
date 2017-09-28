using MadplanVbkAsp.Data;
using MadplanVbkAsp.Extensions;
using MadplanVbkAsp.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace MadplanVbkAsp.Pages.Food
{
    public class IndexModel : PageModel
    {
        private IFoodData _foodData;

        public List<SharedLib.Models.Food> Foods { get; set; }

        public IndexModel(IFoodData foodData)
        {
            _foodData = foodData;

            Foods = foodData.GetAll();
        }

        public void OnGet()
        {

        }

        public ActionResult OnPostDeleteFood(Guid id)
        {
            _foodData.Remove(id);

            return RedirectToPage("./Index");
        }

        public ActionResult OnPostExport()
        {
            var excelHelper = new ExcelHelper();

            var stream = excelHelper.GetXlsxStream();

            return File(stream, "application/octet-stream", "ExcelDB.xlsx");
        }
    }
}