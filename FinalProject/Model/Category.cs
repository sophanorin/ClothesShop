using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string Name { get; set; }
    }
}
