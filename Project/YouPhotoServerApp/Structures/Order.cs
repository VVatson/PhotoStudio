namespace YouPhotoServerApp.Structures
{
    public enum Status
    {
        InProcess,
        Ready,
        Undefined
    }

    public class Order
    {
        public string Data { get; set; } // instead photos to print, I think it's easier

        Status Status;
    }
}
