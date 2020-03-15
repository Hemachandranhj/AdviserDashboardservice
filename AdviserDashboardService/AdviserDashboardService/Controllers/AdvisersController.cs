using Microsoft.AspNetCore.Mvc;
using AdviserDashboardService.Model;
using AdviserDashboardService.Data.Repositories;

namespace AdviserDashboardService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvisersController : AdviserDashboardControllerBase<Adviser, AdviserRepository>
    {
        public AdvisersController(AdviserRepository repository) : base(repository)
        {

        }
    }
}
