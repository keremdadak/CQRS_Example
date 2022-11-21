using CQRS.Api.Queries.Request;
using CQRS.Api.Queries.Response;

namespace CQRS.Api.Handlers.QueryHandlers
{
    public class GetByIdCustomerQueryHandler
    {
        public GetByIdCustomerQueryResponse GetByIdCustomer(GetByIdCustomerQueryRequest getByIdCustomerQueryRequest)
        {
            var customer = AppDbContext.CustomerList.FirstOrDefault(c=>c.Id==getByIdCustomerQueryRequest.Id);
            return new GetByIdCustomerQueryResponse
            {
                Id=customer.Id,
                Name=customer.Name,
                Gender=customer.Gender,
                City=customer.City,
                PhoneNumber=customer.PhoneNumber,
                CreatedDate=customer.CreatedDate
            };
        }
    }
}
