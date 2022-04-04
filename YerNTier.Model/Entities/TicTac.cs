using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerNTier.Model.Entities
{
    public class TicTac
    {
        public int TicTacID { get; set; }
        public string YourTurn { get; set; }
        public int DUserID { get; set; }
        public DUser DUsers { get; set; }
    }
}
