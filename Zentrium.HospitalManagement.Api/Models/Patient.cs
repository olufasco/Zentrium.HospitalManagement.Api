namespace Zentrium.HospitalManagement.Api.Models
{
    public class Patient : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;
        public string Gender { get; set; } = string.Empty;
        public string BloodGroup { get; set; } = string.Empty;
        public decimal PhoneNumber { get; set; } = 0;
        public string Address { get; set; } = string.Empty;
        public string MedicalReports { get; set; } = string.Empty;
    }
}
