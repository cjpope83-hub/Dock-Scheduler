public class Booking
{
    public string ClientName { get; set; } = "";
    public string ContainerNumber { get; set; } = "";
    public string OccupancyType { get; set; } = "Live";
    public string Status { get; set; } = "Expected";
    public int Dock { get; set; }
    public string Slot { get; set; } = "";
}

