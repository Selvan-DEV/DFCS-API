using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_Dashboard.Models
{
    public class LeadContext: DbContext
    {
        public LeadContext(DbContextOptions<LeadContext> options): base(options)
        {

        }

        public DbSet<Lead> Leads { get; set; }
    }
}
