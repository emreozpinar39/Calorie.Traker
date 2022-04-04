using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerNTier.Model.Entities
{
    public class UserDetail
    {
        public int UserDetailID { get; set; }
        public virtual DUser DUser { get; set; }
        public string UserName { get; set; }
        public string SurName { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public bool Gender { get; set; } //0 Erkek 1 Kadın
        public DateTime BirthDate { get; set; } = DateTime.Now;
    }
}
