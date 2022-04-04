using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Entities;

namespace YerNTier.DAL.Repositories
{
    public class UserDetailRepository
    {
        YerDBContext context;
        public UserDetailRepository()
        {
            context = new YerDBContext();
        }
        public bool AddUserDetail(UserDetail userDetail)
        {
            context.UserDetails.Add(userDetail);
            return context.SaveChanges() > 0;
        }
        public bool UpdateUserDetail(UserDetail _userDetail)
        {
            UserDetail userDet = context.UserDetails.Find(_userDetail.UserDetailID);
            userDet.UserName = _userDetail.UserName;
            userDet.SurName = _userDetail.SurName;
            userDet.Height = _userDetail.Height;
            userDet.Weight = _userDetail.Weight;
            return context.SaveChanges() > 0;
        }
       
        public UserDetail GetUserDetailByID(int _userID)
        {
            return context.UserDetails.Find(_userID);
        }
    }
}
