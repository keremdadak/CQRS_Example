using CQRS.Api.Queries.Response;
using MediatR;

namespace CQRS.Api.Queries.Request
{
    public class GetByIdCustomerQueryRequest:IRequest<GetByIdCustomerQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
