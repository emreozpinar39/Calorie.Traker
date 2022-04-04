using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Entities;

namespace YerNTier.DAL.Repositories
{
    public class PasswordRepository
    {
        YerDBContext dbContext;
        public PasswordRepository()
        {
            dbContext = new YerDBContext();
        }
       
        /// <summary>
        /// int döndürdüm servicesda kontrol edicem
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool  AddPass(Password _password)
        {
            dbContext.Passwords.Add(_password);
            return dbContext.SaveChanges()>0;
        }
      
        public Password GetActivePassword(int _userId)
        {
            return dbContext.Passwords.Where(a => a.DUserID == _userId).OrderByDescending(a => a.CreateDatePass).FirstOrDefault();
        }
        
    }
}
