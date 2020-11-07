using Chaldal.MenuPlanner.Data;
using Chaldal.MenuPlanner.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chaldal.MenuPlanner.Framework
{
    public interface IDishRepository : IRepository<Dish, int, FrameworkContext>
    {
    }
}
