using Chaldal.MenuPlanner.Framework;
using Chaldal.MenuPlanner.Framework.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Chaldal.MenuPlanner.Web.Models
{
    public class PlanningCreateViewModel : PlanningBaseModel
    {
        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [Display(Name = "Created")]
        public DateTime? CreatedDate { get; set; }
        public string UserId { get; set; }

        public PlanningCreateViewModel(IMealService mealService)
            :base(mealService)
        {  }

        public PlanningCreateViewModel()
            :base()
        { }

        public void CreateMeal()
        {
            var meal = new Meal
            {
                Name = this.Name,
                UserId = this.UserId,
                CreatedDate = this.CreatedDate.Value
            };

            _mealService.CreateMeal(meal);
        }



    }
}
