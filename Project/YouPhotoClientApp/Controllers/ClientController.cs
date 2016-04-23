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

        public void MakeOrder(string data)
        {
            throw new NotImplementedException();
        }

        public void BreakOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public OrderStatus CheckOrderStatus(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
