using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using YerNTier.Model.Entities;
using YerNTier.Model.Enums;

namespace YerNTier.DAL.Strategy
{
    public class YerStrategy:CreateDatabaseIfNotExists<YerDBContext>
    {
        protected override void Seed(YerDBContext yerDBcontext)
        {
            // database oluşturulurken yapılacaklar
            FoodCategory foodCategory = new FoodCategory
            {
                CategoryName = "Sebzeler",
                Description = "Sebzeleri içerir."
            };
            yerDBcontext.FoodCategories.Add(foodCategory);
            FoodCategory foodCategory2 = new FoodCategory
            {
                CategoryName = "Meyveler",
                Description = "Meyveleri içerir."
            };
            yerDBcontext.FoodCategories.Add(foodCategory2);
            FoodCategory foodCategory3 = new FoodCategory
            {
                CategoryName = "Etler",
                Description = "Etleri içerir."
            };
            yerDBcontext.FoodCategories.Add(foodCategory3);
            FoodCategory foodCategory4 = new FoodCategory
            {
                CategoryName = "Kuruyemişler",
                Description = "Kuruyemişler içerir."
            };
            yerDBcontext.FoodCategories.Add(foodCategory4);
            yerDBcontext.SaveChanges();

            Food food = new Food()
            {
                FoodName = "Tavuk",
                Calorie = 239,
                Protein = 27,
                CategoryID = 3,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\tavuk.jpg"
            };
            yerDBcontext.Foods.Add(food);

            Food food1 = new Food()
            {
                FoodName = "Havuç",
                Calorie = 41,
                Protein = 1,
                CategoryID = 1,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\havuç.jpg"

            };
            yerDBcontext.Foods.Add(food1);

            Food food2 = new Food()
            {
                FoodName = "Elma",
                Calorie = 52,
                Protein = 0,
                CategoryID = 2,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\elma.jpg"

            };
            yerDBcontext.Foods.Add(food2);

            Food food3 = new Food()
            {
                FoodName = "Fındık",
                Calorie = 628,
                Protein = 15,
                CategoryID = 4,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\fındık.jpg"
            };
            yerDBcontext.Foods.Add(food3);

            Food food4 = new Food()
            {
                FoodName = "Badem",
                Calorie = 598,
                Protein = 19,
                CategoryID = 4,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\badem.jpg"
            };
            yerDBcontext.Foods.Add(food4);

            Food food5 = new Food()
            {
                FoodName = "Kaju",
                Calorie = 550,
                Protein = 18,
                CategoryID = 4,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\kaju.jpg"
            };
            yerDBcontext.Foods.Add(food5);

            Food food6 = new Food()
            {
                FoodName = "Tavuk Göğsü",
                Calorie = 110,
                Protein = 25,
                CategoryID = 3,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\tavukgöğsü.jpg"
            };
            yerDBcontext.Foods.Add(food6);

            Food food7 = new Food()
            {
                FoodName = "Tavuk Pirzola",
                Calorie = 146,
                Protein = 19,
                CategoryID = 3,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\tavukpirzola.jpg"
            };
            yerDBcontext.Foods.Add(food7);

            Food food8 = new Food()
            {
                FoodName = "Fıstık",
                Calorie = 567,
                Protein = 26,
                CategoryID = 4,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\fıstık.jpg"
            };
            yerDBcontext.Foods.Add(food8);

            Food food9 = new Food()
            {
                FoodName = "Brokoli",
                Calorie = 26,
                Protein = 3,
                CategoryID = 1,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\brokoli.jpg"
            };
            yerDBcontext.Foods.Add(food9);

            Food food10 = new Food()
            {
                FoodName = "Patlıcan",
                Calorie = 61,
                Protein = 1,
                CategoryID = 1,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\patlıcan.jpg"
            };
            yerDBcontext.Foods.Add(food10);

            Food food11 = new Food()
            {
                FoodName = "Portakal",
                Calorie = 101,
                Protein = 1,
                CategoryID = 2,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\portakal.jpg"
            };
            yerDBcontext.Foods.Add(food11);

            Food food12 = new Food()
            {
                FoodName = "Kiraz",
                Calorie = 63,
                Protein = 1,
                CategoryID = 2,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\kiraz.jpg"
            };
            yerDBcontext.Foods.Add(food12);

            Food food13 = new Food()
            {
                FoodName = "Muz",
                Calorie = 88,
                Protein = 1,
                CategoryID = 2,
                Portion = Portion.Gram,
                Quantity = 100,
                FoodImage = @"C:\Users\emre_\Desktop\SaglikliYER\muz.jpg"
            };
            yerDBcontext.Foods.Add(food13);
            yerDBcontext.SaveChanges();
        }
    }
}
