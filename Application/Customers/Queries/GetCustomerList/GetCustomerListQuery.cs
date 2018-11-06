using MediatR;

namespace Application.Customers.Queries.GetCustomerList
{
    public class GetCustomerListQuery : IRequest<CustomerListViewModel>
    {
    }
}