namespace OnlineCafe.Entities;

public class Menu
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public long Price { get; set; }
    public virtual ICollection<MenuIngredient>? MenuIngredient { get; set; }
}
