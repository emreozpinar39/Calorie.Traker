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
    public class MealConfig : EntityTypeConfiguration<Meal>
    {
        public MealConfig()
        {
            Property(a => a.MealName).IsRequired().HasMaxLength(30);
            Property(a => a.MealDate).IsRequired();
            Property(a => a.MTotalCalorie).IsRequired();

            HasRequired(a => a.DUser).WithMany(a => a.Meals).HasForeignKey(a => a.DUserID);

            HasMany(a => a.EatenFoods).WithMany(b => b.Meals).Map(a =>
                {
                    a.MapLeftKey("MealID");
                    a.MapRightKey("EatenFoodID");
                    a.ToTable("EatenFoodsAndMeals");
                }
            );
        }
    }
}
