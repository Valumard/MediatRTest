using Application.Customers.Queries.GetCustomerList;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatrTest.Controllers
{
    public class CustomerController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<CustomerListViewModel>> GetAll()
        {
            return Ok(await this.Mediator.Send(new GetCustomerListQuery()));
        }
    }
}