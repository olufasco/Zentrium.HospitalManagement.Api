namespace Zentrium.HospitalManagement.Api.Models
{
    public class HMO : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string ContactPerson { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}