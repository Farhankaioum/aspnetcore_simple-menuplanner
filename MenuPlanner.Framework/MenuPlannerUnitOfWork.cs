using Chaldal.MenuPlanner.Data;

namespace Chaldal.MenuPlanner.Framework
{
    public class MenuPlannerUnitOfWork : UnitOfWork, IMenuPlannerUnitOfWork
    {
        public IMealRepository MealRepository { get; set; }
        public IDishRepository DishRepository { get; set; }

        public MenuPlannerUnitOfWork(FrameworkContext context,
                IMealRepository mealRepository,
                IDishRepository dishRepository)
            :base(context)
        {
            MealRepository = mealRepository;
            DishRepository = dishRepository;
        }
    }
}
