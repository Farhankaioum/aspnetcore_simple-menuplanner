using Chaldal.MenuPlanner.Data;
using Chaldal.MenuPlanner.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chaldal.MenuPlanner.Framework
{
    public class DishRepository : Repository<Dish, int, FrameworkContext>, IDishRepository
    {
        public DishRepository(FrameworkContext dbContext)
          : base(dbContext)
        {

        }
    }
}
