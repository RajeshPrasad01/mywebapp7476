using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp7475.Models
{
    public class Album
    {
        private EmployeesDbContext context;

        public int emp_no { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public DateTime hire_date { get; set; }
        public string dept_no { get; set; }
        public string dept_name { get; set; }
        public int salary { get; set; }
        public string title { get; set; }
    }
}
