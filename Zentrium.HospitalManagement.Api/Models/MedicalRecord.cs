namespace Zentrium.HospitalManagement.Api.Models
{
        public class MedicalRecord : BaseEntity
        {
            public Guid PatientId { get; set; } = Guid.NewGuid();
            public string Diagnosis { get; set; } = string.Empty;
            public string Treatment { get; set; } = string.Empty;
            public DateTime RecordDate { get; set; } = DateTime.UtcNow;
        }
}
