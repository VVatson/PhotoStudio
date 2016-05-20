using System;

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
        public OrderStatus Status { get; set; }

        public Order(string parseString)
        {
            var split = parseString.Split(new[] {"&"}, StringSplitOptions.None);
            Id = Convert.ToInt32(split[0]);
            Status = (OrderStatus) Enum.Parse(typeof (OrderStatus), split[1]);
            Data = split[2];
        }

        public Order() { }

        public override string ToString()
        {
            return string.Join("&", Id.ToString(), Status.ToString(), Data);
        }
    }
}
