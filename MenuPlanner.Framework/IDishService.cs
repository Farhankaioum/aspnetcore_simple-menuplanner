using Chaldal.MenuPlanner.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chaldal.MenuPlanner.Framework
{
    public interface IDishService : IDisposable
    {
        void CreateDish(Dish dish);
        Dish GetDish(int id);
        IList<Dish> GetDishes(string userId, int mealId);
    }
}
