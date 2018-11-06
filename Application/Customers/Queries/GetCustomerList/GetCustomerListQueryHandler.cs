using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Customers.Queries.GetCustomerList
{
    public class GetCustomerListQueryHandler : IRequestHandler<GetCustomerListQuery, CustomerListViewModel>
    {
        private readonly MyDbContext context;

        public GetCustomerListQueryHandler(MyDbContext context)
        {
            this.context = context;
        }

        public async Task<CustomerListViewModel> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
        {
            var customers = await context.Customers.Select(c => new CustomerModel
            {
                Id = c.Id.ToString(),
                Name = c.FirstName + " " + c.LastName
            }).ToListAsync(cancellationToken);

            return new CustomerListViewModel() { Customers = customers };
        }
    }
}