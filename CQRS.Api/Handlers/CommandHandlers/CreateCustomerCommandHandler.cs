using CQRS.Api.Commands.Request;
using CQRS.Api.Commands.Response;

namespace CQRS.Api.Handlers.CommandHandlers
{
    public class CreateCustomerCommandHandler
    {
        public CreateCustomerCommandResponse CreateProduct(CreateCustomerCommandRequest createCustomerCommandRequest)
        {
            var id = Guid.NewGuid();
            AppDbContext.CustomerList.Add(new()
            {
                Id=id,
                Name=createCustomerCommandRequest.Name,
                Gender=createCustomerCommandRequest.Gender,
                PhoneNumber=createCustomerCommandRequest.PhoneNumber,
                City=createCustomerCommandRequest.City,
                CreatedDate=DateTime.Now
            });
            return new CreateCustomerCommandResponse
            {
                Success = true,
                Id = id
            };
        }
    }
}
