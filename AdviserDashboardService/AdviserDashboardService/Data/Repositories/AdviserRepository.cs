using AdviserDashboardService.Model;

namespace AdviserDashboardService.Data.Repositories
{
    public class AdviserRepository : Repository<Adviser, AdviserDashboardContext>
    {
        public AdviserRepository(AdviserDashboardContext context) : base(context)
        {

        }
    }
}
