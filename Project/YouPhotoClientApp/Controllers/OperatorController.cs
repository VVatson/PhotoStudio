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
            throw new System.NotImplementedException();
        }

        public Order ProcessOrder(Order order)
        {
            throw new System.NotImplementedException();
        }

        public void SetOrderStatus(Order order, OrderStatus status)
        {
            throw new System.NotImplementedException();
        }
    }
}
