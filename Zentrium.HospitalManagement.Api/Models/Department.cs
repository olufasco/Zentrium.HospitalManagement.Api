namespace Zentrium.HospitalManagement.Api.Models
{
        public class Department : BaseEntity
        {
            public string Name { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public string HeadOfDepartment { get; set; } = string.Empty;
            public string Location { get; set; } = string.Empty;
            public ICollection<Staff> StaffMembers { get; set; } = new List<Staff>();
        }
    
}
