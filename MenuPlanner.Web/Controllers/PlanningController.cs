using System.Security.Claims;
using Autofac;
using Chaldal.MenuPlanner.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Chaldal.MenuPlanner.Web.Controllers
{
    [Authorize]
    public class PlanningController : Controller
    {
        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<PlanningIndexModel>();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            model.LoadMeal(userId);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new PlanningCreateViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PlanningCreateViewModel vmModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    vmModel.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    vmModel.CreateMeal();
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
