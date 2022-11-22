using CQRS.Api.Commands.Response;
using MediatR;

namespace CQRS.Api.Commands.Request
{
    public class DeleteCustomerCommandRequest: IRequest<DeleteCustomerCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
