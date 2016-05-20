using System;
using System.Windows.Forms;
using YouPhotoClientApp.Model;
using YouPhotoClientApp.Structures;
using YouPhotoClientApp.Views.Interfaces;

namespace YouPhotoClientApp.Views.Controls
{
    public partial class ClientView : Form, IClientView
    {
        private IModel Model;

        public ClientView(IModel model)
        {
            Model = model;
            InitializeComponent();
            this.ShowDialog();
        }

        public void MakeOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void BreakOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public OrderStatus CheckOrderStatus(Order order)
        {
            throw new NotImplementedException();
        }

        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            Controllers.Interfaces.IClientController controller = new Controllers.ClientController(Model);
            
            Order order = new Order();
            order.Data = textBox2.Text;
            order.Id = Convert.ToInt32(textBox1.Text);
            order.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), textStatusOrder.Text);
            controller.MakeOrder(order);
            label4.Text = "MakeOrder is Done";

        }

        private void buttonBreakOrder_Click(object sender, EventArgs e)
        {
            Controllers.Interfaces.IClientController controller = new Controllers.ClientController(Model);
            Order order = new Order();
            order.Data = textBox2.Text;
            order.Id = Convert.ToInt32(textBox1.Text);
            order.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), textStatusOrder.Text);
            controller.BreakOrder(order);
            label4.Text = "BreakOrder is Done";
        }

        private void buttonOrderStatus_Click(object sender, EventArgs e)
        {
            Controllers.Interfaces.IClientController controller = new Controllers.ClientController(Model);
            Order order = new Order();
            order.Data = textBox2.Text;
            order.Id = Convert.ToInt32(textBox1.Text);
            order.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), textStatusOrder.Text);

            OrderStatus orderStatus = controller.CheckOrderStatus(order);
            textStatusOrder.Text = orderStatus.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textStatusOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
