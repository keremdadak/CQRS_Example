namespace CQRS.Api.Commands.Request
{
    public class CreateCustomerCommandRequest
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int PhoneNumber { get; set; }
        public string City { get; set; }

    }
}
