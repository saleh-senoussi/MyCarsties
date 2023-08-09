namespace AcutionService.Entities;

public class Item
{
    public Guid Id { get; set; }
    public String Make { get; set; }
    public String Model { get; set; }
    public int Year { get; set; }
    public String Color { get; set; }
    public int Mileage { get; set; }
    public String ImageUrl { get; set; }

    // nav properties
    public Auction Auction { get; set; }
    public Guid AuctionId { get; set; }
}