using System.Collections.Generic;
using System.Windows.Forms;
using YouPhotoClientApp.Model;
using YouPhotoClientApp.Structures;
using YouPhotoClientApp.Views.Interfaces;

namespace YouPhotoClientApp.Views.Controls
{
    public partial class OperatorView : Form, IOperatorView
    {
        private IModel Model;

        public OperatorView(IModel model)
        {
            Model = model;
            InitializeComponent();
            this.ShowDialog();
        }

        public List<Order> GetOrders()
        {
            throw new System.NotImplementedException();
        }

        public Order ProcessOrder(Order order)
        {
            throw new System.NotImplementedException();
        }

        public void SetOrderStatus(Order order, OrderStatus status)
        {
            throw new System.NotImplementedException();
        }
    }
}
