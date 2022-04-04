using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Entities;

namespace YerNTier.DAL.Repositories
{
    public class WaterRepository
    {
        YerDBContext context;
        public WaterRepository()
        {
            context = new YerDBContext();
        }

        
        //form açılırken içilen suyu yazdırmak
        public int GetWater(int UserID)
        {
            Water water = context.Waters.Where(a => a.DUserID == UserID && a.DrinkTime.Day == DateTime.Now.Day).FirstOrDefault();
            if (water is null)
            {
                water = new Water();
                water.Quantity = 0;
                water.DrinkTime = DateTime.Now;
                water.DUserID = UserID;
                context.Waters.Add(water);
                context.SaveChanges();
            }
            return water.Quantity;
        }
        //formu kapatırken eklenen suyu database aktarmak
        public bool UpdateWater(int userID, int quantity)
        {
            Water water = context.Waters.Where(a => a.DUserID == userID).FirstOrDefault();
            water.Quantity = quantity;

            return context.SaveChanges() > 0;
        }
    }
}
