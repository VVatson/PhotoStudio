using System.Collections.Generic;
using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Views.Interfaces
{
    internal interface IOperatorView
    {
        List<Order> GetOrders();
        Order ProcessOrder(Order order);
        void SetOrderStatus(Order order, OrderStatus status);
    }
}
