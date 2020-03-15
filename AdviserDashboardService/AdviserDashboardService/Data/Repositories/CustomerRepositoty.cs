using AdviserDashboardService.Model;

namespace AdviserDashboardService.Data.Repositories
{
    public class CustomerRepository : Repository<Customer, AdviserDashboardContext>
    {
        public CustomerRepository(AdviserDashboardContext context) : base(context)
        {

        }
    }
}
