using System;
using System.Collections.Generic;
using System.Linq;
using YouPhotoClientApp.Connection;
using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Model
{
    public class Model :IModel
    {
        private readonly Connector _connector;

        private enum ServerCommands
        {
            Autorize,
            Register,
            MakeOrder,
            BreakOrder,
            CheckOrderStatus,
            SetOrderStatus,
            GetOrders,
            ProcessOrder
        }

        public Model(Connector connector)
        {
            _connector = connector;
        }

        private static string CreateRequest(params string[] parts)
        {
            return string.Join(";", parts);
        }

        public bool Autorize(string login, string password)
        {
            _connector.ConnectToServer();
            var request = CreateRequest(ServerCommands.Autorize.ToString(), login, password);
            var answer = _connector.RequestToServer(request);
            return answer == "true";
        }

        public void Register(string login, string password, UserType userType)
        {
            _connector.ConnectToServer();
            var request = CreateRequest(ServerCommands.Register.ToString(), login, password, userType.ToString());
            _connector.RequestToServer(request);
        }

        public void LogOut()
        {
            _connector.CloseConnection();
        }

        public void MakeOrder(Order order)
        {
            var request = CreateRequest(ServerCommands.MakeOrder.ToString(), order.ToString());
            _connector.RequestToServer(request);
        }

        public void BreakOrder(Order order)
        {
            var request = CreateRequest(ServerCommands.BreakOrder.ToString(), order.ToString());
            _connector.RequestToServer(request);
        }

        public OrderStatus CheckOrderStatus(Order order)
        {
            var request = CreateRequest(ServerCommands.CheckOrderStatus.ToString(), order.ToString());
            var answer = _connector.RequestToServer(request);
            return (OrderStatus) Enum.Parse(typeof (OrderStatus), answer);
        }

        public void SetOrderStatus(Order order, OrderStatus status)
        {
            var request = CreateRequest(ServerCommands.SetOrderStatus.ToString(), order.ToString(), status.ToString());
            _connector.RequestToServer(request);
        }

        public List<Order> GetOrders()
        {
            var request = CreateRequest(ServerCommands.GetOrders.ToString());
            var answer = _connector.RequestToServer(request);
            var split = answer.Split(new[] { ";" }, StringSplitOptions.None);
            return split.Select(orderString => new Order(orderString)).ToList();
        }

        public Order ProcessOrder(Order order)
        {
            var request = CreateRequest(ServerCommands.ProcessOrder.ToString(), order.ToString());
            var answer = _connector.RequestToServer(request);
            return new Order(answer);
        }
    }
}
