using System;
using System.Collections.Generic;
using YouPhotoClientApp.Controllers.Interfaces;
using YouPhotoClientApp.Model;
using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Controllers
{
    internal class ManagerController : IManagerController
    {
        IModel Model;

        public ManagerController(IModel model)
        {
            Model = model;
        }

        public List<Order> GetOrders()
        {
            return Model.GetOrders();
        }

        public void SetOrderStatus(Order order, OrderStatus status)
        {
            Model.SetOrderStatus(order, order.Status);
        }
    }
}
