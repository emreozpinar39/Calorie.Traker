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
    public class WaterConfig : EntityTypeConfiguration<Water>
    {
        public WaterConfig()
        {
            Property(a => a.Quantity).IsRequired();
            Property(a => a.DrinkTime).IsRequired();

            HasRequired(a => a.DUser).WithMany(a => a.Waters).HasForeignKey(a => a.DUserID);
        }
    }
}
