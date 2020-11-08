using Chaldal.MenuPlanner.Framework.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Chaldal.MenuPlanner.Framework
{
    public class MealService : IMealService
    {
        private readonly IMenuPlannerUnitOfWork _menuPlannerUnitOfWork;

        public MealService(IMenuPlannerUnitOfWork menuPlannerUnitOfWork)
        {
            _menuPlannerUnitOfWork = menuPlannerUnitOfWork;
        }

        public void CreateMeal(Meal meal)
        {
            _menuPlannerUnitOfWork.MealRepository.Add(meal);
            _menuPlannerUnitOfWork.Save();
        }

        public Meal DeleteMeal(int id)
        {
            var meal = _menuPlannerUnitOfWork.MealRepository.GetById(id);
            _menuPlannerUnitOfWork.MealRepository.Remove(meal);
            _menuPlannerUnitOfWork.Save();

            return meal;
        }

        public void EditMeal(Meal meal)
        {
            var existingMeal = _menuPlannerUnitOfWork.MealRepository.GetById(meal.Id);
            existingMeal.Name = meal.Name;
            existingMeal.CreatedDate = meal.CreatedDate;

            _menuPlannerUnitOfWork.Save();
        }

        public IList<Meal> GetMeals(string userId)
        {
            var meals = _menuPlannerUnitOfWork.MealRepository.GetAll("Dishes")
                            .Where(u => u.UserId == userId && u.CreatedDate.Date == DateTime.Now.Date)
                            .OrderByDescending(m => m.CreatedDate)
                            .ToList();

            return meals;
        }

        public Meal GetMeal(int id)
        {
            var meal = _menuPlannerUnitOfWork.MealRepository.GetById(id);
            return meal;
        }

        public void Dispose()
        {
            _menuPlannerUnitOfWork.Dispose();
        }
    }
}
