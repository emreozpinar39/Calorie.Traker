using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Entities;

namespace YerNTier.DAL.Repositories
{
    public class UserRepository
    {
        YerDBContext dbContext;
        PasswordRepository passwordRepository;
        public UserRepository()
        {
            dbContext = new YerDBContext();
            passwordRepository = new PasswordRepository();
        }
        /// <summary>
        /// DUser tipinde email alan login kontrolu yapan method. kontrol dogru ise çalisacak method
        /// </summary>
        /// <param name="_email"></param>
        /// <returns></returns>
        public DUser CheckByUserIdAndPassId(string _email,string _pass)
        {
            DUser dUser = dbContext.DUsers.Where(x => x.Email == _email).FirstOrDefault();
            if (dUser != null)
            {
                Password password = passwordRepository.GetActivePassword(dUser.DUserID);
                if (password.PasswordText == _pass)
                {
                    return dUser;
                }
                else
                {
                    return null;
                }
            }
            else return null;
        }
      
       
        /// <summary>
        /// User tipinde user bilgilerini alıp insert eden method. Serivcesda null gelme durumları kontrol edilecek
        /// </summary>
        /// <param name="duser"></param>
        /// <returns></returns>
        public int AddUser(DUser _duser)
        {
            dbContext.DUsers.Add(_duser);
            return dbContext.SaveChanges();
        } 
        /// <summary>
        /// Challenge ekranı için User tipinde liste dönen method.
        /// </summary>
        /// <returns></returns>
        public List<DUser> GetUserForChallenge(string _wish)
        {
            return dbContext.DUsers.Where(a=>a.Wish==_wish).ToList();
        }
        public List<DUser> GetUserForChallengeAndKey(string _wish,string text)
        {
            return dbContext.DUsers.Where(a => a.Wish == _wish && a.Email.Contains(text)).ToList();
        }
    
        
        /// <summary>
        /// UserId Alan User tipinde user bilgisi dönen method
        /// </summary>
        /// <param name="_userID"></param>
        /// <returns></returns>
        public DUser GetUserByUserID(int _userID)
        {
            DUser dUser = dbContext.DUsers.Find(_userID);
            return dUser;
        }
        public List<string> GetUsersEmail()
        {
            return dbContext.DUsers.Select(a=>a.Email).ToList();
        }
    }
}
