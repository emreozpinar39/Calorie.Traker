using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerNTier.Model.Entities
{
    public class DUser
    {
        public DUser()
        {
            Meals = new HashSet<Meal>();
            Waters = new HashSet<Water>();
            Passwords = new HashSet<Password>();
            UserInfos = new HashSet<UserInfo>();
            TicTacs = new HashSet<TicTac>();
        }
        public int DUserID { get; set; }
        public virtual UserDetail UserDetail { get; set; }
        public string Email { get; set; }
        public string Wish { get; set; }

        public DateTime SubDate { get; set; } = DateTime.Now;
        public virtual ICollection<Meal> Meals { get; set; }
        public virtual ICollection<Water> Waters { get; set; }
        public virtual ICollection<Password> Passwords { get; set; }
        public virtual ICollection<UserInfo> UserInfos{ get; set; }
        public virtual ICollection<TicTac> TicTacs{ get; set; }

    }
}
