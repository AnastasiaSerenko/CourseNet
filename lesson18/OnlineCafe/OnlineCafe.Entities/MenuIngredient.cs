namespace OnlineCafe.Entities;

public class MenuIngredient
{
    public long MenuId { get; set; }
    public virtual Menu? MenuItem { get; set; }

    public long IngredientId { get; set; }
    public virtual Ingredient? Ingredient { get; set; }
}
