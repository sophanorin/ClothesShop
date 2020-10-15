using FinalProject.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject;
using System.Data;
using FinalProject.ClassContainer;
using Dapper.Contrib.Extensions;

namespace FinalProject.Model
{
    public static class EmployeeInfoContrib
    {

        public static (Model.BankAccount,Model.Employee,Model.Login)GetEmployeeInfo(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClothesShop")))
            {
                var bankaccount = connection.Get<Model.BankAccount>(id);
                var employee = connection.Get<Model.Employee>(id);
                var password = connection.Get<Model.Login>(id);
                return (bankaccount, employee,password);
            }
        }
    }
}
