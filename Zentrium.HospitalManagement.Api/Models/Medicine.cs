namespace Zentrium.HospitalManagement.Api.Models
{
    public class Medicine : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string GenericName { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public string BatchNumber { get; set; } = string.Empty;
        public DateTime ExpiryDate { get; set; }
        public int QuantityInStock { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;
        public Guid? PharmacyId { get; set; }
        public Pharmacy? Pharmacy { get; set; }
    }
}