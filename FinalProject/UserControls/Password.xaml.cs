using Dapper.Contrib;
using Dapper.Contrib.Extensions;
using FinalProject.ClassContainer;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject.UserControls
{
    /// <summary>
    /// Interaction logic for Password.xaml
    /// </summary>
    public partial class Password : UserControl
    {
        public Password()
        {
            InitializeComponent();
            this.DataContext = this;
            Login = new Model.Login();
        }

        public string ConfirmPassword
        {
            get { return (string)GetValue(ConfirmPasswordProperty); }
            set { SetValue(ConfirmPasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ConfirmPassword.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ConfirmPasswordProperty =
            DependencyProperty.Register("ConfirmPassword", typeof(string), typeof(Password), new PropertyMetadata(string.Empty));



        public string newPassword
        {
            get { return (string)GetValue(newPasswordProperty); }
            set { SetValue(newPasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for newPassword.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty newPasswordProperty =
            DependencyProperty.Register("newPassword", typeof(string), typeof(Password), new PropertyMetadata(string.Empty));


        public Model.Login Login
        {
            get { return (Model.Login)GetValue(LoginProperty); }
            set { SetValue(LoginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Login.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LoginProperty =
            DependencyProperty.Register("Login", typeof(Model.Login), typeof(Password), new PropertyMetadata(null));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int tmpID = this.Login.EmployeeID;
            string tmpUsername = this.Login.Username;
            string tmpRole = this.Login.Role;

            if (newPassword == string.Empty || ConfirmPassword == string.Empty)
                return;
            if(newPassword!=ConfirmPassword)
                MessageBox.Show("Confirm Password not matching");
            else
            {
                if(newPassword == ConfirmPassword)
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClothesShop")))
                    {

                        var tmp = connection.Get<Login>(tmpID);
                        tmp.Password = newPassword;
                        var isSucces = connection.Update<Model.Login>(tmp);
                        MessageBox.Show("Password Changed Pleeas!! Refresh");
                    }
                }
            }
            newPassword = "";
            ConfirmPassword = "";
        }
    }
}
