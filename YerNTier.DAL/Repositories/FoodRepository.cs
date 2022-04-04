using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Entities;

namespace YerNTier.DAL.Repositories
{
    public class FoodRepository
    {
        YerDBContext context;
        public FoodRepository()
        {
            context = new YerDBContext();
        }

        public List<Food> GetFoods()
        {
            return context.Foods.ToList();
        }
        public List<Food> GetFoodsByText(string text)
        {
            return context.Foods.Where(a => a.FoodName.Contains(text)).ToList();
        }

        public Food GetByFoodId(int foodID)
        {
            return context.Foods.Find(foodID);
        }

        public bool Insert(Food _food)
        {
            context.Foods.Add(_food);
            return context.SaveChanges() > 0;
        }
        
        public bool Update(Food _food)
        {
            Food updatedFood = context.Foods.Find(_food.FoodID);
            updatedFood.CategoryID = _food.CategoryID;
            updatedFood.FoodName = _food.FoodName;
            updatedFood.Calorie = _food.Calorie;
            updatedFood.Protein = _food.Protein;
            updatedFood.FoodImage = _food.FoodImage;
            return context.SaveChanges() > 0;
        }

        public bool Delete(Food food)
        {
            Food deletedFood = context.Foods.Find(food.FoodID);
            context.Foods.Remove(deletedFood);
            return context.SaveChanges() > 0;
        }
        public bool InsertFoodCategory(FoodCategory foodCategory)
        {
            context.FoodCategories.Add(foodCategory);
            return context.SaveChanges() > 0;
        }
        public List<FoodCategory> GetFoodCategories()
        {
            return context.FoodCategories.ToList();
        }
    }
}
