using System.Runtime.CompilerServices;

namespace Menu.Models
{
    public class MenuIngredient
    {
        public int DishId { get; set; }
        public Menu Menu { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
