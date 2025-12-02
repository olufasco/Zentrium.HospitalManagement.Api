using Zentrum.HospitalManagement.Api.Models;

namespace Zentrium.HospitalManagement.Api.Models
{
    public class Ward : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int Capacity { get; set; } 
        public ICollection<Bed> Beds { get; set; } = new List<Bed>();
    }
}