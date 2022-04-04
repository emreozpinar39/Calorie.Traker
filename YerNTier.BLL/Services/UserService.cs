using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.DAL.Repositories;
using YerNTier.Model.Entities;

namespace YerNTier.BLL.Services
{
    public class UserService
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }
        /// <summary>
        /// CheckByUserIdAndPassId methoduna email ve password girişlerini kontrol eden method
        /// </summary>
        /// <param name="_email"></param>
        /// <param name="_pass"></param>
        /// <returns></returns>
        public DUser CheckLogin(string _email,string _pass)
        {
            if (_email=="" ||_pass=="" )
                throw new Exception("Lütfen e-mail veya password giriniz.");
            return userRepository.CheckByUserIdAndPassId(_email,_pass);
        }
        public int AddUser(DUser _user)
        {
            if (_user != null)
               return userRepository.AddUser(_user);
            else
                throw new Exception("Lütfen kontrol edin");
        }
      
        public List<DUser> GetUserForChallenge(string _wish)
        {
            return userRepository.GetUserForChallenge(_wish);
        }
        public List<DUser> GetUserForChallengeAndKey(string _wish, string text)
        {
            return userRepository.GetUserForChallengeAndKey(_wish,text);
        }
        public DUser GetUserByUserID(int _userID)
        {
            if (_userID > 0)
                return userRepository.GetUserByUserID(_userID);
            else
                throw new Exception("User Hatası");
        }

        public bool UserEmailIfExist(string _email)
        {
            bool sonuc= false;
            List<string> list = userRepository.GetUsersEmail();
            if (list.Contains(_email))
            {
                throw new Exception("Böyle bir E-mail mevcut");
                return sonuc;
            }
            else
            {
                sonuc = true;
                return sonuc;
            }
        }
    }
}
