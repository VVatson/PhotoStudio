using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Views.Interfaces
{
    internal interface IClientView
    {
        void MakeOrder(string data);
        void BreakOrder(Order order);
        OrderStatus CheckOrderStatus(Order order);
    }
}
