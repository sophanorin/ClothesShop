using FinalProject.ClassContainer;
using FinalProject.Windows.subwindows.windows_Iadmin;
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
using Dapper;

namespace FinalProject.Windows.mainwindows
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void MenuItem_Add_Click(object sender, RoutedEventArgs e)
        {
            if (!Helper.IsWindowOpened<AddItems>())
            {
                var menuitem = new AddItems();
                menuitem.Owner = this;
                menuitem.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                menuitem.Show();
            }
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            if (!Helper.IsWindowOpened<Login>())
            {
                Login login = new Login();
                this.Close();
                login.Show();
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (!Helper.IsWindowOpened<NewCashier>())
            {
                NewCashier cashier = new NewCashier();
                cashier.Owner = this;
                cashier.Show();
            }
        }

        private void Cetegory_Click(object sender, RoutedEventArgs e)
        {
            if (!Helper.IsWindowOpened<Category>())
            {
                Category newCategory = new Category();
                newCategory.Owner = this;
                newCategory.Show();
            }
        }

        private void Employees_Click(object sender, RoutedEventArgs e)
        {
            if (!Helper.IsWindowOpened<ViewEmployees>())
            {
                ViewEmployees viewEmployees = new ViewEmployees();
                viewEmployees.Owner = this;
                viewEmployees.Show();
            }
        }

        private void ViewAsAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (!Helper.IsWindowOpened<ViewAsAdmin>())
            {
                ViewAsAdmin viewAsAdmin = new ViewAsAdmin();
                viewAsAdmin.Owner = this;
                viewAsAdmin.Show();
            }
        }

        private void ViewAsCashier_Click(object sender, RoutedEventArgs e)
        {
            if(!Helper.IsWindowOpened<Cashier>())
            {
                Cashier cashier = new Cashier();
                cashier.Owner = this;
                cashier.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                cashier.Show();
            }
        }
    }
}
