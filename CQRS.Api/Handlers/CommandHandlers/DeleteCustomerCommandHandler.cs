using CQRS.Api.Commands.Request;
using CQRS.Api.Commands.Response;
using MediatR;

namespace CQRS.Api.Handlers.CommandHandlers
{
    public class DeleteCustomerCommandHandler:IRequestHandler<DeleteCustomerCommandRequest,DeleteCustomerCommandResponse>
    {
        public async Task<DeleteCustomerCommandResponse> Handle(DeleteCustomerCommandRequest request,CancellationToken cancellationToken)
        {
            var deleteProduct = AppDbContext.CustomerList.FirstOrDefault(c => c.Id == request.Id);
            AppDbContext.CustomerList.Remove(deleteProduct);
            return new DeleteCustomerCommandResponse { Success = true };
        }
    }
}
