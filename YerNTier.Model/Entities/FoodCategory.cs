using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerNTier.Model.Entities
{
    public class FoodCategory
    {
        public FoodCategory()
        {
            Foods = new HashSet<Food>();
        }
        public int FoodCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string  Description { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
