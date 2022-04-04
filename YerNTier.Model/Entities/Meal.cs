using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Enums;

namespace YerNTier.Model.Entities
{
    public class Meal
    {
        public Meal()
        {
            EatenFoods = new HashSet<EatenFood>();
        }

        public int MealID { get; set; }
        public string MealName { get; set; }
        public DateTime MealDate { get; set; } = DateTime.Now;
        public decimal MTotalCalorie { get; set; }
        public int DUserID { get; set; }
        public virtual DUser DUser { get; set; }
        public virtual ICollection<EatenFood> EatenFoods { get; set; }

    }
}
