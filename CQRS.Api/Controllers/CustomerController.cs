using CQRS.Api.Commands.Request;
using CQRS.Api.Commands.Response;
using CQRS.Api.Handlers.CommandHandlers;
using CQRS.Api.Handlers.QueryHandlers;
using CQRS.Api.Queries.Request;
using CQRS.Api.Queries.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CreateCustomerCommandHandler _createCustomerCommandHandler;
        DeleteCustomerCommandHandler _deleteCustomerCommandHandler;
        GetAllCustomerQueryHandler _getAllCustomerQueryHandler;
        GetByIdCustomerQueryHandler _getByIdCustomerQueryHandler;

        public CustomerController(CreateCustomerCommandHandler createCustomerCommandHandler, DeleteCustomerCommandHandler deleteCustomerCommandHandler, GetAllCustomerQueryHandler getAllCustomerQueryHandler, GetByIdCustomerQueryHandler getByIdCustomerQueryHandler)
        {
            _createCustomerCommandHandler = createCustomerCommandHandler;
            _deleteCustomerCommandHandler = deleteCustomerCommandHandler;
            _getAllCustomerQueryHandler = getAllCustomerQueryHandler;
            _getByIdCustomerQueryHandler = getByIdCustomerQueryHandler;
        }
        [HttpGet]
        public IActionResult Get([FromQuery] GetAllCustomerQueryRequest requestModel)
        {
            List<GetAllCustomerQueryResponse> allCustomers = _getAllCustomerQueryHandler.GetAllCustomer(requestModel);
            return Ok(allCustomers);
        }
        [HttpGet("{id}")]
        public IActionResult Get([FromQuery] GetByIdCustomerQueryRequest requestModel)
        {
            GetByIdCustomerQueryResponse customer = _getByIdCustomerQueryHandler.GetByIdCustomer(requestModel);
            return Ok(customer);
        }
        [HttpPost]
        public IActionResult Post([FromBody] CreateCustomerCommandRequest requestModel)
        {
            CreateCustomerCommandResponse response = _createCustomerCommandHandler.CreateProduct(requestModel);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromQuery] DeleteCustomerCommandRequest requestModel)
        {
            DeleteCustomerCommandResponse response = _deleteCustomerCommandHandler.DeleteProduct(requestModel);
            return Ok(response);
        }
    }
}
