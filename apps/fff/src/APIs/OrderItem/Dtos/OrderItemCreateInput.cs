namespace Fff.APIs.Dtos;

public class OrderItemCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public Order? Order { get; set; }

    public int? Quantity { get; set; }

    public double? TotalPrice { get; set; }

    public double? UnitPrice { get; set; }

    public DateTime UpdatedAt { get; set; }
}
