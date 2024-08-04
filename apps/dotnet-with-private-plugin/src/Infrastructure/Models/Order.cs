using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetWithPrivatePlugin.Infrastructure.Models;

[Table("Orders")]
public class OrderDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? Date { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    public string? MyCustomerId { get; set; }

    [ForeignKey(nameof(MyCustomerId))]
    public CustomerDbModel? MyCustomer { get; set; } = null;

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
