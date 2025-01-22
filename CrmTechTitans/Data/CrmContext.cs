using CrmTechTitans.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM.Data
{
    public class CrmContext : DbContext
    {
        public CrmContext(DbContextOptions<CrmContext> options)
            : base(options)
        {
        }
        public DbSet<Company> Companies { get; set; }
    }
    
    
}
