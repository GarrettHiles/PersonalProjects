using Microsoft.EntityFrameworkCore;
using Menu.Models;


namespace Menu.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(di => new
            {

                di.DishId,
                di.IngredientId
            });
            modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish).WithMany(di => di.DishIngredients).HasForeignKey(m => m.DishId);
            modelBuilder.Entity<DishIngredient>().HasOne(i => i.Ingredient).WithMany(di => di.DishIngredients).HasForeignKey(i => i.IngredientId);

            modelBuilder.Entity<Dish>().HasData(
                new Dish { Id = 1, Name= "Pepperoni", Price = 10.99, ImageUrl= "https://getbento.imgix.net/accounts/aecdc64afa77b37b4b15940057dfef52/media/images/65880Pepperoni.png?w=1000&fit=max&auto=compress,format&h=1000" }
                );
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { Id = 1, Name = "Tomato Sauce"},
                new Ingredient { Id = 2, Name = "Mozzarella" },
                new Ingredient { Id = 3, Name = "Pepperoni" },
                new Ingredient { Id = 4, Name = "Dough" }
                );
            modelBuilder.Entity<DishIngredient>().HasData(
                new DishIngredient { DishId=1, IngredientId=1},
                new DishIngredient { DishId = 1, IngredientId = 2 }
                );


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishIngredient> MenuIngredients { get; set; }

    }
}
