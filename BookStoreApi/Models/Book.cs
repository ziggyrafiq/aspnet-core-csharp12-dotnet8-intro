using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Models;
public record Book(
    int Id,
    [property: Required]
    [property: StringLength(100)]
    string Title,
    [property: Required]
    [property: StringLength(100)]
    string Author,
    DateTime PublishedDate
);
