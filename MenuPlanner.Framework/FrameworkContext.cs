using Chaldal.MenuPlanner.Framework.Entity;
using Microsoft.EntityFrameworkCore;

namespace Chaldal.MenuPlanner.Framework
{
    public class FrameworkContext : DbContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public FrameworkContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {

                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Meal>().Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Entity<Meal>().Property(m => m.UserId)
                .IsRequired()
                .HasMaxLength(100);

            builder.Entity<Meal>()
                .HasMany(d => d.Dishes)
                .WithOne(m => m.Meal)
                .HasForeignKey(m => m.MealId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Dish>()
                .Property(d => d.DishName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Entity<Dish>()
                .Property(d => d.DishesFor)
                .IsRequired()
                .HasMaxLength(90);

            base.OnModelCreating(builder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Meal> Meals { get; set; }


    }
}
