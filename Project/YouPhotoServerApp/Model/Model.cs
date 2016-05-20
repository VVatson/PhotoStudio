using System;
using System.Linq;
using YouPhotoServerApp.Structures;

namespace YouPhotoServerApp.Model
{
    public class Model : IModel
    {
        private readonly DataAccess.DataAccess _dataAccess;

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

        public Model()
        {
            _dataAccess = new DataAccess.DataAccess();
        }

        public string ProcessRequest(string request)
        {
            var requestData = request.Split(new[] {";"}, StringSplitOptions.None);
            var command = (ServerCommands)Enum.Parse(typeof(ServerCommands), requestData[0]);
            var answer = "ok";
            switch (command)
            {
                case ServerCommands.Autorize:
                    answer = Autorize(requestData);
                    break;
                case ServerCommands.Register:
                    Register(requestData);
                    break;
                case ServerCommands.MakeOrder:
                    MakeOrder(requestData);
                    break;
                case ServerCommands.BreakOrder:
                    BreakOrder(requestData);
                    break;
                case ServerCommands.CheckOrderStatus:
                    answer = CheckOrderStatus(requestData);
                    break;
                case ServerCommands.SetOrderStatus:
                    SetOrderStatus(requestData);
                    break;
                case ServerCommands.GetOrders:
                    answer = GetOrders();
                    break;
                case ServerCommands.ProcessOrder:
                    answer = ProcessOrder(requestData);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return answer;
        }

        public string Autorize(string [] userData)
        {
            var user = new User(userData[1], userData[2]);
            return _dataAccess.IsUserInBase(user) ? "true" : "false";
        }

        public void Register(string[] userData)
        {
            var user = new User(userData[1], userData[2], (UserType)Enum.Parse(typeof(UserType), userData[3]));
            _dataAccess.Register(user);
        }

        public void MakeOrder(string[] orderData)
        {
            var order = new Order(orderData[1]);
            _dataAccess.MakeOrder(order);
        }

        public void BreakOrder(string[] orderData)
        {
            var order = new Order(orderData[1]);
            _dataAccess.BreakOrder(order);
        }

        public string CheckOrderStatus(string[] orderData)
        {
            var order = new Order(orderData[1]);
            return _dataAccess.CheckOrderStatus(order).ToString();
        }

        public void SetOrderStatus(string[] orderData)
        {
            var order = new Order(orderData[1]);
            var status = (Status) Enum.Parse(typeof(Status), orderData[2]);
            _dataAccess.SetOrderStatus(order, status);
        }

        public string GetOrders()
        {
            var orders = _dataAccess.GetOrders();
            return string.Join(";", orders.Select(order => order.ToString()).ToArray());
        }

        public string ProcessOrder(string[] orderData)
        {
            var order = new Order(orderData[1]);
            return _dataAccess.ProcessOrder(order).ToString();
        }

    }
}
