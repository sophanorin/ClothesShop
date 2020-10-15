using Dapper.Contrib.Extensions;
using FinalProject.ClassContainer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace FinalProject.Windows.subwindows.windows_Iadmin
{
    /// <summary>
    /// Interaction logic for ViewEmployees.xaml
    /// </summary>
    public partial class ViewEmployees : Window
    {
        public ViewEmployees()
        {
            InitializeComponent();
            
            this.DataContext = this;
            if(GetEmployees().Count > 0)
                Employees = GetEmployees();
        }




        public Model.Employee SelectedItem
        {
            get { return (Model.Employee)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(Model.Employee), typeof(ViewEmployees), new PropertyMetadata(null));



        public ObservableCollection<Model.Employee> GetEmployees()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClothesShop")))
            {
                var i = connection.GetAll<Model.Employee>();
                return Helper.Convert<Model.Employee>(i);
            }
        }



        public ObservableCollection<Model.Employee> Employees
        {
            get { return (ObservableCollection<Model.Employee>)GetValue(EmployeesProperty); }
            set { SetValue(EmployeesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employees.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeesProperty =
            DependencyProperty.Register("Employees", typeof(ObservableCollection<Model.Employee>), typeof(ViewEmployees), new PropertyMetadata(null));

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClothesShop")))
            {
                bool i = connection.Delete<Model.Employee>(SelectedItem);
                if (i) MessageBox.Show("Remove Success");
            }
            if (Employees.Count > 0)
                Employees.Remove(SelectedItem);
        }
    }
}
