using Chaldal.MenuPlanner.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Chaldal.MenuPlanner.Web.Controllers
{
    [Authorize]
    public class DishController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            var model = new DishCreateViewModel();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(DishCreateViewModel vmModel, int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    vmModel.MealId = id;
                    vmModel.CreateDish();

                    return RedirectToAction("Index", "Planning");
                }
                catch
                {
                    throw;
                }
            }

            return View(vmModel);
        }
    }
}
