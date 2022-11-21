using CQRS.Api.Entities;

namespace CQRS.Api
{
    public class AppDbContext
    {
        static List<Customer> customerList = new List<Customer> {
         new() { Id = Guid.NewGuid(), Name = "Customer 1", Gender ="Male", PhoneNumber=1234567, City="Istanbul", CreatedDate = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Customer 2", Gender ="Female", PhoneNumber=44444554, City="Bursa", CreatedDate = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Customer 3", Gender ="Male", PhoneNumber=33333333, City="Samsun", CreatedDate = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Customer 4", Gender ="Female", PhoneNumber=22222222, City="Ankara", CreatedDate = DateTime.Now },

        };
        public static List<Customer> CustomerList => customerList;
    }
}
