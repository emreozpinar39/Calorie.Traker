using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using YerNTier.DAL.Repositories;
using YerNTier.Model.Entities;

namespace YerNTier.BLL.Services
{
    public class MealService
    {
        MealRepository mealRepository;
        public MealService()
        {
            mealRepository = new MealRepository();
        }
        public Meal AddFoodsToMeals(Meal meal, EatenFood _Efood)
        {
            return mealRepository.AddFoodsToMeals(meal, _Efood);
        }
        //MealID kontrol eden method
        public Meal GetByMealId(int mealID)
        {
            if (mealID >= 0)
            {
                Meal meal = mealRepository.GetByMealId(mealID);
                return meal;
            }
            else
            {
                throw new Exception("Parametre değeri uygun değil");
            } 
        }
        
        //Gelen UserID var mı yok mu kontrol eden method
        public List<Meal> GetById(int userID)
        {
            List<Meal> meals = new List<Meal>();

            if (userID > 0)
            {
                meals = mealRepository.GetByUserId(userID);
            }
            else
            {
                throw new Exception("Parametre değeri uygun değil");
            }
            return meals;
        }

        void CheckMeal(Meal meal)
        {
            if (string.IsNullOrWhiteSpace(meal.MealName) || string.IsNullOrWhiteSpace(meal.MealDate.ToString())
                ) throw new Exception("Meal bilgileri eksik !!");
        }

        //Meal gelen mealları kontrol eden method insert 
        public bool Insert(Meal meal)
        {
            CheckMeal(meal);
            return mealRepository.Insert(meal);
        }

 

        //Meal tipinde gelen mealları kontrol eden delete methodu 
        public bool CDelete(Meal _meal)
        {
            CheckMeal(_meal);
            if (_meal.DUserID > 0)
            {
                return mealRepository.Delete(_meal);
            }
            else throw new Exception("UserId kontrol ediniz");
        }

        //gelen int userID>0 kontrol eden listeleme methodları 3 tane 
        public List<Meal> GetDailyByUserID(int _userID)
        {
            if (_userID > 0)
                return mealRepository.GetMealsForDailyByUserId(_userID);
            else throw new Exception("Liste hatalı");
        }

        public List<Meal> GetWeeklyByUserID(int _userID)
        {
            if (_userID > 0)
                return mealRepository.GetMealsForWeekByUserId(_userID);
            else throw new Exception("Liste hatalı");
        }
        public List<Meal> GetMonthByUserID(int _userID)
        {
            if (_userID>0)
                return mealRepository.GetMealsForMonthByUserId(_userID);
            else throw new Exception("Liste hatalı");
        }
   
      
        public List<Meal> GetByDate(DateTime date,int _userID)
        {
            if (_userID > 0)
                return mealRepository.GetByDate(date, _userID);
            else throw new Exception("Hatalı ");     
        }
        public EatenFood GetByEatenFoodId(int _eatenFoodID)
        {
            if (_eatenFoodID > 0)
                return mealRepository.GetByEatenFoodId(_eatenFoodID);
            else throw new Exception("Id Hatalı");
        }
        public bool Update(int eatenFoodID,EatenFood _eatenFood)
        {
            if (_eatenFood != null)
                return mealRepository.Update(eatenFoodID,_eatenFood);
            else throw new Exception("Tekrar kontrol");
        }
        
        public bool Delete(EatenFood _eatenFood)
        {
            if (_eatenFood != null)
                return mealRepository.Delete(_eatenFood);
            else throw new Exception("Tekrar kontrol");
        }
        public decimal DailyCalorie(int _userID)
        {
            if (_userID > 0)
                return mealRepository.DailyCalorie(_userID);

            else throw new Exception("UserID Hatalı");
        }
        public decimal DailyProtein(int _userID)
        {
            if (_userID > 0)
                return mealRepository.DailyProtein(_userID);

            else throw new Exception("UserID Hatalı");
        }
        public decimal MonthlyCalorie(int _userID)
        {
            if (_userID > 0)
                return mealRepository.MonthlyCalorie(_userID);

            else throw new Exception("UserID Hatalı");
        }
        public decimal MonthlyProtein(int _userID)
        {
            if (_userID > 0) 
            return mealRepository.MonthlyProtein(_userID);

            else throw new Exception("UserID Hatalı");
        }
        public decimal WeeklyCalorie(int _userID)
        {
            return mealRepository.WeeklyCalorie(_userID);
        }
        public decimal WeeklyProt(int _userID)
        {
            return mealRepository.WeeklyProt(_userID);
        }
        public string MostEatenFood()
        {
            if (mealRepository.MostEatenFood() != null)
            {
                return mealRepository.MostEatenFood();
            }
            else return " ";
        }
    }
}
