using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YerNTier.DAL.EntityConfigurations
{
    public class UserDetailConfig : EntityTypeConfiguration<UserDetail>
    {
        public UserDetailConfig()
        {
            Property(a => a.UserName).IsRequired().HasMaxLength(30);
            Property(a => a.SurName).IsRequired().HasMaxLength(30);
            Property(a => a.Height).IsRequired();
            Property(a => a.Weight).IsRequired();
            Property(a => a.Gender).IsRequired();
            Property(a => a.BirthDate).IsRequired();
        }
    }
}
