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
    public class FoodConfig : EntityTypeConfiguration<Food>
    {
        public FoodConfig()
        {
            Property(a => a.FoodName).IsRequired().HasMaxLength(30);
            Property(a => a.Calorie).IsRequired();
            Property(a => a.Protein).IsRequired();
            Property(a => a.FoodImage).IsOptional();

            HasRequired(a => a.FoodCategory).WithMany(a => a.Foods).HasForeignKey(a => a.CategoryID);
        }
    }
}
