namespace Zentrium.HospitalManagement.Api.Models
{
    public class Staff : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;   // e.g. Admin, Technician, Cleaner, etc.
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public DateTime HireDate { get; set; } = DateTime.UtcNow;
    }
}