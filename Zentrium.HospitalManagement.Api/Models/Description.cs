namespace Zentrium.HospitalManagement.Api.Models
{
    public class Description : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
    }
}