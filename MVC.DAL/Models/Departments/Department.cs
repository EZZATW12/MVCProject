using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DAL.Models.Departments
{
    public class Department : ModelBase
    {
        public string Name { get; set; } =null!;
        public string Code { get; set; } = null!;
        public string? Description { get; set; } 
        DateOnly CreationDate { get; set; }
    }
}
