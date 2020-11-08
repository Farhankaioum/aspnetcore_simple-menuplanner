using Chaldal.MenuPlanner.Data;

namespace Chaldal.MenuPlanner.Framework
{
    public interface IMenuPlannerUnitOfWork : IUnitOfWork
    {
        IMealRepository MealRepository { get; set; }
        IDishRepository DishRepository { get; set; }
    }
}
