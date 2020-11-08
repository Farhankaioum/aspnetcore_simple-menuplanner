using Autofac;
using Chaldal.MenuPlanner.Web.Models;

namespace Chaldal.MenuPlanner.Web
{
    public class WebModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public WebModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PlanningIndexModel>();

            base.Load(builder);
        }
    }
}
