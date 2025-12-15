using Learning.OrderService.Application.Commands;
using Learning.OrderService.Application.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Learning.OrderService.API.Controllers
{
    [ApiController]
    [Route("api/v1/orders")]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderDto request)
        {
            var command = new CreateOrderCommand(request.CustomerId, request.OrderItems, request.Method);
            var newlyAddedOrderId = await _mediator.Send(command);
            return CreatedAtAction(nameof(CreateOrder), new { id = newlyAddedOrderId }, newlyAddedOrderId);
        }
    }
}
