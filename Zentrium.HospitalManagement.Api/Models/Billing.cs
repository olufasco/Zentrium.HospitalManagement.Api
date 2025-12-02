namespace Zentrium.HospitalManagement.Api.Models
{
    public class Billing : BaseEntity
    {
        public Guid PatientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime BillingDate { get; set; }
        public string PaymentStatus { get; set; } = "Pending";
    }
}
