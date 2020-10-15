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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalProject.Windows.subwindows.windows_Iadmin
{
    /// <summary>
    /// Interaction logic for NewCashier.xaml
    /// </summary>
    public partial class NewCashier : Window
    {

        public NewCashier()
        {
            InitializeComponent();
            Employee = new Model.Employee();
            Login = new Model.Login();
            this.DataContext = this;
            
        }

        public Model.Login Login
        {
            get { return (Model.Login)GetValue(LoginProperty); }
            set { SetValue(LoginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Login.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LoginProperty =
            DependencyProperty.Register("Login", typeof(Model.Login), typeof(NewCashier), new PropertyMetadata(null));



        public Model.Employee Employee
        {
            get { return (Model.Employee)GetValue(EmployeeProperty); }
            set { SetValue(EmployeeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employee.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeeProperty =
            DependencyProperty.Register("Employee", typeof(Model.Employee), typeof(NewCashier), new PropertyMetadata(null));




        public bool IsEnable
        {
            get { return (bool)GetValue(IsEnableProperty); }
            set { SetValue(IsEnableProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsEnable.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsEnableProperty =
            DependencyProperty.Register("IsEnable", typeof(bool), typeof(NewCashier), new PropertyMetadata(false));

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = ((System.Windows.Controls.ComboBox)e.Source).SelectedItem as System.Windows.Controls.ComboBoxItem;

            if (a.Content.ToString() == "Cashier") IsEnable = true;
            else IsEnable = false;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|bmp file (*.bmp)|*.bmp";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Employee.Image = openFileDialog.FileName;
                    pictureProduct.Background = new ImageBrush(new BitmapImage(new Uri(Employee.Image)));
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClothesShop")))
            {
                if (Employee.InvalidationProduct())
                {
                    int id = Employee.EmployeeID;
                    connection.Insert<Model.Employee>(Employee);
                    connection.Insert<Model.Login>(new Login {EmployeeID = id,Username = Login.Username,Password = Login.Password,Role = "Cashier" });
                    System.Windows.MessageBox.Show("Added Success");
                }
                else System.Windows.MessageBox.Show("You Missed Something");
            }
        }
    }
}
