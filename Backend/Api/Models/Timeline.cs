using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models;

public record Timeline
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; init; }
    public DateTimeOffset Start { get; init; }
    public DateTimeOffset End { get; init; }
    public string? Note { get; init; }
}