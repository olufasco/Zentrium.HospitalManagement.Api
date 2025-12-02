namespace Zentrium.HospitalManagement.Api.Models
{
    public class Diagnosis : BaseEntity
    {
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public string Condition { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public DateTime DiagnosisDate { get; set; } = DateTime.UtcNow;
        public string Severity { get; set; } = string.Empty;
        public string TreatmentPlan { get; set; } = string.Empty;
    }
}