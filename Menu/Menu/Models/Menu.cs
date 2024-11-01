namespace Menu.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        
        public List<MenuIngredient> MenuIngredients { get; set; }
    }
}
