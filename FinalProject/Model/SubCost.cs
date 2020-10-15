using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinalProject.Model
{
    public class SubCost : DependencyObject
    {

        public double SubTotal
        {
            get { return (double)GetValue(SubTotalProperty); }
            set { SetValue(SubTotalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SubTotal.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubTotalProperty =
            DependencyProperty.Register("SubTotal", typeof(double), typeof(SubCost), new PropertyMetadata(0.0));


        public double Discount
        {
            get { return (double)GetValue(DiscountProperty); }
            set { SetValue(DiscountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Discount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DiscountProperty =
            DependencyProperty.Register("Discount", typeof(double), typeof(SubCost), new PropertyMetadata(0.0));




        public double Total
        {
            get { return (double)GetValue(TotalProperty); }
            set { SetValue(TotalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Total.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalProperty =
            DependencyProperty.Register("Total", typeof(double), typeof(SubCost), new PropertyMetadata(0.0));



        public double Tax
        {
            get { return (double)GetValue(TaxProperty); }
            set { SetValue(TaxProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Tax.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TaxProperty =
            DependencyProperty.Register("Tax", typeof(double), typeof(SubCost), new PropertyMetadata(0.0));

        
    }
}
