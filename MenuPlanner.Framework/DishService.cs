using Chaldal.MenuPlanner.Framework.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Chaldal.MenuPlanner.Framework
{
    public class DishService : IDishService
    {
        private readonly IMenuPlannerUnitOfWork _menuPlannerUnitOfWork;

        public DishService(IMenuPlannerUnitOfWork menuPlannerUnitOfWork)
        {
            _menuPlannerUnitOfWork = menuPlannerUnitOfWork;
        }

        public void CreateDish(Dish dish)
        {
            _menuPlannerUnitOfWork.DishRepository.Add(dish);
            _menuPlannerUnitOfWork.Save();
        }

        public Dish GetDish(int id)
        {
            var dish = _menuPlannerUnitOfWork.DishRepository.GetById(id);
            return dish;
        }

        public IList<Dish> GetDishes(string userId, int mealId)
        {
            var dishes = _menuPlannerUnitOfWork.DishRepository.GetAll()
                            .Where(m => m.MealId == mealId)
                            .OrderByDescending(d => d.Created)
                            .ToList();
            return dishes;
        }

        public void Dispose()
        {
            _menuPlannerUnitOfWork.Dispose();
        }
    }
}
