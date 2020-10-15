using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Dapper.Contrib.Extensions;
using FinalProject.ClassContainer;
using Microsoft.Win32;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace FinalProject.Windows.subwindows.windows_Iadmin
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class AddItems : Window
    {

        public bool Ischeck { get; set; } = false;

        public AddItems()
        {
            InitializeComponent();
            Categories = GetCategories();
            Product = new Model.Product();
        }


        public Model.Product Product
        {
            get { return (Model.Product)GetValue(ProductProperty); }
            set { SetValue(ProductProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Product.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProductProperty =
            DependencyProperty.Register("Product", typeof(Model.Product), typeof(AddItems), new PropertyMetadata(null));



        public ObservableCollection<Model.Category> Categories
        {
            get { return (ObservableCollection<Model.Category>)GetValue(CategoriesProperty); }
            set { SetValue(CategoriesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Categories.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CategoriesProperty =
            DependencyProperty.Register("Categories", typeof(ObservableCollection<Model.Category>), typeof(AddItems), new PropertyMetadata(null));


        private ObservableCollection<Model.Category> GetCategories()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClothesShop")))
            {
                var i = connection.GetAll<Model.Category>();
                
                return Helper.Convert<Model.Category>(i);
            }
        }
     

        private void NewCategory_Click(object sender, RoutedEventArgs e)
        {
            if (!Helper.IsWindowOpened<Category>())
            {
                Category newCategory = new Category();
                newCategory.Owner = this;
                newCategory.Show();
            }
        }

        private void ChooseImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|bmp file (*.bmp)|*.bmp";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Product.Image = openFileDialog.FileName;
                    pictureProduct.Background = new ImageBrush(new BitmapImage(new Uri(Product.Image)));
                }
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            Categories = GetCategories();
            Product = new Model.Product();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Product.Category = ((System.Windows.Controls.RadioButton)e.Source).Content.ToString();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClothesShop")))
            {
                if (Product.InvalidationProduct())
                {
                    var i = connection.Insert<Model.Product>(Product);
                    System.Windows.MessageBox.Show("Added Success");
                    Product = new Model.Product();
                }
                else System.Windows.MessageBox.Show("You Missed Something");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Product = new Model.Product();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
