namespace Zentrium.HospitalManagement.Api.Models
{
    public class LabReport : BaseEntity
    {
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public string TestName { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public DateTime ReportDate { get; set; } = DateTime.UtcNow;
        public bool IsAbnormal { get; set; } = false;
    }
}