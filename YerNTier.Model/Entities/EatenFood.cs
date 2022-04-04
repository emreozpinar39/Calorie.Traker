using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Enums;

namespace YerNTier.Model.Entities
{
    public class EatenFood
    {
        public EatenFood()
        {
            Meals = new HashSet<Meal>();
        }
        public int EatenFoodID { get; set; }
        public string EatenFoodName { get; set; }
        public decimal EatenColorie { get; set; }
        public decimal  EatenProtein { get; set; }
        public decimal EatenQuantity { get; set; }
        public virtual Portion EatenPortion { get; set; } = Portion.Portion400gr;
        public int EatenCategoryID { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public int FoodID { get; set; }
        public Food Food { get; set; }
    }
}
