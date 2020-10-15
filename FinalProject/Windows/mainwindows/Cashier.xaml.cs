using FinalProject.Windows.subwindows;
using FinalProject.Windows.subwindows.windows_Icashier;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FinalProject.ClassContainer;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using FinalProject.Model;
using System;

namespace FinalProject.Windows.mainwindows
{
    public partial class Cashier : Window
    {
        private ProductsList ProductsList = new ProductsList();
        public int No { get; set; } = 1;
        public int tmpNo { get; set; } = 0;
        private string category { get; set; } = "A";
        public Model.Login Login { get; set; } = new Model.Login();
        public Cashier(Model.Login login=null)
        {
            InitializeComponent();
            Cashbtn.IsEnabled = false;
            this.DataContext = this;
            if (ProductsList.Products.Count > 0)
                ListViewProducts.ItemsSource = ProductsList.Products;
            Histories = new ObservableCollection<History>();
            Lists = new ObservableCollection<CheckOutLists>();
            OrderStatuses = new ObservableCollection<Model.OrderStatus>();
            SubCosts = new SubCost();
            Login = login;
        }

        #region Category
        private void Button_Click_All(object sender, RoutedEventArgs e)
        {
            GridCursorMove(e);
            category = "A";
            ListViewProducts.ItemsSource = ProductsList.Products;
        }

        private void Button_Click_Men(object sender, RoutedEventArgs e)
        {
            GridCursorMove(e);
            category = "Men";
            ListViewProducts.ItemsSource = ProductsList.Products.Where(p => p.Category.ToLower() == category.ToLower());
        }

        private void Button_Click_Women(object sender, RoutedEventArgs e)
        {
            GridCursorMove(e);
            category = "Women";
            ListViewProducts.ItemsSource = ProductsList.Products.Where(p => p.Category.ToLower() == category.ToLower());
        }

        private void Button_Click_Shoes(object sender, RoutedEventArgs e)
        {
            GridCursorMove(e);
            category = "Shoes";
            ListViewProducts.ItemsSource = ProductsList.Products.Where(p => p.Category.ToLower() == category.ToLower());
        }

        private void Button_Click_Bags(object sender, RoutedEventArgs e)
        {
            GridCursorMove(e);
            category = "Bags";
            ListViewProducts.ItemsSource = ProductsList.Products.Where(p => p.Category == category);
        }

        private void Button_Click_Accessory(object sender, RoutedEventArgs e)
        {
            GridCursorMove(e);
            category = "Accessory";
            ListViewProducts.ItemsSource = ProductsList.Products.Where(p => p.Category == category);
        }

