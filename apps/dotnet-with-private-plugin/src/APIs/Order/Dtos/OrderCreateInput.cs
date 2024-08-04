namespace DotnetWithPrivatePlugin.APIs.Dtos;

public class OrderCreateInput
{
    public DateTime CreatedAt { get; set; }

    public DateTime? Date { get; set; }

    public string? Id { get; set; }

    public Customer? MyCustomer { get; set; }

    public DateTime UpdatedAt { get; set; }
}
