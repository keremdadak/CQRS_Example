using CQRS.Api.Commands.Request;
using CQRS.Api.Commands.Response;
using CQRS.Api.Queries.Request;
using CQRS.Api.Queries.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace CQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        #region MediatR olmasaydı böyle inject etmek zorunda kalacaktık.
        //CreateCustomerCommandHandler _createCustomerCommandHandler;
        //DeleteCustomerCommandHandler _deleteCustomerCommandHandler;
        //GetAllCustomerQueryHandler _getAllCustomerQueryHandler;
        //GetByIdCustomerQueryHandler _getByIdCustomerQueryHandler;

        //public CustomerController(CreateCustomerCommandHandler createCustomerCommandHandler, DeleteCustomerCommandHandler deleteCustomerCommandHandler, GetAllCustomerQueryHandler getAllCustomerQueryHandler, GetByIdCustomerQueryHandler getByIdCustomerQueryHandler)
        //{
        //    _createCustomerCommandHandler = createCustomerCommandHandler;
        //    _deleteCustomerCommandHandler = deleteCustomerCommandHandler;
        //    _getAllCustomerQueryHandler = getAllCustomerQueryHandler;
        //    _getByIdCustomerQueryHandler = getByIdCustomerQueryHandler;
        //}
        #endregion

        IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllCustomerQueryRequest requestModel)
        {
            List<GetAllCustomerQueryResponse> allCustomers = await _mediator.Send(requestModel);
            return Ok(allCustomers);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromQuery] GetByIdCustomerQueryRequest requestModel)
        {
            GetByIdCustomerQueryResponse customer = await _mediator.Send(requestModel);
            return Ok(customer);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCustomerCommandRequest requestModel)
        {
            CreateCustomerCommandResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] DeleteCustomerCommandRequest requestModel)
        {
            DeleteCustomerCommandResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}
