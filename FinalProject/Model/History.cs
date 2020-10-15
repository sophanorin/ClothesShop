using FinalProject.Model;
using FinalProject.Windows.subwindows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinalProject.ClassContainer
{
    public class History : DependencyObject
    {
        public DateTime DateTime
        {
            get { return (DateTime)GetValue(DateTimeProperty); }
            set { SetValue(DateTimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DateTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DateTimeProperty =
            DependencyProperty.Register("DateTime", typeof(DateTime), typeof(History), new PropertyMetadata(null));

        public string Address
        {
            get { return (string)GetValue(AddressProperty); }
            set { SetValue(AddressProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Address.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AddressProperty =
            DependencyProperty.Register("Address", typeof(string), typeof(History), new PropertyMetadata(string.Empty));



        public double Total
        {
            get { return (double)GetValue(TotalProperty); }
            set { SetValue(TotalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Total.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalProperty =
            DependencyProperty.Register("Total", typeof(double), typeof(History), new PropertyMetadata(0.0));



        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Description.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(History), new PropertyMetadata(string.Empty));

        public int No
        {
            get { return (int)GetValue(NoProperty); }
            set { SetValue(NoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for No.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NoProperty =
            DependencyProperty.Register("No", typeof(int), typeof(History), new PropertyMetadata(0));


        public ObservableCollection<CheckOutLists> Lists
        {
            get { return (ObservableCollection<CheckOutLists>)GetValue(ListsProperty); }
            set { SetValue(ListsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ListsProperty =
            DependencyProperty.Register("MyProperty", typeof(ObservableCollection<CheckOutLists>), typeof(History), new PropertyMetadata(null));

        public SubCost SubCosts
        {
            get { return (SubCost)GetValue(SubCostsProperty); }
            set { SetValue(SubCostsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SubCosts.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubCostsProperty =
            DependencyProperty.Register("SubCosts", typeof(SubCost), typeof(History), new PropertyMetadata(null));



        public Calculation Calculated
        {
            get { return (Calculation)GetValue(CalculatedProperty); }
            set { SetValue(CalculatedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Calculated.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CalculatedProperty =
            DependencyProperty.Register("Calculated", typeof(Calculation), typeof(History), new PropertyMetadata(null));


    }
}
