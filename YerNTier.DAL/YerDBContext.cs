using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YerNTier.DAL.EntityConfigurations;
using YerNTier.DAL.Strategy;
using YerNTier.Model.Entities;

namespace YerNTier.DAL
{
    public class YerDBContext : DbContext
    {
        public YerDBContext():base("Server=DESKTOP-SD4G2J1\\SQLEXPRESS;Database=YerDB;Trusted_Connection=True;")
        {
            Database.SetInitializer(new YerStrategy());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DUserConfig());
            modelBuilder.Configurations.Add(new FoodCategoryConfig());
            modelBuilder.Configurations.Add(new FoodConfig());
            modelBuilder.Configurations.Add(new MealConfig());
            modelBuilder.Configurations.Add(new PasswordConfig());
            modelBuilder.Configurations.Add(new UserDetailConfig());
            modelBuilder.Configurations.Add(new WaterConfig());
            modelBuilder.Configurations.Add(new UserInfoConfig());
            modelBuilder.Configurations.Add(new EatenFoodConfig());
            modelBuilder.Configurations.Add(new TicTacConfig());
        }
        public DbSet<DUser> DUsers { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Water> Waters { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<EatenFood> EatenFoods { get; set; }
        public DbSet<TicTac> TicTacs { get; set; }
    }
}
