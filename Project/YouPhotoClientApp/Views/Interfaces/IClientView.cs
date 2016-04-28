using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Views.Interfaces
{
    internal interface IClientView
    {
        void MakeOrder(Order order);
        void BreakOrder(Order order);
        OrderStatus CheckOrderStatus(Order order);
    }
}
