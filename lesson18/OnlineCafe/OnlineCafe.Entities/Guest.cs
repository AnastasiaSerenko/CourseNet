namespace OnlineCafe.Entities;

public class Guest
{
    public long Id { get; set; }
    public long TableId { get; set; }
    public virtual ICollection<Order>? Orders { get; set; }
}

