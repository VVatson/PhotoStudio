using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Controllers.Interfaces
{
    internal interface IClientController
    {
        void MakeOrder(string data);
        void BreakOrder(Order order);
        OrderStatus CheckOrderStatus(Order order);
    }
}
