using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Dtos;

public record class GameSummaryDto(
    [Required] int Id, 
    [Required] [StringLength(50)] string Name, 
    [Required] [StringLength(20)] string Genre, 
    [Required] [Range(1, 100)]decimal Price, 
    [Required] DateOnly ReleaseDate
);
