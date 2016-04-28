namespace YouPhotoClientApp.Structures
{
    public enum OrderStatus
    {
        InProcess,
        Ready,
        Undefined
    }

    public class Order
    {
        public string Data { get; set; } // instead photos to print, I think it's easier
        public int Id { get; set; }
        OrderStatus Status { get; set; }
    }
}
