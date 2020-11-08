using Microsoft.EntityFrameworkCore;

namespace Chaldal.MenuPlanner.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DbContext _dbContext;

        public UnitOfWork(DbContext dbContext) => _dbContext = dbContext;

        public void Save()
        {
            _dbContext?.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}
