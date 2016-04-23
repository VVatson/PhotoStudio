using System.Collections.Generic;
using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Views.Interfaces
{
    internal interface IManagerView
    {
        List<Order> GetOrders();
        void SetOrderStatus(Order order, OrderStatus status);
    }
}
