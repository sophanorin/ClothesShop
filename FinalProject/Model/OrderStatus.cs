using FinalProject.ClassContainer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinalProject.Model
{
    public class OrderStatus
    {
        public int No { get; set; }
        public ObservableCollection<CheckOutLists> Lists { get; set; }
        public SubCost SubCosts { get; set; }

        public override string ToString()
        {
            return $"No.{No:0000}\t\t {SubCosts.Total:C}\t\t {Lists[0].Description + " ....."}";
        }
    }
}
