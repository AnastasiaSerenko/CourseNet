namespace OnlineCafe.Entities;

public  class Order
{
    public long Id { get; set; }
    public long GuestId { get; set; }
    public long MenuId { get; set; }
    public virtual Menu? MenuItem { get; set; }
}
