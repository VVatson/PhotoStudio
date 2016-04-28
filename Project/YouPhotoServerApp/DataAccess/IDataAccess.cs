using System.Collections.Generic;
using YouPhotoServerApp.Structures;

namespace YouPhotoServerApp.DataAccess
{
    internal interface IDataAccess
    {
        bool IsUserInBase(User user);
        void Register(User user);

        void MakeOrder(Order order);
        void BreakOrder(Order order);
        Status CheckOrderStatus(Order order);
        void SetOrderStatus(Order order, Status status);
        List<Order> GetOrders();
        Order ProcessOrder(Order order);
    }
}
