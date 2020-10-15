using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Data;
using Dapper.Contrib;
using System.Data.Common;
using FinalProject.ClassContainer;
using System.Collections.ObjectModel;
using FinalProject.UserControls;
using Dapper.Contrib.Extensions;

namespace FinalProject.Windows.mainwindows
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            usernamebtn.Focus();
        }


        public Model.Login CheckUser(string username,string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClothesShop")))
            {
                List<Model.Login> i = connection.GetAll<Model.Login>().Where(s => s.Username.ToLower() == username.ToLower() && s.Password.ToLower() == password.ToLower()).ToList();
                if (i.Count == 0) return null;
                return i[0]; 
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Model.Login logins = CheckUser(usernamebtn.Text.ToLower(), passwordbtn.Password.ToLower());

           if (logins != null)
            {
                if (logins.Role == "admin")
                {
                    Admin admin = new Admin();
                    this.Close();
                    admin.Show();
                }
                else
                {
                    Cashier cashier = new Cashier(logins);
                    this.Close();
                    cashier.Show();
                }
            }
            else
            {
                 MessageBox.Show("Something Wrong");
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
