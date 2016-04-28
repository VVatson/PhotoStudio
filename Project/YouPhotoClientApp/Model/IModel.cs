using System.Collections.Generic;
using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Model
{
    public interface IModel
    {
        bool Autorize(string login, string password);
        void Register(string login, string password, UserType userType);
        void LogOut();

        void MakeOrder(Order order);
        void BreakOrder(Order order);
        
        OrderStatus CheckOrderStatus(Order order);
        void SetOrderStatus(Order order, OrderStatus status);
        
        List<Order> GetOrders();
        Order ProcessOrder(Order order);
    }
}
