using Microsoft.AspNetCore.Mvc;
using AdviserDashboardService.Model;
using AdviserDashboardService.Data.Repositories;

namespace AdviserDashboardService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : AdviserDashboardControllerBase<Customer, CustomerRepository>
    {
        public CustomerController(CustomerRepository repository) : base(repository)
        {
        }
    }
}