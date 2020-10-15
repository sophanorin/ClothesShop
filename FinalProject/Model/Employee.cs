using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        public string IDcard { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string DateOfBirth { get; set; } = DateTime.Now.ToShortDateString();
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Zone { get; set; }
        public string Position { get; set; }
        public string Image{ get; set; }


        public bool InvalidationProduct()
        {
            if (string.IsNullOrEmpty(FirstName))
                return false;
            if (string.IsNullOrEmpty(LastName))
                return false;
            if (string.IsNullOrEmpty(Sex)) 
                return false;
            if (string.IsNullOrEmpty(DateOfBirth))
                return false;
            if (string.IsNullOrEmpty(Phone))
                return false;
            if (string.IsNullOrEmpty(Email)) 
                return false;
            if (string.IsNullOrEmpty(Address)) 
                return false;
            if (string.IsNullOrEmpty(Zone))
                return false;
            if (string.IsNullOrEmpty(Position))
                return false;
            if (string.IsNullOrEmpty(Image))
                return false;

            return true;
        }
    }
}
