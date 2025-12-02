using Zentrium.HospitalManagement.Api.Models;

namespace Zentrium.HospitalManagement.Api.Models
{
    public class Hospital : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        public ICollection<Department> Departments { get; set; } = new List<Department>();
        public ICollection<Staff> StaffMembers { get; set; } = new List<Staff>();
        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
        public ICollection<Nurse> Nurses { get; set; } = new List<Nurse>();
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();

    }
}