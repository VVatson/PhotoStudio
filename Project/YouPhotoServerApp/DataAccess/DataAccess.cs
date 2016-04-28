using System.Collections.Generic;
using YouPhotoServerApp.Structures;

namespace YouPhotoServerApp.DataAccess
{
    public class DataAccess: IDataAccess
    {
        public bool IsUserInBase(User user)
        {
            throw new System.NotImplementedException();
        }

        public void Register(User user)
        {
            throw new System.NotImplementedException();
        }

        public void MakeOrder(Order order)
        {
            throw new System.NotImplementedException();
        }

        public void BreakOrder(Order order)
        {
            throw new System.NotImplementedException(); 
        }

        public Status CheckOrderStatus(Order order)
        {
            throw new System.NotImplementedException();
        }

        public void SetOrderStatus(Order order, Status status)
        {
            throw new System.NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new System.NotImplementedException();
        }

        public Order ProcessOrder(Order order)
        {
            throw new System.NotImplementedException();   
        }
    }
}
