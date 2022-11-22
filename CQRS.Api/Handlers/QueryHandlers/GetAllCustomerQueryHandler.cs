using CQRS.Api.Queries.Request;
using CQRS.Api.Queries.Response;
using MediatR;

namespace CQRS.Api.Handlers.QueryHandlers
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQueryRequest, List<GetAllCustomerQueryResponse>>
    {
        public async Task<List<GetAllCustomerQueryResponse>> Handle(GetAllCustomerQueryRequest request,CancellationToken cancellationToken)
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
