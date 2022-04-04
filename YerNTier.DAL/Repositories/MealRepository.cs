using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Entities;

namespace YerNTier.DAL.Repositories
{
    public class MealRepository
    {
        YerDBContext context;
        public MealRepository()
        {
            context = new YerDBContext();
        }
        
        public List<Meal> GetByUserId(int userID)
        {
            return context.Meals.Where(a => a.DUserID == userID).ToList();
        }

        public Meal GetByMealId(int mealID)
        {
            return context.Meals.Where(x=> x.MealID == mealID).FirstOrDefault();
        }

        public bool Insert(Meal meal)
        {
            context.Meals.Add(meal);
            return context.SaveChanges() > 0;
        }

       

        public bool Delete(Meal meal)
        {
            Meal deletedMeal = context.Meals.Find(meal.MealID);
            context.Meals.Remove(deletedMeal); // değişebilir !!
            return context.SaveChanges() > 0;
        }

        public List<Meal> GetMealsForDailyByUserId(int userID)
        {
            return context.Meals.Where(a => a.DUserID == userID && a.MealDate.Day == DateTime.Now.Day).ToList();
        }

        public List<Meal> GetMealsForMonthByUserId(int userID)
        {
            return context.Meals.Where(a => a.DUserID == userID && a.MealDate.Month == DateTime.Now.Month).ToList();
        }

        public DateTime FirstDayOfWeek()
        {
            DateTime firstDay = DateTime.Now.AddDays(-(double)(DateTime.Now.DayOfWeek + 1));

            return firstDay;
        }

        public DateTime LastDayOfWeek()
        {
            DateTime lastDay = FirstDayOfWeek().AddDays(7);

            return lastDay;
        }

        public List<Meal> GetMealsForWeekByUserId(int userID)
        {
            DateTime fdt = FirstDayOfWeek();
            DateTime ldt = LastDayOfWeek();
            return context.Meals.Where(a => a.MealDate < ldt && a.MealDate > fdt).ToList();
        }

     

    
        public List<Meal> GetByDate(DateTime date,int _userID)
        {
            return context.Meals.Where(a => a.MealDate.Day == date.Day && a.DUserID==_userID).ToList();
        }
        public Meal AddFoodsToMeals(Meal meal, EatenFood _Efood)
        {
            Meal _meal = context.Meals.Find(meal.MealID);
            _meal.EatenFoods.Add(_Efood);
            context.SaveChanges();
            return _meal;
        }

        public EatenFood GetByEatenFoodId(int _eatenFoodID)
        {
            return context.EatenFoods.Find(_eatenFoodID);
        }
        public bool Update(int eatenFoodID ,EatenFood _eatenFood)
        {
            EatenFood updatedEatenFood = context.EatenFoods.Find(eatenFoodID);
            updatedEatenFood.EatenCategoryID = _eatenFood.EatenCategoryID;
            updatedEatenFood.EatenColorie = _eatenFood.EatenColorie;
            updatedEatenFood.EatenFoodName = _eatenFood.EatenFoodName;
            updatedEatenFood.EatenPortion = _eatenFood.EatenPortion;
            updatedEatenFood.EatenProtein = _eatenFood.EatenProtein;
            updatedEatenFood.EatenQuantity = _eatenFood.EatenQuantity;
            updatedEatenFood.FoodID = _eatenFood.FoodID;
            return context.SaveChanges() > 0;
        }
        public bool Delete(EatenFood _eatenFood)
        {
            //EatenFood deletedFood = context.EatenFoods.Find(_eatenFood.FoodID);
            context.EatenFoods.Remove(_eatenFood);
            return context.SaveChanges() > 0;
        }
        public decimal DailyCalorie(int _userID)
        {
            decimal totalCal = 0;

            List<Meal> meals = context.Meals.Where(a => a.MealDate.Day == DateTime.Now.Day && a.DUserID == _userID).ToList();

            foreach (Meal item in meals)
            {
                foreach (EatenFood item2 in item.EatenFoods)
                {
                    totalCal += item2.EatenColorie;
                }
            }
            return totalCal;
        }
        public decimal DailyProtein(int _userID)
        {
            decimal totalProt = 0;
            List<Meal> meals = context.Meals.Where(a => a.MealDate.Day == DateTime.Now.Day && a.DUserID == _userID).ToList();

            foreach (Meal item in meals)
            {
                foreach (EatenFood item2 in item.EatenFoods)
                {
                    totalProt += item2.EatenProtein;
                }
            }
            return totalProt;
        }
        public decimal MonthlyCalorie(int _userID)
        {
            decimal totalCal = 0;

            List<Meal> meals = context.Meals.Where(a => a.MealDate.Month == DateTime.Now.Month && a.DUserID == _userID).ToList();

            foreach (Meal item in meals)
            {
                foreach (EatenFood item2 in item.EatenFoods)
                {
                    totalCal += item2.EatenColorie;
                }
            }
            return totalCal;
        }
        public decimal MonthlyProtein(int _userID)
        {
            decimal totalProt = 0;
            List<Meal> meals = context.Meals.Where(a => a.MealDate.Month == DateTime.Now.Month && a.DUserID == _userID).ToList();

            foreach (Meal item in meals)
            {
                foreach (EatenFood item2 in item.EatenFoods)
                {
                    totalProt += item2.EatenProtein;
                }
            }
            return totalProt;
        }
        public decimal WeeklyCalorie(int _userID)
        {
            decimal totalCal = 0;
            DateTime fdt = FirstDayOfWeek();
            DateTime ldt = LastDayOfWeek();

            List<Meal> meals = context.Meals.Where(a => a.MealDate < ldt && a.MealDate > fdt && a.DUserID == _userID).ToList();

            foreach (Meal item in meals)
            {
                foreach (EatenFood item2 in item.EatenFoods)
                {
                    totalCal += item2.EatenColorie;
                }
            }
            return totalCal;
        }
        public decimal WeeklyProt(int _userID)
        {
            decimal totalProt = 0;
            DateTime fdt = FirstDayOfWeek();
            DateTime ldt = LastDayOfWeek();

            List<Meal> meals = context.Meals.Where(a => a.MealDate < ldt && a.MealDate > fdt && a.DUserID == _userID).ToList();

            foreach (Meal item in meals)
            {
                foreach (EatenFood item2 in item.EatenFoods)
                {
                    totalProt += item2.EatenProtein;
                }
            }
            return totalProt;
        }
        public string MostEatenFood()
        {
            var group = context.EatenFoods.GroupBy(e => e.EatenFoodName).Select(n => new
            {
            EatenFood = n.Key,
            FoodCount = n.Count()
            }).OrderByDescending(a => a.FoodCount).FirstOrDefault();
            if (group != null)
            {
                return group.EatenFood;
            }
            return null;
        }
    }
}
