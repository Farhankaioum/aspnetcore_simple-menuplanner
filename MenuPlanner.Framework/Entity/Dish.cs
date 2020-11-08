using Chaldal.MenuPlanner.Data;
using System;

namespace Chaldal.MenuPlanner.Framework.Entity
{
    public class Dish: IEntity<int>
    {
        public int Id { get; set; }
        public string DishName { get; set; }
        public string DishesFor { get; set; }
        public DateTime Created { get; set; }

        public Meal Meal { get; set; }
        public int MealId { get; set; }
    }
}
