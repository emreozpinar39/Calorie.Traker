using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Entities;

namespace YerNTier.DAL.Repositories
{
    public class TicTacRepository
    {
        YerDBContext context;
        public TicTacRepository()
        {
            context = new YerDBContext();
        }
        public bool UpdateUserTicTac(TicTac _ticTac)
        {
            TicTac updateTicTac = context.TicTacs.Find(_ticTac.DUserID);
            updateTicTac.YourTurn = _ticTac.YourTurn;
            updateTicTac.DUserID = _ticTac.DUserID;
             
            return context.SaveChanges() > 0;
        }
        public TicTac ShowTicTacString(int _userID)
        {
            TicTac ticTac = context.TicTacs.Where(a => a.DUserID ==_userID).SingleOrDefault();
            return ticTac;
        }
        public TicTac GetByFoodID(int _ticTacID)
        {
            return context.TicTacs.Find(_ticTacID);
        }
    }
}
