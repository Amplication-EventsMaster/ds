namespace Fff.APIs.Dtos;

public class OrderItemUpdateInput
{
    public DateTime? CreatedAt { get; set; }

    public string? Id { get; set; }

    public string? Order { get; set; }

    public int? Quantity { get; set; }

    public double? TotalPrice { get; set; }

    public double? UnitPrice { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
