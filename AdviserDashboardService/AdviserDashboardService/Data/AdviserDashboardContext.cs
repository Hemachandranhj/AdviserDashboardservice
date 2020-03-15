using Microsoft.EntityFrameworkCore;
using AdviserDashboardService.Model;

namespace AdviserDashboardService.Data
{
    public class AdviserDashboardContext : DbContext
    {
        public AdviserDashboardContext (DbContextOptions<AdviserDashboardContext> options)
            : base(options)
        {
            Database.EnsureCreated();            
        }

        public DbSet<Adviser> Adviser { get; set; }
        
        public DbSet<Customer> Customer { get; set; }
    }
}
