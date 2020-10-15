using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Globalization;
using System.Windows.Forms;
using System.Threading;
using FinalProject.ClassContainer;

namespace FinalProject.Windows.subwindows.windows_Icashier
{
    /// <summary>
    /// Interaction logic for Calculate.xaml
    /// </summary>
    public partial class Calculate : Window
    {

        public Calculation Calculation { get; set; } = new Calculation();
        public Calculate(double total,mainwindows.Cashier cashier)
        {
            /*Thread.CurrentThread.CurrentUICulture = new CultureInfo("km_KH", false);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("km_KH", false);
            */
            InitializeComponent();
            this.DataContext = Calculation;
            Calculation.Total = total;
            tbRecieve.Focus();
            Cashier = cashier;
            cashier.Calculated = Calculation;
        }


        public mainwindows.Cashier Cashier
        {
            get { return (mainwindows.Cashier)GetValue(CashierProperty); }
            set { SetValue(CashierProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employee.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CashierProperty =
            DependencyProperty.Register("Employee", typeof(mainwindows.Cashier), typeof(Calculate), new PropertyMetadata(null));



        public string Format
        {
            get { return (string)GetValue(FormatProperty); }
            set { SetValue(FormatProperty, value); }
        }

        // Using a DependencyProperty as the backing store for cTotal.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FormatProperty =
            DependencyProperty.Register("cTotal", typeof(string), typeof(Calculate), new FrameworkPropertyMetadata(string.Empty));


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Calculation.IsCalculated)
                Cashier.Cashbtn.IsEnabled = true;
            Close();
        }

        private void CurrencyFormat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            Calculation.CalculateRefund();

        }
    }
}
