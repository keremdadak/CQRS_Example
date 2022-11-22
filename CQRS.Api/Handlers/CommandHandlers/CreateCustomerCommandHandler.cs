using CQRS.Api.Commands.Request;
using CQRS.Api.Commands.Response;
using MediatR;

namespace CQRS.Api.Handlers.CommandHandlers
{
    public class CreateCustomerCommandHandler:IRequestHandler<CreateCustomerCommandRequest,CreateCustomerCommandResponse>
    {
        public async Task<CreateCustomerCommandResponse> Handle(CreateCustomerCommandRequest request,CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            AppDbContext.CustomerList.Add(new()
            {
                Id=id,
                Name= request.Name,
                Gender= request.Gender,
                PhoneNumber= request.PhoneNumber,
                City= request.City,
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
