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
    public class FoodCategoryConfig : EntityTypeConfiguration<FoodCategory>
    {
        public FoodCategoryConfig()
        {
            Property(a => a.FoodCategoryID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.CategoryName).IsRequired().HasMaxLength(100);
            Property(a => a.Description).IsRequired();
        }
    }
}
