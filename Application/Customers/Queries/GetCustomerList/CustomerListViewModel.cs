using System.Collections.Generic;

namespace Application.Customers.Queries.GetCustomerList
{
    public class CustomerListViewModel
    {
        public IList<CustomerModel> Customers { get; set; }
    }
}