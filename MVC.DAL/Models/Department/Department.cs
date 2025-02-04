using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DAL.Models.Department
{
    internal class Department : ModelBase
    {
        public string Name { get; set; } =null!;
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        DateOnly CreationDate { get; set; }
    }
}
