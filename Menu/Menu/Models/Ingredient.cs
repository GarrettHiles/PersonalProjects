﻿namespace Menu.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public List<MenuIngredient> MenuIngredients { get; set; }
    }
}
