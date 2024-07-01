namespace Bookify.Domain.Apartments;

public record Address(
    string Country,
    string Region,
    string ZipCode,
    string City,
    string Street);