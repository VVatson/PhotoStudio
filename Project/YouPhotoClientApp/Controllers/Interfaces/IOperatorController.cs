using System.Collections.Generic;
using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Controllers.Interfaces
{
    internal interface IOperatorController
    {
        List<Order> GetOrders();
        Order ProcessOrder(Order order);
        void SetOrderStatus(Order order, OrderStatus status);
    }
}
