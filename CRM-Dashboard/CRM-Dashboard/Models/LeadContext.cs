using Microsoft.EntityFrameworkCore;


namespace CRM_Dashboard.Models
{
    public class LeadContext: DbContext
    {
        public LeadContext(DbContextOptions<LeadContext> options): base(options)
        {

        }

        public DbSet<Lead> Leads { get; set; }

        public DbSet<CustomerPersonalData> Leads_Customer_PersonalData { get; set; }
    }
}
