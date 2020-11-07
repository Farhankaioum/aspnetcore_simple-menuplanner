using Chaldal.MenuPlanner.Data;
using Chaldal.MenuPlanner.Framework.Entity;

namespace Chaldal.MenuPlanner.Framework
{
    public class MealRepository : Repository<Meal, int, FrameworkContext>, IMealRepository
    {
        public MealRepository(FrameworkContext dbContext)
            : base(dbContext)
        {

        }
    }
}
