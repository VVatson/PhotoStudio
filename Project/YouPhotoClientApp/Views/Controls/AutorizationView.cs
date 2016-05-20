using System;
using System.Windows.Forms;
using YouPhotoClientApp.Model;
using YouPhotoClientApp.Structures;
using YouPhotoClientApp.Views.Interfaces;
using YouPhotoClientApp.Connection;

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

        public AutorizationView()
        {
        }

        public bool Autorize(string login, string password)
        {
            throw new NotImplementedException();
        }

        public void Register(string login, string password, UserType userType)
        {
            throw new NotImplementedException();
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Controllers.Interfaces.IAuthorizationController controller = new Controllers.AuthorizationController(Model);
            
            string name = textName.Text;
            string pasw = textPas.Text;
            UserType type = UserType.Client;
            if(comboUser.SelectedIndex == 0)
                type = UserType.Client;
            if(comboUser.SelectedIndex == 1)
                type = UserType.Manager;
            if(comboUser.SelectedIndex == 2)
                type = UserType.Operator;
            controller.Register(name, pasw, type);
            label4.Text = "Registration is Done";
        }

        private void buttonAut_Click(object sender, EventArgs e)
        {
            Controllers.Interfaces.IAuthorizationController controller = new Controllers.AuthorizationController(Model);
            
            string name = textName.Text;
            string pasw = textPas.Text;
            Form form;
            bool aut = controller.Autorize(name, pasw);
            if (aut == true)
            {
                UserType type = UserType.Client;
                if (comboUser.SelectedIndex == 0)
                    form = new ClientView(Model);
                if (comboUser.SelectedIndex == 1)
                    form = new ManagerView(Model);
                if (comboUser.SelectedIndex == 2)
                    form = new OperatorView(Model);
                label4.Text = "Aut is successful";
            }
            
        }
    }
}
