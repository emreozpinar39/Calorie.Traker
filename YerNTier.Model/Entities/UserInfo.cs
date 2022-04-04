using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerNTier.Model.Entities
{
    public class UserInfo
    {
        public int UserInfoID { get; set; }
        public string MessageComment { get; set; }
        public string SenderName { get; set; }
        public int HighScore { get; set; }
        
        public int DUserID { get; set; }
        public DUser DUsers { get; set; }
    }
}
