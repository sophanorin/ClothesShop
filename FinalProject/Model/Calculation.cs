using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinalProject.Model
{
    public class Calculation : DependencyObject
    {

        public double Total
        {
            get { return (double)GetValue(TotalProperty); }
            set { SetValue(TotalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Total.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalProperty =
            DependencyProperty.Register("Total", typeof(double), typeof(Calculation), new PropertyMetadata(0.0));

      

        public double Recieve
        {
            get { return (double)GetValue(RecieveProperty); }
            set { SetValue(RecieveProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Recieve.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RecieveProperty =
            DependencyProperty.Register("Recieve", typeof(double), typeof(Calculation), new PropertyMetadata(null));



        public string Refund
        {
            get { return (string)GetValue(RefundProperty); }
            set { SetValue(RefundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Refund.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RefundProperty =
            DependencyProperty.Register("Refund", typeof(string), typeof(Calculation), new FrameworkPropertyMetadata(string.Empty));
        public bool IsCalculated { get; set; } = false;
        public void CalculateRefund()
        {
            if (Recieve > Total)
            {
                Refund = (Recieve - Total).ToString("C");
                IsCalculated = true;
            }
            else
                Refund = "Invalid Revieve"; 
        }
    }
    public class InvalidRecieve : ApplicationException
    {
        public InvalidRecieve(string msg):base(msg)
        {
        }
    }

}
