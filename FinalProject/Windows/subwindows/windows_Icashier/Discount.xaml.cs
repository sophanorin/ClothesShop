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

namespace FinalProject.Windows.subwindows.windows_Icashier
{
    /// <summary>
    /// Interaction logic for Discount.xaml
    /// </summary>
    public partial class Discount : Window
    {
        public Discount(Model.SubCost subCost)
        {
            InitializeComponent();
            DataContext = this;
            this.SubCost = subCost;
        }


        public Model.SubCost SubCost
        {
            get { return (Model.SubCost)GetValue(SubCostProperty); }
            set { SetValue(SubCostProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SubCost.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubCostProperty =
            DependencyProperty.Register("SubCost", typeof(Model.SubCost), typeof(Discount), new PropertyMetadata(null));


        public double Text
        {
            get { return (double)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(double), typeof(Discount), new PropertyMetadata(0.0));

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression bindingExpression = tbDiscount.GetBindingExpression(TextBox.TextProperty);
            bindingExpression.UpdateSource();
            if (Text <= 1)
            {
                SubCost.Discount = Text;
                SubCost.Total = SubCost.SubTotal - (SubCost.SubTotal * SubCost.Discount);
                Close();
            }
            else MessageBox.Show("Input must be smaller than 1 ex. 0.5 = 50%");
        }
    }
}
