using System;
using System.Windows.Forms;
using YouPhotoClientApp.Model;
using YouPhotoClientApp.Structures;
using YouPhotoClientApp.Views.Interfaces;

namespace YouPhotoClientApp.Views.Controls
{
    public partial class AutorizationView : Form, IAutorizationView
    {
        private IModel Model; 
        public AutorizationView(IModel model)
        {
            Model = model;
            InitializeComponent();
        }

        public bool Autorize(string login, string password)
        {
            throw new NotImplementedException();
        }

        public void Register(string login, string password, UserType userType)
        {
            throw new NotImplementedException();
        }
    }
}
