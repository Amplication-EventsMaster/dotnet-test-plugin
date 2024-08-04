namespace DotnetWithPrivatePlugin.APIs.Dtos;

public class OrderUpdateInput
{
    public DateTime? CreatedAt { get; set; }

    public DateTime? Date { get; set; }

    public string? Id { get; set; }

    public string? MyCustomer { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
