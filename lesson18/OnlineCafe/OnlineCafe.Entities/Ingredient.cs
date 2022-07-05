namespace OnlineCafe.Entities;

public class Ingredient
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public long? Caloric { get; set; }
    public virtual ICollection<MenuIngredient>? MenuIngredient { get; set; }
}
