using CQRS.Api.Queries.Response;
using MediatR;

namespace CQRS.Api.Queries.Request
{
    public class GetAllCustomerQueryRequest:IRequest<List<GetAllCustomerQueryResponse>>
    {
    }
}
