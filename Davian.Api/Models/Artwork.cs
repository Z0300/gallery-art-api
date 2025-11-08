using System.ComponentModel.DataAnnotations;

namespace Davian.Api.Models;

public class Artwork
{
    public Guid Id { get; init; }
    [Required, MaxLength(255)]
    public required string Title { get; set; }
    [Required, MaxLength(255)]
    public required string ImageUrl { get; set; }
    [MaxLength(1000)]
    public  string? Description { get; set; }
    [MaxLength(255)]
    public string? Medium { get; set; }
    [MaxLength(255)]
    public string? Dimensions { get; set; }
    public int? YearCreated { get; set; }

    public Guid? CollectionId { get; set; }
    public Collection? Collection { get; set; }
    
    public DateTime DateCreated { get; init; } = DateTime.UtcNow;
    public DateTime? DateModified { get; set; }
}