using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.Model.Entities;

namespace YerNTier.DAL.EntityConfigurations
{
    class EatenFoodConfig : EntityTypeConfiguration<EatenFood>
    {
        public EatenFoodConfig()
        {
            Property(a => a.EatenFoodName).IsRequired().HasMaxLength(30);
            Property(a => a.EatenColorie).IsRequired();
            Property(a => a.EatenProtein).IsRequired();
        }
    }
}
