using Chaldal.MenuPlanner.Data;
using System;
using System.Collections.Generic;

namespace Chaldal.MenuPlanner.Framework.Entity
{
    public class Meal : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public IList<Dish> Dishes { get; set; }
    }
}
