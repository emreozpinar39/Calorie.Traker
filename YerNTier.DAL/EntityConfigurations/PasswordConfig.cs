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
    public class PasswordConfig : EntityTypeConfiguration<Password>
    {
        public PasswordConfig()
        {
            Property(a => a.PasswordText).IsRequired().HasMaxLength(30);
            Property(a => a.CreateDatePass).IsRequired();

            HasRequired(a => a.DUser).WithMany(a => a.Passwords).HasForeignKey(a => a.DUserID);
        }
    }
}
