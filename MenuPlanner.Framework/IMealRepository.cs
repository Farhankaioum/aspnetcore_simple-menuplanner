using Chaldal.MenuPlanner.Data;
using Chaldal.MenuPlanner.Framework.Entity;

namespace Chaldal.MenuPlanner.Framework
{
    public interface IMealRepository : IRepository<Meal, int, FrameworkContext>
    {
    }
}
