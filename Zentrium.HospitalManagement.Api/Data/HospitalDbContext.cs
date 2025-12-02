using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Zentrium.HospitalManagement.Api.Models;
namespace Zentrium.HospitalManagement.Api.Data
{
    public class HospitalDbContext : IdentityDbContext<User>
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
            : base(options)
        {
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Staff> StaffMembers { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Vital> Vitals { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<LabReport> LabReports { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<HMO> HMOs { get; set; }
        public DbSet<Receptionist> Receptionists { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
    }
}