namespace AgriTech1.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Manufacturer { get; set; }
        public string ModelNumber { get; set; }
        public bool IsOperational { get; set; }
        // Additional properties can be added as needed
    }
}
