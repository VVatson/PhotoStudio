using System;
using System.Collections.Generic;
using System.Windows.Forms;
using YouPhotoClientApp.Model;
using YouPhotoClientApp.Structures;
using YouPhotoClientApp.Views.Interfaces;

namespace YouPhotoClientApp.Views.Controls
{
    public partial class ManagerView : Form, IManagerView
    {
        private IModel Model;

        public ManagerView(IModel model)
        {
            Model = model;
            InitializeComponent();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void SetOrderStatus(Order order, OrderStatus status)
        {
            throw new NotImplementedException();
        }
    }
}
