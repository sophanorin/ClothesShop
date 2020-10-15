using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    [Table("Type")]
    class Type
    {
        [Key]
        public int TypeID { get; set; }

        public string Name { get; set; }
    }
}
