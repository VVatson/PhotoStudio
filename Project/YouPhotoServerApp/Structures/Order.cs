using System;

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
        public int Id { get; set; }
        public Status Status { get; set; }

        public Order(string parseString)
        {
            var split = parseString.Split(new[] { "&" }, StringSplitOptions.None);
            Id = Convert.ToInt32(split[0]);
            Status = (Status)Enum.Parse(typeof(Status), split[1]);
            Data = split[2];
        }

        public override string ToString()
        {
            return string.Join("&", Data, Id.ToString(), Status.ToString());
        }
    }
}
