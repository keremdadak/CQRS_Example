using CQRS.Api.Queries.Request;
using CQRS.Api.Queries.Response;
using MediatR;

namespace CQRS.Api.Handlers.QueryHandlers
{
    public class GetByIdCustomerQueryHandler:IRequestHandler<GetByIdCustomerQueryRequest,GetByIdCustomerQueryResponse>
    {
        public async Task<GetByIdCustomerQueryResponse> Handle(GetByIdCustomerQueryRequest request,CancellationToken cancellationToken)
        {
            var customer = AppDbContext.CustomerList.FirstOrDefault(c=>c.Id== request.Id);
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
