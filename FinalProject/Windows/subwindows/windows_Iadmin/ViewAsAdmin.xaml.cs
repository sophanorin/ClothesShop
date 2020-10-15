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
    /// Interaction logic for ViewAsAdmin.xaml
    /// </summary>
    public partial class ViewAsAdmin : Window
    {


        public ViewAsAdmin()
        {
            InitializeComponent();

          
        }


      


        private void AddItems_Click(object sender, RoutedEventArgs e)
        {
            if(!Helper.IsWindowOpened<AddItems>())
            {
                AddItems viewAsAdmin = new AddItems();
                viewAsAdmin.Owner = this;
                viewAsAdmin.Show();
            }
        }
    }
}
