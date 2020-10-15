using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinalProject.ClassContainer
{
    public class CheckOutLists : DependencyObject 
    {
        public string Description { get; set; }
        public string Category { get; set; }
        public int Amount
        {
            get { return (int)GetValue(AmountProperty); }
            set { SetValue(AmountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Amount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AmountProperty =
            DependencyProperty.Register("Amount", typeof(int), typeof(CheckOutLists), new PropertyMetadata(0));

        public double Price
        {
            get { return (double)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Price.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(double), typeof(CheckOutLists), new PropertyMetadata(0.0));


        public CheckOutLists(string des,string catry,int amount,double price)
        {
            this.Description = des;
            this.Category = catry;
            this.Amount = amount;
            this.Price = price;
        }
    }
}
