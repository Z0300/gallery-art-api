using System.ComponentModel.DataAnnotations;

namespace Davian.Api.Models;

public class Collection
{
    public Guid Id { get; init; }
    [Required, MaxLength(255)]
    public required string Name { get; set; }
    [MaxLength(255)]
    public string? Description { get; set; }
    [MaxLength(255)]
    public string? CoverImageUrl { get; set; }
    
    public ICollection<Artwork> Artworks { get; init; } = new List<Artwork>();
}