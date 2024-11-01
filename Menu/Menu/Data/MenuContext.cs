using Microsoft.EntityFrameworkCore;
using Menu.Models;


namespace Menu.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuIngredient>().HasKey(di => new
            {

                di.DishId,
                di.IngredientId
            });
            modelBuilder.Entity<MenuIngredient>().HasOne(m => m.Menu).WithMany(di => di.MenuIngredients).HasForeignKey(m => m.DishId);
            modelBuilder.Entity<MenuIngredient>().HasOne(i => i.Ingredient).WithMany(di => di.MenuIngredients).HasForeignKey(i => i.IngredientId);


            base.OnModelCreating(modelBuilder);
        }

    }
}
