﻿using Autofac;

namespace Chaldal.MenuPlanner.Framework
{
    public class FrameworkModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FrameworkModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FrameworkContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<MenuPlannerUnitOfWork>().As<IMenuPlannerUnitOfWork>()
               .InstancePerLifetimeScope();

            builder.RegisterType<MealRepository>().As<IMealRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<MealService>().As<IMealService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DishRepository>().As<IDishRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DishService>().As<IDishService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
