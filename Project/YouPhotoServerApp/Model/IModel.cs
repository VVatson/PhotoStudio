namespace YouPhotoServerApp.Model
{
    public interface IModel
    {
        string ProcessRequest(string request);
        
        string Autorize(string[] userData);
        void Register(string[] userData);
        
        void MakeOrder(string[] orderData);
        void BreakOrder(string[] orderData);
        string CheckOrderStatus(string[] orderData);
        void SetOrderStatus(string[] orderData);
        string GetOrders();
        string ProcessOrder(string[] orderData);
    }
}
