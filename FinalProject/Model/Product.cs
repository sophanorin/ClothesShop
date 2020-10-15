using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinalProject.Model
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Size { get; set; } = "N/A";
        public int Amount { get; set; }
        public string Category { get; set; }
        public string Type { get; set; } = "N/A";

        [Write(false)]
        public double Price2 { get; set; } = 0.0;
        public string OffPercent { get; set; } = "";
        public Visibility IsTag { get; set; } = Visibility.Collapsed;
        public Visibility IsOff { get; set; } = Visibility.Collapsed;

        public bool InvalidationProduct()
        {
            if (Description == string.Empty) return false;
            if (Price == 0) return false;
            if (Image == string.Empty) return false;
            if (Size == string.Empty) return false;
            if (Amount == 0) return false;
            if (Category == string.Empty) return false;
            if (Type == string.Empty) return false;
            return true;
        }
       /* public Product()
        {
            
            if (IsOff)
            {
                double tmp = 0;
                double p= offpercent / 100;
                this.IsTag = Visibility.Visible;
                this.IsOff = Visibility.Visible;
                this.OffPercent = (p).ToString("P");
                double OffPrice = (p) * this.Price;
                tmp = this.Price;
                this.Price -= OffPrice;
                this.Price2 = tmp;
            }
            else
            {
                this.IsOff = Visibility.Hidden;
                this.IsTag = Visibility.Hidden;
            }
        }*/
    }
}
