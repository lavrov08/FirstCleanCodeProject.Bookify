namespace Bookify.Domain.Apartments;

public record class Adress(
    string Country,
    string Region,
    string ZipCode, 
    string City,
    string Street 
);
