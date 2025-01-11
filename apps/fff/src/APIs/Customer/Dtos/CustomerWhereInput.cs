namespace Fff.APIs.Dtos;

public class CustomerWhereInput
{
    public string? Address { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? Id { get; set; }

    public bool? IsActive { get; set; }

    public string? LastName { get; set; }

    public List<string>? Orders { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
