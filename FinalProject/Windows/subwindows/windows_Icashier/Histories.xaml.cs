using FinalProject.ClassContainer;
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
    /// Interaction logic for Histories.xaml
    /// </summary>
    public partial class Histories : Window
    {
        public Histories(ObservableCollection<History> histories)
        {
            InitializeComponent();
            this.DataContext = this;
            this.History = histories;
        }

        public int SelectedIndex
        {
            get { return (int)GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedIndex.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedIndexProperty =
            DependencyProperty.Register("SelectedIndex", typeof(int), typeof(Histories), new PropertyMetadata(0));


        public ObservableCollection<History> History
        {
            get { return (ObservableCollection<History>)GetValue(HistoriesProperty); }
            set { SetValue(HistoriesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Histories.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HistoriesProperty =
            DependencyProperty.Register("Histories", typeof(ObservableCollection<History>), typeof(Histories), new PropertyMetadata(null));

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (SelectedIndex > -1 && History.Count > 0) {

                if (!Helper.IsWindowOpened<Invoice>())
                {
                    Invoice invoice = new Invoice(History[SelectedIndex].Lists, History[SelectedIndex].SubCosts) 
                    { No = this.History[SelectedIndex].No,DateTime = this.History[SelectedIndex].DateTime,Calculated = this.History[SelectedIndex].Calculated};
                    invoice.Owner = this;
                    invoice.Show();
                }
            }
        }
    }
}
