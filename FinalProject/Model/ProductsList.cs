using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using FinalProject.ClassContainer;

namespace FinalProject.Model
{
    public class ProductsList
    {
        public ObservableCollection<Model.Product> Products { get; set; } = new ObservableCollection<Product>();
        public ProductsList()
        {
            Products = GetProducts();
        }
        private ObservableCollection<Model.Product> GetProducts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClothesShop")))
            {
                var i = connection.GetAll<Model.Product>();
                return Helper.Convert<Model.Product>(i);
            }
        }

    }
}
