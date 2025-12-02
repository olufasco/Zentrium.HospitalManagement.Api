namespace Zentrium.HospitalManagement.Api.Models
{
    public class Visit : BaseEntity
    {
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime VisitDate { get; set; } = DateTime.UtcNow;
        public string Reason { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public bool IsFollowUpRequired { get; set; } = false;
    }
}