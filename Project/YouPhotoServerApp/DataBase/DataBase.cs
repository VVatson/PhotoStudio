using System.Collections.Generic;
using System.IO;
using System.Text;

namespace YouPhotoServerApp.DataBase
{
    public class DataBase
    {
        public static string orderBasePath = "orderBase.txt";
        public static string userBasePath = "userBase.txt"; 

        public bool IsUserInBase(string userData)
        {
            var lines = File.ReadAllLines(userBasePath);
            foreach (var line in lines)
            {
                if (string.Equals(line, userData))
                    return true;
            }
            return false;
        }

        public void AddUser(string userData)
        {
            File.AppendAllLines(userBasePath, new string [] { userData }, Encoding.UTF8);
        }

        public void AddOrder(string orderData)
        {
            File.AppendAllLines(orderBasePath, new string[] { orderData }, Encoding.UTF8);
        }

        public void RemoveOrder(string orderData)
        {
            var lines = File.ReadAllLines(orderBasePath);
            var newLines = new List<string>();
            foreach (var line in lines)
            {
                if (!string.Equals(line, orderData))
                    newLines.Add(line);
            }
            File.WriteAllLines(orderBasePath, newLines);
        }

        public string CheckOrderStatus(string orderData)
        {
            var lines = File.ReadAllLines(orderBasePath);
            var order = orderData.Split(new char[] { '&' });
            foreach (var line in lines)
            {
                if (line.Contains(order[1]))
                {
                    var lineSplit = line.Split((new char[] { '&' }));
                    return lineSplit[2]; 
                }
            }
            return Structures.Status.Undefined.ToString();
        }

        public void SetOrderStatus(string orderData, string status)
        {
            var lines = File.ReadAllLines(orderBasePath);
            var newLines = new List<string>();
            foreach (var line in lines)
            {
                if (string.Equals(line, orderData))
                {
                    var lineSplit = line.Split((new char[] { '&' }));
                    newLines.Add(string.Format("{0}&{1}&{2}", lineSplit[0], lineSplit[1], status));
                }
                else
                    newLines.Add(line);
            }
            File.WriteAllLines(orderBasePath, newLines);
        }

        public string ProcessOrder(string orderData)
        {
            var lines = File.ReadAllLines(orderBasePath);
            var newLines = new List<string>();
            var changedOrder = string.Empty;
            foreach (var line in lines)
            {
                if (string.Equals(line, orderData))
                {
                    var lineSplit = line.Split((new char[] { '&' }));
                    changedOrder = string.Format("{0}&{1}&{2}", "Yeaahhh", lineSplit[1], Structures.Status.Ready);
                    newLines.Add(changedOrder);
                }
                else
                    newLines.Add(line);
            }
            return changedOrder;
        }

        public List<string> GetOrders()
        {
            var orders = new List<string>();
            var lines = File.ReadAllLines(orderBasePath);
            orders.AddRange(lines);
            return orders;
        }
    }
}