        private void Button_Click_Other(object sender, RoutedEventArgs e)
        {
            GridCursorMove(e);
            category = "O";
            ListViewProducts.ItemsSource = ProductsList.Products.Where(p => p.Category == category);
        }
        #endregion
        #region Search
        private string search = "";
        private void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                search = ((System.Windows.Controls.TextBox)e.Source).Text.Trim();
                SeacrhItem(search);
            }
        }
        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
            search = tbsearch.Text.Trim();
            SeacrhItem(search);
        }
        private void SeacrhItem(string search)
        {
            if (search != string.Empty)
            {
                if (category != "A")
                    ListViewProducts.ItemsSource = ProductsList.Products.Where(p => (p.Description.ToLower().Contains(search.ToLower())) && (p.Category == category));
                else
                    ListViewProducts.ItemsSource = ProductsList.Products.Where(p => (p.Description.ToLower().Contains(search.ToLower())));
            }
            else
            {
                ListViewProducts.ItemsSource = ProductsList.Products;
                GridCursorMove(null,true);
            }
        }

        #endregion
        #region CloseWindow
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(System.Windows.Forms.MessageBox.Show("Closing Window?", "Close", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Close();
        }
        #endregion
        #region GridCursorMove
        private void GridCursorMove(RoutedEventArgs routed,bool defualt=false)
        {
            int index = 0;
            if (!defualt)
                 index = int.Parse(((System.Windows.Controls.Button)routed.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);
        }
        #endregion
        #region CheckOut
        private void OpenCloseCheckOut_Click(object sender, RoutedEventArgs e)
        {
            if (GridCheckOut.Width < 600)
                ButtonOpenCheckOut.IsHitTestVisible = false;
        }

        private void CloseCheckOut_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenCheckOut.IsHitTestVisible = true;
        }
        #endregion
        #region FormOpen
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            if (!Helper.IsWindowOpened<Login>())
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }
        private void ShowStock_Button(object sender, RoutedEventArgs e)
        {


            if (!Helper.IsWindowOpened<stock>())
            {
                var stock = new stock();
                stock.Owner = this;
                stock.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                stock.ResizeMode = ResizeMode.NoResize;
                stock.Show();
            }
        }

        private void ShowHistoies_Button(object sender, RoutedEventArgs e)
        {
            if (!Helper.IsWindowOpened<Histories>())
            {
                var histories = new Histories(Histories);
                histories.Owner = this;
                histories.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                histories.ResizeMode = ResizeMode.NoResize;
                histories.Show();
            }
        }
        private void Payment_Button_Click(object sender, RoutedEventArgs e)
        {
            tmpNo = No;
            if (!Helper.IsWindowOpened<Invoice>())
            {
                Invoice invoice = new Invoice(Lists,SubCosts,this);
                invoice.Owner = this;
                invoice.Show();

            }
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            if (!Helper.IsWindowOpened<Setting>())
            {
                Setting AS = new Setting(Login);
                AS.Owner = this;
                AS.Show();
            }
        }
        // OrderStatus
        private void orderstatusbtn_Click(object sender, RoutedEventArgs e)
        {
            if (!Helper.IsWindowOpened<subwindows.OrderStatus>())
            {
                subwindows.OrderStatus orderStatus = new subwindows.OrderStatus(OrderStatuses,this);
                orderStatus.Owner = this;
                orderStatus.Show();
            }
        }

        private void calculatebtn_Click(object sender, RoutedEventArgs e)
        {
            if(!Helper.IsWindowOpened<Calculate>())
            {
                double n = SubCosts.Total;
                Calculate calculate = new Calculate(n, this);
                calculate.Owner = this;
                calculate.Show();
                //binding with invoice
            }
        }
        private void Discount_Click(object sender, RoutedEventArgs e)
        {
            if (!Helper.IsWindowOpened<Discount>())
            {
                Discount discount = new Discount(SubCosts);
                discount.Owner = this;
                discount.Show();
            }
        }
        #endregion


        public ObservableCollection<History> Histories
        {
            get { return (ObservableCollection<History>)GetValue(HistoriesProperty); }
            set { SetValue(HistoriesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Histories.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HistoriesProperty =
            DependencyProperty.Register("Histories", typeof(ObservableCollection<History>), typeof(Cashier), new PropertyMetadata(null));




        public Calculation Calculated
        {
            get { return (Calculation)GetValue(CalculatedProperty); }
            set { SetValue(CalculatedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Calculated.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CalculatedProperty =
            DependencyProperty.Register("Calculated", typeof(Calculation), typeof(Cashier), new PropertyMetadata(null));



        public ObservableCollection<Model.OrderStatus> OrderStatuses
        {
            get { return (ObservableCollection<Model.OrderStatus>)GetValue(OrderStatusesProperty); }
            set { SetValue(OrderStatusesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OrderStatuses.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrderStatusesProperty =
            DependencyProperty.Register("OrderStatuses", typeof(ObservableCollection<Model.OrderStatus>), typeof(Cashier), new PropertyMetadata(null));


        public ObservableCollection<CheckOutLists> Lists
        {
            get { return (ObservableCollection<CheckOutLists>)GetValue(ListsProperty); }
            set { SetValue(ListsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Lists.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ListsProperty =
            DependencyProperty.Register("Lists", typeof(ObservableCollection<CheckOutLists>), typeof(Cashier), new PropertyMetadata(null));




        public CheckOutLists SelectedItem
        {
            get { return (CheckOutLists)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for checkOutLists.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("checkOutLists", typeof(CheckOutLists), typeof(Cashier), new PropertyMetadata(null));



        public int SelectedIndex
        {
            get { return (int)GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedIndexProperty =
            DependencyProperty.Register("SelectedItem", typeof(int), typeof(Cashier), new PropertyMetadata(null));

        public SubCost SubCosts
        {
            get { return (SubCost)GetValue(SubCostsProperty); }
            set { SetValue(SubCostsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SubCost.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubCostsProperty =
            DependencyProperty.Register("SubCost", typeof(SubCost), typeof(Cashier), new PropertyMetadata(null));



        private void AddItemToListCheckOut_Click(object sender, RoutedEventArgs e)
        {
            Product product = ((System.Windows.Controls.Button)sender).Tag as Product;

            CheckOutLists dataForList = new CheckOutLists(product.Description,product.Category, 1, product.Price);


            SubCosts.SubTotal += product.Price;
            SubCosts.Total = SubCosts.SubTotal - (SubCosts.Discount * SubCosts.SubTotal) + SubCosts.Tax;
            int i = IsItemExisting(dataForList);
            if ( i == -1)
                Lists.Add(dataForList);
            else
            {
                Lists[i].Amount++;
                Lists[i].Price += product.Price;
            }
            Cashbtn.IsEnabled = false;
        }

        private int IsItemExisting(CheckOutLists d)
        {
            int index = 0;
            foreach(var i in Lists)
            {
                if (i.Description == d.Description && i.Category == d.Category) return index;
                index++;
            }
            return -1;
        }


         public void ClearCheckOut()
        {
            Lists = new ObservableCollection<CheckOutLists>();
            SubCosts = new SubCost();
        }
        public void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearCheckOut();
        }

        private void SaveCheckOutList_Click(object sender, RoutedEventArgs e)
        {
            tmpNo = No;
            Model.OrderStatus orderStatus = new Model.OrderStatus {No=tmpNo, Lists = Lists, SubCosts = SubCosts };
            OrderStatuses.Add(orderStatus);
            ClearCheckOut();
            No++;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            int index = SelectedIndex;
            if ( index != -1)
            {
                double tmp = Lists[index].Price;
                Lists.RemoveAt(index);
                SubCosts.SubTotal -= tmp;
                SubCosts.Total -= tmp;
                Cashbtn.IsEnabled = false;
            }
        }
    }   
}