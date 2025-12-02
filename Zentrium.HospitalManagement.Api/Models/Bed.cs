using Zentrium.HospitalManagement.Api.Models;
namespace Zentrium.HospitalManagement.Api.Models
    {
        public class Bed : BaseEntity
        {
            public string BedNumber { get; set; } = string.Empty;
            public string Ward { get; set; } = string.Empty;
            public string Room { get; set; } = string.Empty;
            public bool IsOccupied { get; set; } = false;
            public Guid? PatientId { get; set; }   // Nullable if bed is free
            public DateTime? AssignedDate { get; set; }
        }
    }
