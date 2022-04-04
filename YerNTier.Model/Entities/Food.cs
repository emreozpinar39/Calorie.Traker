using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Enums;

namespace YerNTier.Model.Entities
{
    public class Food
    {
        public Food()
        {
            EatenFoods = new HashSet<EatenFood>();
        }
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public decimal Calorie { get; set; }
        public decimal Protein { get; set; }
        public string FoodImage { get; set; }
        public decimal Quantity { get; set; } = 1;
        public virtual Portion Portion { get; set; } = Portion.Portion400gr;
        public int CategoryID { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
        public virtual ICollection<EatenFood> EatenFoods { get; set; }

    }
}
