using System;
using System.Collections.Generic;
using System.Windows.Forms;
using YouPhotoClientApp.Model;
using YouPhotoClientApp.Structures;
using YouPhotoClientApp.Views.Interfaces;
using YouPhotoClientApp.Connection;

namespace YouPhotoClientApp.Views.Controls
{
    public partial class ManagerView : Form, IManagerView
    {
        private IModel Model;

        public ManagerView(IModel model)
        {
            Model = model;
            InitializeComponent();
            this.ShowDialog();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void SetOrderStatus(Order order, OrderStatus status)
        {
            throw new NotImplementedException();
        }

        private void buttonGetOrders_Click(object sender, EventArgs e)
        {
           // List<Order> GetOrders();
        }

        private void buttonSetOrderStatus_Click(object sender, EventArgs e)
        {
            Controllers.Interfaces.IManagerController controller = new Controllers.ManagerController(Model);
            Order order = new Order();
            order.Data = textBox2.Text;
            order.Id = Convert.ToInt32(textBox1.Text);
            order.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), textStatusOrder.Text);
            controller.SetOrderStatus(order, order.Status);
            //Model.SetOrderStatus(order, order.Status);
            label4.Text = "Status changes";
        
        }

        private void buttonBreakOrder_Click(object sender, EventArgs e)
        {
            Controllers.Interfaces.IManagerController controller = new Controllers.ManagerController(Model);
            
            List<Order> list = controller.GetOrders();

            foreach (var line in list)
            {
                richTextBox1.Text += line;
                richTextBox1.Text += "\n ";
            }
        }
    }
}
