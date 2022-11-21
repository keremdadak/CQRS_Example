using CQRS.Api.Queries.Request;
using CQRS.Api.Queries.Response;

namespace CQRS.Api.Handlers.QueryHandlers
{
    public class GetAllCustomerQueryHandler
    {
        public List<GetAllCustomerQueryResponse> GetAllCustomer(GetAllCustomerQueryRequest getAllCustomerQueryRequest)
        {
            return AppDbContext.CustomerList.Select(customer => new GetAllCustomerQueryResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                City = customer.City,
                Gender = customer.Gender,
                PhoneNumber = customer.PhoneNumber,
                CreatedDate=customer.CreatedDate,
            }).ToList();
        }
    }
}
