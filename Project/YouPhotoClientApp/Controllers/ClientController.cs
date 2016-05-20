using System;
using YouPhotoClientApp.Controllers.Interfaces;
using YouPhotoClientApp.Model;
using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Controllers
{
    internal class ClientController : IClientController
    {
        IModel Model;

        public ClientController(IModel model)
        {
            Model = model;
        }

        public void MakeOrder(Order order)
        {
            Model.MakeOrder(order);
        }

        public void BreakOrder(Order order)
        {
            Model.BreakOrder(order);
        }

        public OrderStatus CheckOrderStatus(Order order)
        {
            return Model.CheckOrderStatus(order);
        }
    }
}
