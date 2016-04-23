﻿namespace YouPhotoClientApp.Structures
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

        OrderStatus Status;
    }
}
