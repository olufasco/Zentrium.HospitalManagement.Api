namespace Zentrium.HospitalManagement.Api.Models
{
    public class Receptionist : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime HireDate { get; set; } = DateTime.UtcNow;
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<Patient> RegisteredPatients { get; set; } = new List<Patient>();
    }
}