using Dapper.Contrib.Extensions;
using FinalProject.ClassContainer;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for Information.xaml
    /// </summary>
    public partial class Information : UserControl
    {
        public Information()
        {
            InitializeComponent();
            this.DataContext = this;
            EmployeeInformation = new Model.Employee();
        }
        public bool TextChanged { get; set; } = false;
        public Model.Employee EmployeeInformation
        {
            get { return (Model.Employee)GetValue(EmployeeInformationProperty); }
            set { SetValue(EmployeeInformationProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EmployeeInformation.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeeInformationProperty =
            DependencyProperty.Register("EmployeeInformation", typeof(Model.Employee), typeof(Information), new PropertyMetadata(null));


        private void ShowBorder()
        {
            fname.BorderThickness
                = lname.BorderThickness 
                = sex.BorderThickness
                = dob.BorderThickness
                = ph.BorderThickness 
                = addr.BorderThickness
                = email.BorderThickness 
                = new Thickness(1);
        }
        private void HideBorder()
        {
            fname.BorderThickness
                = lname.BorderThickness
                = sex.BorderThickness
                = dob.BorderThickness
                = ph.BorderThickness
                = addr.BorderThickness
                = email.BorderThickness
                = new Thickness(0, 0 ,0, 1);
        }

        private void changebtn_Click(object sender, RoutedEventArgs e)
        {
            InformationUC.IsHitTestVisible = true;
            changebtn.Visibility = Visibility.Hidden;
            savebtn.Visibility = Visibility.Visible;
            ShowBorder();
        }

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {
            if (TextChanged)
            {
                Model.Employee employee = new Employee();
                employee = EmployeeInformation;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClothesShop")))
                {
                    var isSucces = connection.Update<Model.Employee>(employee);
                    if(isSucces)
                        MessageBox.Show("Information Changed Pleeas!! Refresh");
                }
            }
            InformationUC.IsHitTestVisible = false;
            changebtn.Visibility = Visibility.Visible;
            savebtn.Visibility = Visibility.Hidden;
            HideBorder();
        }

        private void TextChenged(object sender, TextChangedEventArgs e)
        {
            TextChanged = true;
        }
    }
}
