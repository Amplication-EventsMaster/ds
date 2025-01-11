using Fff.Core.Enums;

namespace Fff.APIs.Dtos;

public class OrderUpdateInput
{
    public DateTime? CreatedAt { get; set; }

    public string? Customer { get; set; }

    public string? Id { get; set; }

    public DateTime? OrderDate { get; set; }

    public List<string>? OrderItems { get; set; }

    public string? OrderNumber { get; set; }

    public StatusEnum? Status { get; set; }

    public double? TotalAmount { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
