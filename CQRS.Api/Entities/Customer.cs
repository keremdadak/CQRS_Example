namespace CQRS.Api.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int PhoneNumber { get; set; }
        public string City { get;set; }
        public DateTime CreatedDate { get; set; }
    }
}
