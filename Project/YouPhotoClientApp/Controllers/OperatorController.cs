using System.Collections.Generic;
using YouPhotoClientApp.Controllers.Interfaces;
using YouPhotoClientApp.Model;
using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Controllers
{
    internal class OperatorController : IOperatorController
    {
        IModel Model;

        public OperatorController(IModel model)
        {
            Model = model;
        }

        public List<Order> GetOrders()
        {
            return Model.GetOrders();
        }

        public Order ProcessOrder(Order order)
        {
            return Model.ProcessOrder(order);
        }

        public void SetOrderStatus(Order order, OrderStatus status)
        {
            Model.SetOrderStatus(order, status);
        }
    }
}
