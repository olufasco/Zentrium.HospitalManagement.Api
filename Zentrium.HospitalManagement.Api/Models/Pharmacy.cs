namespace Zentrium.HospitalManagement.Api.Models
{
    public class Pharmacy : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public ICollection<Medicine> Medicines { get; set; } = new List<Medicine>();
        public ICollection<Staff> StaffMembers { get; set; } = new List<Staff>();
    }
}