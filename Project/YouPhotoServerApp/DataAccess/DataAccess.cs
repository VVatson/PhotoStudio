using System;
using System.Collections.Generic;
using YouPhotoServerApp.Structures;
using YouPhotoServerApp.DataBase;

namespace YouPhotoServerApp.DataAccess
{
    public class DataAccess: IDataAccess
    {
        private DataBase.DataBase db = new DataBase.DataBase();
        
        public bool IsUserInBase(User user)
        {
            return db.IsUserInBase(user.ToString());
        }

        public void Register(User user)
        {
            db.AddUser(user.ToString());
        }

        public void MakeOrder(Order order)
        {
            db.AddOrder(order.ToString());
        }

        public void BreakOrder(Order order)
        {
            db.RemoveOrder(order.ToString()); 
        }

        public Status CheckOrderStatus(Order order)
        {
            return (Status)Enum.Parse(typeof(Status), db.CheckOrderStatus(order.ToString()));
        }

        public void SetOrderStatus(Order order, Status status)
        {
            db.SetOrderStatus(order.ToString(), status.ToString());
        }

        public List<Order> GetOrders()
        {
            var lines = db.GetOrders();
            var orders = new List<Order>();
            foreach (var line in lines)
            {
                orders.Add(new Order(line));
            }
            return orders;
        }

        public Order ProcessOrder(Order order)
        {
            return new Order(db.ProcessOrder(order.ToString()));
        }
    }
}
