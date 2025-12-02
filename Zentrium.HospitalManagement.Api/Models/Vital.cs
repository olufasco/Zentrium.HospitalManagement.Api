namespace Zentrium.HospitalManagement.Api.Models
{
    public class Vital : BaseEntity
    {
        
        public string BloodPressure { get; set; } = string.Empty;
        public string HeartRate { get; set; } = string.Empty;
        public decimal Temperature { get; set; }
        public decimal RespiratoryRate { get; set; }
        public string OxygenSaturation { get; set; } = string.Empty;
        public string MBI { get; set; } = string.Empty;
    }
}
