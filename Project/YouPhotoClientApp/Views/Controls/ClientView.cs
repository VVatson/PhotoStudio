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
        }

        public void MakeOrder(string data)
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
    }
}
