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
    public class DUserConfig:EntityTypeConfiguration<DUser>
    {
        public DUserConfig()
        {
            Property(a => a.Email).IsRequired().HasMaxLength(30);
            Property(a => a.Wish).HasMaxLength(30);
            Property(a => a.SubDate).IsRequired();

            HasOptional(a => a.UserDetail).WithRequired(b => b.DUser);
        }
    }
}
