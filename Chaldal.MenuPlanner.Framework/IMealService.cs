using Chaldal.MenuPlanner.Framework.Entity;
using System;
using System.Collections.Generic;

namespace Chaldal.MenuPlanner.Framework
{
    public interface IMealService : IDisposable
    {
        void CreateMeal(Meal meal);
        void EditMeal(Meal meal);
        Meal GetMeal(int id);
        IList<Meal> GetMeals(string userId);
        Meal DeleteMeal(int id);
    }
}
