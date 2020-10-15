using Microsoft.Win32;
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
using System.Drawing.Printing;
using System.Collections.ObjectModel;
using FinalProject.ClassContainer;
using FinalProject.Model;

namespace FinalProject.Windows.subwindows
{
    /// <summary>
    /// Interaction logic for Invoice.xaml
    /// </summary>
    public partial class Invoice : Window
    {
        public Invoice(ObservableCollection<CheckOutLists> Lists,SubCost SubCosts,mainwindows.Cashier cashier=null)
        {
            InitializeComponent();
            this.Lists = new ObservableCollection<CheckOutLists>();
            this.SubCosts = new SubCost();
            this.DataContext = this;
            if (cashier != null)
            {
                this.Calculated = cashier.Calculated;
                this.Cashier = cashier;
                this.No = cashier.tmpNo;
            }
            this.Lists = Lists;
            this.SubCosts = SubCosts;
            this.DateTime = DateTime.Now;
        }



        public DateTime DateTime
        {
            get { return (DateTime)GetValue(DateTimeProperty); }
            set { SetValue(DateTimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DateTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DateTimeProperty =
            DependencyProperty.Register("DateTime", typeof(DateTime), typeof(Invoice), new PropertyMetadata(null));



        public Calculation Calculated
        {
            get { return (Calculation)GetValue(CalculatedProperty); }
            set { SetValue(CalculatedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Calculated.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CalculatedProperty =
            DependencyProperty.Register("Calculated", typeof(Calculation), typeof(Invoice), new PropertyMetadata(null));




        public int No
        {
            get { return (int)GetValue(NoProperty); }
            set { SetValue(NoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for No.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NoProperty =
            DependencyProperty.Register("No", typeof(int), typeof(Invoice), new PropertyMetadata(0));



        public mainwindows.Cashier Cashier
        {
            get { return (mainwindows.Cashier)GetValue(CashierProperty); }
            set { SetValue(CashierProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employee.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CashierProperty =
            DependencyProperty.Register("Employee", typeof(mainwindows.Cashier), typeof(Invoice), new PropertyMetadata(null));



        public ObservableCollection<CheckOutLists> Lists
        {
            get { return (ObservableCollection<CheckOutLists>)GetValue(ListsProperty); }
            set { SetValue(ListsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Lists.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ListsProperty =
            DependencyProperty.Register("Lists", typeof(ObservableCollection<CheckOutLists>), typeof(Invoice), new PropertyMetadata(null));



        public SubCost SubCosts
        {
            get { return (SubCost)GetValue(SubCostsProperty); }
            set { SetValue(SubCostsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SubCosts.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubCostsProperty =
            DependencyProperty.Register("SubCosts", typeof(SubCost), typeof(Invoice), new PropertyMetadata(null));



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    this.Hide();
                    ListViewInvoice.Height = Double.NaN;
                    printDialog.PrintVisual(print, "Invoice");
                    Cashier.Histories.Add(new History { No = this.No, DateTime = this.DateTime,Description = this.Lists[0].Description,Address = "PhnomPenh",Lists = this.Lists, SubCosts = this.SubCosts ,Calculated = this.Calculated,Total = this.SubCosts.Total});
                    Cashier.ClearCheckOut();
                    Cashier.No++;
                    Cashier.calculatebtn.IsEnabled = false;
                }
            }
            catch { }
            this.IsEnabled = true;
            this.Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
