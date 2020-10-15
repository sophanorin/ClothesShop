using FinalProject.Model;
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

namespace FinalProject.Windows.subwindows.windows_Icashier
{
    /// <summary>
    /// Interaction logic for stock.xaml
    /// </summary>
    public partial class stock : Window
    {
        private ProductsList ProductsList { get; set; } = new ProductsList();
        public stock()
        {
            InitializeComponent();
            this.DataContext = this;
            if (ProductsList.Products.Count > 0)
                Products = ProductsList.Products;
        }



        public ObservableCollection<Product> Products
        {
            get { return (ObservableCollection<Product>)GetValue(ProductsProperty); }
            set { SetValue(ProductsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Products.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProductsProperty =
            DependencyProperty.Register("Products", typeof(ObservableCollection<Product>), typeof(stock), new PropertyMetadata(null));



        public string Search
        {
            get { return (string)GetValue(SearchProperty); }
            set { SetValue(SearchProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Search.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SearchProperty =
            DependencyProperty.Register("Search", typeof(string), typeof(stock), new PropertyMetadata(string.Empty));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SearchItem();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SearchItem();
            }
        }
        private void SearchItem()
        {
            stockProducts.ItemsSource = Products.Where(p => p.Description.ToLower().Contains(Search.Trim().ToLower()));
        }
    }
}
