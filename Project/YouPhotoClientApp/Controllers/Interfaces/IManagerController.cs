using System.Collections.Generic;
using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Controllers.Interfaces
{
    internal interface IManagerController
    {
        List<Order> GetOrders();
        void SetOrderStatus(Order order, OrderStatus status);
    }
}
