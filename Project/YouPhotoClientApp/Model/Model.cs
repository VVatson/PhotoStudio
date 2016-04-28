using System;
using System.Collections.Generic;
using YouPhotoClientApp.Connection;
using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Model
{
    public class Model :IModel
    {
        private Connector connector;

        public bool Autorize(string login, string password)
        {
            throw new NotImplementedException();
        }

        public void Register(string login, string password, UserType userType)
        {
            throw new NotImplementedException();
        }

        public void MakeOrder(Order order)
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

        public void SetOrderStatus(Order order, OrderStatus status)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Order ProcessOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
