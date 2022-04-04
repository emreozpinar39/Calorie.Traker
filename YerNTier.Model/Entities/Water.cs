using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerNTier.Model.Entities
{
    public class Water
    {
        public int WaterID { get; set; }
        public int Quantity { get; set; }
        public DateTime DrinkTime { get; set; } = DateTime.Now;
        public int DUserID { get; set; }
        public virtual DUser DUser { get; set; }
    }
}
