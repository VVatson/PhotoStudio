using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Controllers.Interfaces
{
    internal interface IClientController
    {
        void MakeOrder(Order order);
        void BreakOrder(Order order);
        OrderStatus CheckOrderStatus(Order order);
    }
}
