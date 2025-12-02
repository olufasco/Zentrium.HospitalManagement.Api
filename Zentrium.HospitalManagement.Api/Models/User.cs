using Microsoft.AspNetCore.Identity;
namespace Zentrium.HospitalManagement.Api.Models
{ 
    public class User : IdentityUser
            {
                public string FullName { get; set; } = string.Empty;
                public string Role { get; set; } = string.Empty;
                public bool IsActive { get; set; } = true;
                public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
                public DateTime? LastLogin { get; set; }
            }
}
