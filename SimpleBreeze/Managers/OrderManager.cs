using Breeze.Persistence.EFCore;
using SimpleBreeze.Data;

namespace SimpleBreeze.Managers
{
    public class OrderManager : EFPersistenceManager<OrderContext>
    {
        public OrderManager(OrderContext orderContext) : base(orderContext) { }
    }
}
