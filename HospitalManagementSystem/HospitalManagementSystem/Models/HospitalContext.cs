using System.Configuration;
using System.Data.Entity;

namespace HospitalManagementSystem
{
    public class HospitalContext : DbContext
    {
        public HospitalContext()
            : base(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString)
        {
        }

        public DbSet<Patient> Patients { get; set; }
    }
}