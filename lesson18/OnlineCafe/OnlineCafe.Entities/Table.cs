namespace OnlineCafe.Entities;

public class Table
{
    public long Id { get; set; }
    public int? SeatsCount { get; set; }
    public string? Discription { get; set; }
    public virtual ICollection<Guest>? Guests { get; set; }
}