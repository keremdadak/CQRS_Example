using CQRS.Api.Commands.Request;
using CQRS.Api.Commands.Response;

namespace CQRS.Api.Handlers.CommandHandlers
{
    public class DeleteCustomerCommandHandler
    {
        public DeleteCustomerCommandResponse DeleteProduct(DeleteCustomerCommandRequest deleteCustomerCommandRequest)
        {
            var deleteProduct = AppDbContext.CustomerList.FirstOrDefault(c => c.Id == deleteCustomerCommandRequest.Id);
            AppDbContext.CustomerList.Remove(deleteProduct);
            return new DeleteCustomerCommandResponse { Success = true };
        }
    }
}
