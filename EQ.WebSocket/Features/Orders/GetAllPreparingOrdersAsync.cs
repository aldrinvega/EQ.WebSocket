using EQ.WebSocket.Common;
using EQ.WebSocket.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace EQ.WebSocket.Features.Orders;

[Route("api/orders"), ApiController]
public class GetAllPreparingOrdersAsync : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly TimerControlPreparing _timerControl;
    private readonly IHubContext<OrdersHub> _client;

    public GetAllPreparingOrdersAsync(IHubContext<OrdersHub> client, IMediator mediator, TimerControlPreparing timeControl)
    {
        _client = client;
        _mediator = mediator;
        _timerControl = timeControl;
    }
    [ProducesResponseType(typeof(ICollection<PreparingOrders>), 200)]
    [HttpGet("preparing")]
    public async Task<ICollection<PreparingOrders>> GetAllPreparingOrders()
    {
        var query = new GetAllPreparingOrdersAsyncQuery();
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
                await clientsAll.SendAsync("PreparingOrdersData", ordersData);
            }, 2000);
        }

        return result;
    }
    public class GetAllPreparingOrdersAsyncQuery : IRequest<ICollection<PreparingOrders>> { }

    public class PreparingOrders
    {
        public long Id { get; set; }
        public string phone_number { get; set; }
        public required string Status { get; set; }
        public decimal? TotalAmount { get; set; }
        public string payment_method_title { get; set; }
        public ICollection<PreparingLineItem> line_items { get; set; }
    }

    public class PreparingLineItem
    {
        public required string Name { get; set; }
        public string Quantity { get; set; }
    }
    public class Handler : IRequestHandler<GetAllPreparingOrdersAsyncQuery, ICollection<PreparingOrders>>
    {
        private readonly WpSzikeContext _context;
        public Handler(WpSzikeContext context)
        {
            _context = context;
        }
        public async Task<ICollection<PreparingOrders>> Handle(GetAllPreparingOrdersAsyncQuery request, CancellationToken cancellationToken)
        {

            var orders = await _context.Yv5w6h8fWcOrders
                 .Where(wcOrders => wcOrders.Status == "wc-preaparing")
                 .Select(wcOrders => new
                 {
                     wcOrders,
                     lineItems = (from lineItem in _context.Yv5w6h8fWoocommerceOrderItems
                                  where lineItem.OrderId == wcOrders.Id
                                  join itemMeta in _context.Yv5w6h8fWoocommerceOrderItemmeta on lineItem.OrderItemId equals itemMeta.OrderItemId
                                  where itemMeta.MetaKey == "_qty"
                                  select new PreparingLineItem
                                  {
                                      Name = lineItem.OrderItemName,
                                      Quantity = itemMeta.MetaValue
                                  }).ToList(),
                     phoneNumber = _context.Yv5w6h8fWcOrderAddresses
                            .Where(address => address.OrderId == wcOrders.Id)
                            .Select(address => address.Phone)
                            .FirstOrDefault()
                 })
                 .Select(x => new PreparingOrders
                 {
                     Id = x.wcOrders.Id,
                     phone_number = x.phoneNumber,
                     Status = x.wcOrders.Status == "wc-processing" ? "processing" : "completed",
                     TotalAmount = x.wcOrders.TotalAmount,
                     payment_method_title = x.wcOrders.PaymentMethodTitle,
                     line_items = x.lineItems
                 }).ToListAsync(cancellationToken);

            return orders;
        }

    }
}
