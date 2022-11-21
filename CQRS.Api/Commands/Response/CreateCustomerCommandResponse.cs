namespace CQRS.Api.Commands.Response
{
    public class CreateCustomerCommandResponse
    {
        public bool Success { get; set; }
        public Guid Id { get; set; }
    }
}
