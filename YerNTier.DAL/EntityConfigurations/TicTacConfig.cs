using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Entities;

namespace YerNTier.DAL.EntityConfigurations
{
    class TicTacConfig: EntityTypeConfiguration<TicTac>
    {
        public TicTacConfig()
        {
            Property(a => a.YourTurn).IsRequired().HasMaxLength(200);
            HasRequired(a => a.DUsers).WithMany(a => a.TicTacs).HasForeignKey(a => a.DUserID);
        }
    }
}
