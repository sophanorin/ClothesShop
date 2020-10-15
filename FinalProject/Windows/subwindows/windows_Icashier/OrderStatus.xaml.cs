using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FinalProject.Windows.subwindows
{
    /// <summary>
    /// Interaction logic for OrderStatus.xaml
    /// </summary>
    public partial class OrderStatus : Window
    {
        public OrderStatus(ObservableCollection<Model.OrderStatus> orderStatus,mainwindows.Cashier cashier)
        {
            InitializeComponent();
            this.DataContext = this;
            OrderStatuses = orderStatus;
            Cashier = cashier;
        }



        public mainwindows.Cashier Cashier
        {
            get { return (mainwindows.Cashier)GetValue(CashierProperty); }
            set { SetValue(CashierProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employee.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CashierProperty =
            DependencyProperty.Register("Employee", typeof(mainwindows.Cashier), typeof(OrderStatus), new PropertyMetadata(null));


        public int SelectedIndex
        {
            get { return (int)GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedIndex.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedIndexProperty =
            DependencyProperty.Register("SelectedIndex", typeof(int), typeof(OrderStatus), new PropertyMetadata(0));




        public ObservableCollection<Model.OrderStatus> OrderStatuses
        {
            get { return (ObservableCollection<Model.OrderStatus>)GetValue(OrderStatusesProperty); }
            set { SetValue(OrderStatusesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrderStatusesProperty =
            DependencyProperty.Register("MyProperty", typeof(ObservableCollection<Model.OrderStatus>), typeof(OrderStatus), new PropertyMetadata(null));

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int index = SelectedIndex;
            if (index > -1 && OrderStatuses.Count > 0)
            {
                Model.OrderStatus tmp = new Model.OrderStatus();
                tmp = OrderStatuses[index];
                OrderStatuses.RemoveAt(index);
                Cashier.ClearCheckOut();
                Cashier.Lists = tmp.Lists;
                Cashier.SubCosts = tmp.SubCosts;
                Cashier.No = tmp.No;
            }
        }
    }
}
