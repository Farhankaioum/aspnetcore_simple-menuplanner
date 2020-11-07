using Chaldal.MenuPlanner.Framework;
using Chaldal.MenuPlanner.Framework.Entity;
using System.Collections.Generic;

namespace Chaldal.MenuPlanner.Web.Models
{
    public class PlanningIndexModel : PlanningBaseModel
    {
        public PlanningIndexModel(IMealService mealService)
            : base(mealService)
        {  }

        public PlanningIndexModel()
            : base()
        { }

        public IList<Meal> Meals { get; set; }

        public void LoadMeal(string userId)
        {
            Meals = _mealService.GetMeals(userId);
        }
    }
}
