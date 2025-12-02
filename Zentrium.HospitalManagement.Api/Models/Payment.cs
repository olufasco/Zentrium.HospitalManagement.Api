namespace Zentrium.HospitalManagement.Api.Models
{
    public class Payment : BaseEntity
    {
        public Guid PatientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public string Method { get; set; } = string.Empty; 
        public string Status { get; set; } = "Pending"; 
        public string ReferenceNumber { get; set; } = string.Empty;
    }
}