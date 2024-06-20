using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EQ.WebSocket.Domain;
using EQ.WebSocket.Common;
using Microsoft.AspNetCore.SignalR;

namespace EQ.WebSocket.Features.Orders;

[Route("api/orders"), ApiController]
public class GetAllOrdersAsync : ControllerBase
{           
    private readonly IMediator _mediator;
    private readonly TimerControl _timerControl;
    private readonly IHubContext<OrdersHub> _client;

    public GetAllOrdersAsync(IHubContext<OrdersHub> client, IMediator mediator, TimerControl timeControl)
    {
        _client = client;
        _mediator = mediator;
        _timerControl = timeControl;
    }
    [ProducesResponseType(typeof(ICollection<Orders>), 200)]
    [HttpGet]
    public async Task<ICollection<Orders>> GetAllOrders()
    {
        var query = new GetAllOrderAsyncQuery();
        var result = await _mediator.Send(query);

        var timerControl = _timerControl;
        var clientsAll = _client.Clients.All;

        if (timerControl != null && !timerControl.IsTimerStarted && clientsAll != null)
        {
            timerControl.ScheduleTimer(async (scopeFactory) =>
            {
                using var scope = scopeFactory.CreateScope();
                var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();
                var ordersData = await mediator.Send(query);
                await clientsAll.SendAsync("ServingOrdersData", ordersData);
            }, 2000);
        }

        return result;
    }
    public class GetAllOrderAsyncQuery : IRequest<ICollection<Orders>> { }

        public class Orders
        {
            public long Id { get; set; }
            public string phone_number { get; set; }
            public required string Status { get; set; }
            public decimal? TotalAmount { get; set; }
            public string payment_method_title { get; set; }
            public ICollection<LineItem> line_items { get; set; }
        }

        public class LineItem
        {
            public required string Name { get; set; }
            public string Quantity { get; set; }
        }
        public class Handler : IRequestHandler<GetAllOrderAsyncQuery, ICollection<Orders>>
        {
            private readonly WpSzikeContext _context;
            public Handler(WpSzikeContext context)
            {
                _context = context;
            }
            public async Task<ICollection<Orders>> Handle(GetAllOrderAsyncQuery request, CancellationToken cancellationToken)
            {

                var orders = await _context.Yv5w6h8fWcOrders
                     .Where(wcOrders => wcOrders.Status == "wc-serving")
                     .Select(wcOrders => new
                     {
                         wcOrders,
                         lineItems = (from lineItem in _context.Yv5w6h8fWoocommerceOrderItems
                                      where lineItem.OrderId == wcOrders.Id
                                      join itemMeta in _context.Yv5w6h8fWoocommerceOrderItemmeta on lineItem.OrderItemId equals itemMeta.OrderItemId
                                      where itemMeta.MetaKey == "_qty"
                                      select new LineItem
                                      {
                                          Name = lineItem.OrderItemName,
                                          Quantity = itemMeta.MetaValue
                                      }).ToList(),
                         phoneNumber = _context.Yv5w6h8fWcOrderAddresses
                                .Where(address => address.OrderId == wcOrders.Id)
                                .Select(address => address.Phone)
                                .FirstOrDefault()
                     })
                     .Select(x => new Orders
                     {
                         Id = x.wcOrders.Id,
                         phone_number = x.phoneNumber,
                         Status = x.wcOrders.Status == "wc-processing" ? "processing" : "completed",
                         TotalAmount = x.wcOrders.TotalAmount,
                         payment_method_title = x.wcOrders.PaymentMethodTitle,
                         line_items = x.lineItems
                     })
                     .ToListAsync(cancellationToken);

                return orders;
            }

        }
}
