using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.DAL.Repositories;
using YerNTier.Model.Entities;

namespace YerNTier.BLL.Services
{
    public class UserDatailsServece
    {
        UserDetailRepository userDetailRepository;
        public UserDatailsServece()
        {
            userDetailRepository = new UserDetailRepository();
        }
        public bool CAddUserDetail(UserDetail userDetail)
        {
            if (userDetail != null)
                return userDetailRepository.AddUserDetail(userDetail);
            else throw new Exception("User Hatası");
        }
        public bool CUpdateUserDetails(UserDetail _userDetail)
        {
             CheckUserDetails(_userDetail);
            return userDetailRepository.UpdateUserDetail(_userDetail);
        }
     
        void CheckUserDetails(UserDetail _userDetail)
        {
            if (_userDetail.UserName == null || _userDetail.SurName == null || _userDetail.Height == 0 || _userDetail.Weight == 0 || _userDetail.BirthDate == null)
                throw new Exception("UserDetail Hatası");
        }
        public UserDetail GetUserDetailByID(int _userID)
        {
            if (_userID > 0)
                return userDetailRepository.GetUserDetailByID(_userID);
            else throw new Exception("UserID Hatalı");
        }
    }
}
