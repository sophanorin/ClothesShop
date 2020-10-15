using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Dapper.Contrib;
using FinalProject.Model;

namespace FinalProject.Windows.subwindows.windows_Icashier
{
    /// <summary>
    /// Interaction logic for MyAccount.xaml
    /// </summary>
    public partial class Setting : Window
    {
        public int id { get; set; }
        public Setting(Model.Login login)
        {
            InitializeComponent();
            this.DataContext = this;
            id = login.EmployeeID;
            GetEmployeeInfo(id);
        }


        private void GetEmployeeInfo(int id)
        {
            var i = EmployeeInfoContrib.GetEmployeeInfo(id);
            BankAccount = i.Item1;
            Employee = i.Item2;
            Password = i.Item3;
        }

        public Model.Login Password
        {
            get { return (Model.Login)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Login.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(Model.Login), typeof(Setting), new PropertyMetadata(null));



        public Model.Employee Employee
        {
            get { return (Model.Employee)GetValue(EmployeeProperty); }
            set { SetValue(EmployeeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employee.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeeProperty =
            DependencyProperty.Register("Employee", typeof(Model.Employee), typeof(Setting), new PropertyMetadata(null));



        public Model.BankAccount BankAccount
        {
            get { return (Model.BankAccount)GetValue(BankAccountProperty); }
            set { SetValue(BankAccountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BankAccount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BankAccountProperty =
            DependencyProperty.Register("BankAccount", typeof(Model.BankAccount), typeof(Setting), new PropertyMetadata(null));



        private void Informationbtn_Click(object sender, RoutedEventArgs e)
        {
            StackPanel.SetZIndex(PasswordPanel, -1);
            StackPanel.SetZIndex(BankAccountPanel, -1);
            StackPanel.SetZIndex(InformationPanel, 3);
            PasswordPanel.Visibility = Visibility.Collapsed;
            BankAccountPanel.Visibility = Visibility.Collapsed;
            InformationPanel.Visibility = Visibility.Visible;
        }

        private void PasswordPanl_Click(object sender, RoutedEventArgs e)
        {
            StackPanel.SetZIndex(InformationPanel, -1);
            StackPanel.SetZIndex(BankAccountPanel, -1);
            StackPanel.SetZIndex(PasswordPanel, 3);
            InformationPanel.Visibility = Visibility.Collapsed;
            BankAccountPanel.Visibility = Visibility.Collapsed;
            PasswordPanel.Visibility = Visibility.Visible; 
            
        }

        private void Bankaccountbtn_Click(object sender, RoutedEventArgs e)
        {
            StackPanel.SetZIndex(PasswordPanel, -1);
            StackPanel.SetZIndex(InformationPanel, -1);
            StackPanel.SetZIndex(BankAccountPanel, 3);
            PasswordPanel.Visibility = Visibility.Collapsed;
            InformationPanel.Visibility = Visibility.Collapsed;
            BankAccountPanel.Visibility = Visibility.Visible;
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            GetEmployeeInfo(id);
        }
    }
}
