using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerNTier.Model.Entities
{
    public class Password
    {
        public int PasswordID { get; set; }
        public string PasswordText { get; set; }
        public DateTime CreateDatePass { get; set; } = DateTime.Now;
        public int DUserID { get; set; }
        public virtual DUser DUser { get; set; }
    }
}
