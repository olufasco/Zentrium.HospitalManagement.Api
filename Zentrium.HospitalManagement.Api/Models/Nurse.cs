namespace Zentrium.HospitalManagement.Api.Models
{
    public class Nurse : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Ward { get; set; } = string.Empty;
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}