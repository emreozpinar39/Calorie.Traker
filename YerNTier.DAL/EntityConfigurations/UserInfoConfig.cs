using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Entities;

namespace YerNTier.DAL.EntityConfigurations
{
    public class UserInfoConfig: EntityTypeConfiguration<UserInfo>
    {
        public UserInfoConfig()
        {
            Property(a => a.MessageComment).IsRequired().HasMaxLength(200);
            Property(a => a.SenderName).IsOptional().HasMaxLength(50);
           // Property(a => a.YourTurn).IsOptional().HasMaxLength(50);
            
            HasRequired(a => a.DUsers).WithMany(a => a.UserInfos).HasForeignKey(a => a.DUserID);
        }
    }
}
