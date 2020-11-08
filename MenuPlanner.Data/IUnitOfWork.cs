using System;
using System.Collections.Generic;
using System.Text;

namespace Chaldal.MenuPlanner.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
