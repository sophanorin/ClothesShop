using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    [Table("BankAccount")]
    public class BankAccount
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BankName { get; set; }
        public string AccountID { get; set; }
        public string CreditCard { get; set; }
    }
}
