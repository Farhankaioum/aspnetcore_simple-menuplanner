using Autofac;
using Chaldal.MenuPlanner.Framework;
using Chaldal.MenuPlanner.Framework.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Chaldal.MenuPlanner.Web.Models
{
    public class DishCreateViewModel
    {
        [Required]
        [Display(Name ="Dish Name")]
        public string DishName { get; set; }

        [Required]
        [Display(Name ="Dishes")]
        public string DishesFor { get; set; }
        public DateTime Created { get; set; }
        public int MealId { get; set; }

        private readonly IDishService _dishService;

        public DishCreateViewModel(IDishService dishService)
        {
            _dishService = dishService;
        }

        public DishCreateViewModel()
        {
            _dishService = Startup.AutofacContainer.Resolve<IDishService>();
        }

        public void CreateDish()
        {
            var dish = new Dish
            {
                DishName = this.DishName,
                DishesFor = this.DishesFor,
                Created = DateTime.Now,
                MealId = this.MealId
            };

            _dishService.CreateDish(dish);
        }

    }
}
