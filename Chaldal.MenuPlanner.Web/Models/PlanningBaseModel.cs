using Autofac;
using Chaldal.MenuPlanner.Framework;

namespace Chaldal.MenuPlanner.Web.Models
{
    public class PlanningBaseModel
    {
        protected readonly IMealService _mealService;

        public PlanningBaseModel(IMealService mealService)
        {
            _mealService = mealService;
        }

        public PlanningBaseModel()
        {
            _mealService = Startup.AutofacContainer.Resolve<IMealService>();
        }
    }
}
