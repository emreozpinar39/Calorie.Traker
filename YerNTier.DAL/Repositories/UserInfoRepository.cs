using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Entities;

namespace YerNTier.DAL.Repositories
{
    public class UserInfoRepository
    {
        YerDBContext context;
        public UserInfoRepository()
        {
            context = new YerDBContext();
        }
        /// <summary>
        /// Mesaj ekleme methodu
        /// </summary>
        /// <param name="_meal"></param>
        /// <returns></returns>
        public int AddMess(UserInfo _info)
        {
            context.UserInfos.Add(_info);
            return context.SaveChanges();
        }
        /// <summary>
        /// UserID e göre mesaj listeleme
        /// </summary>
        /// <param name="_userID"></param>
        /// <returns></returns>
        public List<UserInfo> ShowMess(int _userID)
        {
            return context.UserInfos.Where(a => a.DUserID == _userID).ToList();
        }
      
      
    }
}
