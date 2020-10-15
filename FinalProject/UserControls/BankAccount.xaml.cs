using Dapper.Contrib.Extensions;
using FinalProject.ClassContainer;
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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject.UserControls
{
    /// <summary>
    /// Interaction logic for BankAccount.xaml
    /// </summary>
    public partial class BankAccount : UserControl
    {
        public BankAccount()
        {
            InitializeComponent();
            this.DataContext = this;
            Bank = new Model.BankAccount();
        }

        public bool TextChenged { get; set; } = false;

        public Model.BankAccount Bank
        {
            get { return (Model.BankAccount)GetValue(BankProperty); }
            set { SetValue(BankProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Bank.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BankProperty =
            DependencyProperty.Register("Bank", typeof(Model.BankAccount), typeof(BankAccount), new PropertyMetadata(null));


        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            bankaccPanel.IsHitTestVisible = true;
            savebtn.Visibility = Visibility.Visible;
            editbtn.Visibility = Visibility.Collapsed;
        }

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {
            if (TextChenged)
            {
                Model.BankAccount bankAccount = new Model.BankAccount();
                bankAccount = Bank;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClothesShop")))
                {
                    var isSucces = connection.Update<Model.BankAccount>(bankAccount);
                    if (isSucces)
                        MessageBox.Show("Password Changed Pleeas!! Refresh");
                    else MessageBox.Show("Please Try Again");
                }
            }
            bankaccPanel.IsHitTestVisible = false;
            editbtn.Visibility = Visibility.Visible;
            savebtn.Visibility = Visibility.Collapsed;
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            TextChenged = true;
        }
    }
}
